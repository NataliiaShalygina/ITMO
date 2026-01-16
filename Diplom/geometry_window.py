import tkinter as tk
from base_window import *
from bd import DatabaseManager
from taskNavigator import TaskNavigator
from doska import DrawingBoard

class GeometryWindow(Window):
    def __init__(self, master, width=1200, height=1500):
        super().__init__(title="Онлайн доска", master=master)

        self.db = DatabaseManager()
        
        # Переменны дисплея и кнопки
        
        self.task_display = None
        self.next_button = None   
        
        # Создание кортежей для выбора значений

        theme_names = self.db.get_all_codes()
        book_names = self.db.get_all_books()
        type_names = ["Доказательство","Решение","Построение"]

        # Если оба пусты (значит, пусто и в БД) - предупреждение

        if (not theme_names) and (not book_names):
            tk.Label(self.scrollable_frame, text="В базе пока нет задач", font=("Arial", 12), bg=self.bg).pack(pady=50)
            self.task_display = InfoBlock(
                parent=self.scrollable_frame, 
                body_text="Задачи убежали, но мы работаем над ошибкой!"
            ) 
            self.task_display.pack(padx=20, pady=20, fill="x", expand=False)
            return

	# Блок первого поиска - два списка и кнопка "Найти"   

        self.control_frame1 = tk.Frame(self.scrollable_frame, bg=self.bg)
        self.control_frame1.pack(pady=5, padx=15, fill="x")
        tk.Label(self.control_frame1, text="По теме:", font=("Courier New", 14), bg=self.bg).pack(padx=5)

        self.dropdown1 = CustomDropdown(
            parent=self.control_frame1, 
            label_text="Выберите тему:", 
            options=theme_names,
            callback=self._on_theme_selected_wrapper
        )
        
        self.dropdown2 = CustomDropdown(
            parent=self.control_frame1, 
            label_text="Выберите тип:", 
            options=type_names,
            callback=self._on_type_selected_wrapper
        )
       
        self.find_button1 = CustomButton(
            parent=self.control_frame1,
            text="Найти",
            command=self._find_task_thema_type_wrapper
        )
        self.find_button1.pack(padx=5, pady=5)

        # Блок второго поиска - список, ввод с клавиатуры и кнопка "Найти"    
        
        self.control_frame2 = tk.Frame(self.scrollable_frame, bg=self.bg)
        self.control_frame2.pack(pady=5, padx=15, fill="x")
        tk.Label(self.control_frame2, text="По учебнику:", font=("Courier New", 14), bg=self.bg).pack(padx=5)

        self.dropdown3 = CustomDropdown(
            parent=self.control_frame2, 
            label_text="Выберите учебник:", 
            options=book_names,
            callback=self._on_book_selected_wrapper
        )
        
        tk.Label(self.control_frame2, text="Номер задачи:", font=("Arial", 11, "bold"), bg=self.bg).pack(side="left", pady=0, padx=35)
        
        # Ввод с клавиатуры
        self.entry_text_var = tk.StringVar()
        self.entry_text_var.trace_add("write", self._filter_entry) 
        number_entry_widget = tk.Entry(
            self.control_frame2,
            textvariable=self.entry_text_var,
            font=("Arial", 16),
            width=20,
            justify="center",
            bd=2, relief="groove" 
        )
        number_entry_widget.pack(side="left")
        number_entry_widget.bind("<KeyRelease>", lambda event: self._on_number_selected_wrapper())
       
        self.find_button2 = CustomButton(
            parent=self.control_frame2,
            text="Найти",
            command=self._find_task_book_number_type_wrapper
        )
        self.find_button2.pack(side="left", pady=5, padx=10)

        # Окно для вывода и кнопка переключения

        self.task_display = InfoBlock(
            parent=self.scrollable_frame, 
            body_text="Выберите тему из списка и нажмите кнопку 'Найти'."
        )
        self.task_display.pack(padx=20, pady=20, fill="both", expand=False)

        self.next_button = CustomButton(
            parent=self.scrollable_frame,
            text="Следующая",
            command=self._show_next_task_wrapper, 
            state="disabled"
        )
        self.next_button.pack(padx=5)
     
        # Cоздание объекта для поиска и обновления окна

        self.task_navigator = TaskNavigator(
            db_manager=self.db,
            task_display_widget=self.task_display,
            next_button_widget=self.next_button
        )
        
        # Если ничего не выбрано, передаёт первое значение из списка (поиск по умолчанию)
        
        self.task_navigator.selected_theme = theme_names[0] 
        self.task_navigator.selected_type = type_names[0] 
        self.task_navigator.selected_book = book_names[0]
        self.task_navigator.selected_number = 290

    # Создание доски - объект класса

        self.board = DrawingBoard(self.scrollable_frame)
        
    # Сохраняет значения для каждого параметра из списка и передаёт в класс навигатора
     
    def _on_theme_selected_wrapper(self, theme_name):
        self.task_navigator.on_selected_thema(theme_name)
     
    def _on_type_selected_wrapper(self, type_name):
       self.task_navigator.on_selected_type(type_name)  

    def _on_book_selected_wrapper(self, book_name):
       self.task_navigator.on_selected_book(book_name)  
   
    def _on_number_selected_wrapper(self):
       number_task_txt = self.entry_text_var.get()
       number_task = int(number_task_txt)
       self.task_navigator.on_selected_number(number_task)

    # Осуществляет поиск в зависимости от кнопки "Найти" (вызывает методы поиска из Навигатора)

    def _find_task_thema_type_wrapper(self):
        self.task_navigator.find_tasks_thema_type()

    def _find_task_book_number_type_wrapper(self):
        self.task_navigator.find_tasks_book_number()

    # Метод для переключения задачи

    def _show_next_task_wrapper(self):
        self.task_navigator.show_next_task()
     
    # Метод для отслеживания вводимого знчения во втором блоке - не допускает ввод символов 

    def _filter_entry(self, *args):
        value = self.entry_text_var.get()
        new_value = "".join(filter(str.isdigit, value))
        if value != new_value:
            self.entry_text_var.set(new_value)

