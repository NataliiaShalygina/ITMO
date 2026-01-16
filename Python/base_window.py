import tkinter as tk
from tkinter import ttk 
from PIL import Image, ImageTk

# Класс окон

class Window: 
    def __init__(self, title, width=1200, height=900, bg="#bde0ff", master=None):
        self.title = title
        self.width = width
        self.height = height
        self.bg = bg
        self.master = master

        if master is None:
            self.root = tk.Tk()
            self.is_root = True
        else:
            self.root = tk.Toplevel(master)
            self.is_root = False

        self._setup()

        # Блок прокрутки страницы

        # Контейнер для "разделения" на ползунок и канвас
        self.main_container = tk.Frame(self.root, bg=self.bg)
        self.main_container.pack(fill="both", expand=True)
       
        # Элемент канвас для визуализации прокрутки
        self.canvas = tk.Canvas(self.main_container, bg=self.bg, highlightthickness=0)
        self.canvas.pack(side="left", fill="both", expand=True)

        # Ползунок
        self.scrollbar = tk.Scrollbar(self.main_container, orient="vertical", command=self.canvas.yview)
        self.scrollbar.pack(side="right", fill="y")
  
        # Связь между холстом и ползунком для динамического изменения положения
        self.canvas.configure(yscrollcommand=self.scrollbar.set)
        
        # Создание динамического "листа" внутри канвас и его упаковка в канвас
        self.scrollable_frame = tk.Frame(self.canvas, bg=self.bg)
        self.canvas_frame = self.canvas.create_window((0, 0), window=self.scrollable_frame, anchor="nw", width=self.width)
        
        # Динамика (привязка методов к событию)
        self.scrollable_frame.bind("<Configure>", self._on_frame_configure)
        self.canvas.bind("<Configure>", self._on_canvas_configure)
        self.root.bind_all("<MouseWheel>", self._on_mousewheel)
    
    def _on_frame_configure(self, event):
        self.canvas.configure(scrollregion=self.canvas.bbox("all"))

    def _on_canvas_configure(self, event):
        self.canvas.itemconfig(self.canvas_frame, width=event.width)

    def _on_mousewheel(self, event):
        self.canvas.yview_scroll(int(-1*(event.delta/120)), "units")

    # Внешний вид окна 
    def _setup(self):
        self.root.title(self.title)
        self.root.configure(bg=self.bg)
        self.root.state("zoomed") # Открывает во весь экран
     
    # Запуск окна    
    def run(self):
        self.root.mainloop()

# Иконки при запуске приложения (стартовая страница), которые перекидывают на другие окна

class Icon:
    def __init__(self, master_window, image_path, window_class, text="", place_to_put=None):
        self.master_window = master_window
        self.window_class = window_class
        self.opened_window = None
        self.label_text = text

        # Положение иконок - в контейнере, если он задан, если нет - привязка к родительскому окну
        self.target_container = place_to_put if place_to_put is not None else self.master_window.scrollable_frame
  
        # Положение иконок внутри родителя
        self.icon_block_frame = tk.Frame(self.target_container, bg=self.master_window.bg)
        self.icon_block_frame.pack(side="left", padx=30, pady=30, expand=True) 
      
        # Загрузка иконки (обратывает исключение, когда картинки нет)
        try:
            img = Image.open(image_path).resize((200, 200))
            self.photo = ImageTk.PhotoImage(img)
            self.button = tk.Button(
                self.icon_block_frame,
                image=self.photo, 
                command=self.click,
                bd=0, bg=self.master_window.bg, cursor="hand2")
        except Exception as e:
            print(f"Ошибка загрузки иконки '{image_path}': {e}. Используем текстовую кнопку.")
            self.button = tk.Button(self.icon_block_frame, text="?", command=self.click, width=10, height=5, bg=self.master_window.bg)
        self.button.pack(pady=5)

        if self.label_text:
            self.label = tk.Label(
                self.icon_block_frame,
                text=self.label_text, 
                bg=self.master_window.bg, 
                font=("Arial", 12)
            )
            self.label.pack(pady=2)

    # Создаёт окно, проверив, не открыто ли оно уже
    def click(self):
        if self.opened_window is None or not self.opened_window.root.winfo_exists():
            self.opened_window = self.window_class(self.master_window.root)
        else:
            self.opened_window.root.lift()
            self.opened_window.root.focus_force()

# Создание класса для вывода задач
 
class InfoBlock:
    def __init__(self, parent, body_text, bg_color="#cafced", width=200, font=("System", 15)):
        self.bg_color = bg_color
        self.width = width
      
        self.frame = tk.Frame(
            parent, 
            bg=bg_color, 
            bd=2, 
            relief="groove"
        )
        
        self.text_label = tk.Label(
          self.frame, 
          text=body_text, 
          font=font, 
          bg=bg_color,
          justify="center",
          anchor="center",
          wraplength=round(width*0,1)
        )
        self.text_label.pack(fill="both", padx=15, pady=15, expand=True)

    def update_content(self, new_body):
        self.text_label.config(text=new_body)

    def pack(self, **kwargs):
      self.frame.pack(**kwargs)

# Класс выпадающих списков

class CustomDropdown:
    def __init__(self, parent, label_text, options, callback):
        self.callback = callback
      
        self.container = tk.Frame(parent, bg=parent["bg"])
        self.container.pack(pady=5, padx=30, fill="x")

        tk.Label(self.container, text=label_text, bg=parent["bg"], font=("Arial", 11,"bold")).pack(side="left", padx=5)

        self.combo = ttk.Combobox(self.container, values=options, state="readonly", font=("Arial", 11))
        self.combo.pack(side="left", padx=5, expand=True, fill="x")
        
        if options:
            self.combo.current(0)

        self.combo.bind("<<ComboboxSelected>>", self._on_select)

    def _on_select(self, event):
        val = self.combo.get()
        self.selected_value = val

        if self.callback:
            self.callback(val)

# Класс для кнопок

class CustomButton:
    def __init__(self, parent, text, command, bg_color="#cafced", fg_color="black", 
                 font=("Arial", 10, "bold"), padx=10, pady=5, relief="raised", state="normal"):
        
        self.button = tk.Button(
            parent,
            text=text,
            command=command,
            font=font,
            bg=bg_color,
            fg=fg_color,
            padx=padx,
            pady=pady,
            relief=relief,
            state=state
        )

    def pack(self, **kwargs):
        self.button.pack(**kwargs)
        
    def config(self, **kwargs):
        self.button.config(**kwargs)
