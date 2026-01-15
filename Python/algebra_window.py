import tkinter as tk
import random
from base_window import Window, InfoBlock, CustomButton
from taskNavigator import TaskNavigator

from bd import DatabaseManager

class AlgebraWindow(Window):
    def __init__(self, master):
        super().__init__(title="Уравнения и неравенства", master=master)

        self.db = DatabaseManager()
        self.lineex = "" 
        self.squex = ""
        self.inequal = ""

        # Блок для линейных уравнений (окошко, генерация и вызов из базы)

        self.control_frame1 = tk.Frame(self.scrollable_frame, bg=self.bg)
        self.control_frame1.pack(pady=5, padx=15, fill="x")
        tk.Label(self.control_frame1, text="Линейные уравнения:", font=("Courier New", 14), bg=self.bg).pack(pady=15)
        
        self.task_display1 = InfoBlock(
            parent=self.control_frame1, 
            body_text=self.lineex,
        )
        self.task_display1.pack(padx=20, pady=20, fill="both", expand=False)
        
        self.gen_button1 = CustomButton(
            parent=self.control_frame1,
            text="Сгенерировать",
            command=self.generate_line_ex
        )        
        self.gen_button1.pack(side="left", padx=100)
        
        self.find_button1 = CustomButton(
            parent=self.control_frame1,
            text="Найти",
            command=self._find_task_lin_ex_wrapper
        )
        self.find_button1.pack(side="left", padx=100, pady=5)

        self.next_button1 = CustomButton(
            parent=self.control_frame1,
            text="Следующая",
            command=self._show_next_task_lin_ex_wrapper, 
            state="disabled"
        )
        self.next_button1.pack(side="left", padx=100, pady=5)

        self.task_navigator1 = TaskNavigator(
            db_manager=self.db,
            task_display_widget=self.task_display1,
            next_button_widget=self.next_button1
        )
    
    # Блок для квадратных уравнений (окошко, генерация и вызов из базы)

        self.control_frame2 = tk.Frame(self.scrollable_frame, bg=self.bg)
        self.control_frame2.pack(pady=5, padx=15, fill="x")
        tk.Label(self.control_frame2, text="Квадратные уравнения:", font=("Courier New", 14), bg=self.bg).pack(pady=15)
        
        self.task_display2 = InfoBlock(
            parent=self.control_frame2, 
            body_text=self.squex,
        )
        self.task_display2.pack(padx=20, pady=20, fill="both", expand=False)
        
        self.gen_button2 = CustomButton(
            parent=self.control_frame2,
            text="Сгенерировать",
            command=self.generate_squex_ex
        )        
        self.gen_button2.pack(side="left", padx=100)
        
        self.find_button2 = CustomButton(
            parent=self.control_frame2,
            text="Найти",
            command=self._find_task_squex_ex_wrapper
        )
        self.find_button2.pack(side="left", padx=100, pady=5)

        self.next_button2 = CustomButton(
            parent=self.control_frame2,
            text="Следующая",
            command=self._show_next_task_squex_ex_wrapper, 
            state="disabled"
        )
        self.next_button2.pack(side="left", padx=100, pady=5)

        self.task_navigator2 = TaskNavigator(
            db_manager=self.db,
            task_display_widget=self.task_display2,
            next_button_widget=self.next_button2
        )

    # Блок для неравенств (окошко и вызов из базы)

        self.control_frame3 = tk.Frame(self.scrollable_frame, bg=self.bg)
        self.control_frame3.pack(pady=5, padx=15, fill="x")
        tk.Label(self.control_frame3, text="Неравенства:", font=("Courier New", 14), bg=self.bg).pack(pady=15)
        
        self.task_display3 = InfoBlock(
            parent=self.control_frame3, 
            body_text=self.inequal
        )
        self.task_display3.pack(padx=20, pady=20, fill="both", expand=False)
        
        self.find_button3 = CustomButton(
            parent=self.control_frame3,
            text="Найти",
            command=self._find_task_inequal_wrapper
        )
        self.find_button3.pack(side="left", padx=250, pady=5)

        self.next_button3 = CustomButton(
            parent=self.control_frame3,
            text="Следующая",
            command=self._show_next_task_inequal_wrapper, 
            state="disabled"
        )
        self.next_button3.pack(side="left", padx=50, pady=5)

        self.task_navigator3 = TaskNavigator(
            db_manager=self.db,
            task_display_widget=self.task_display3,
            next_button_widget=self.next_button3
        )

    # Методы генерации

    def generate_line_ex(self):
        znaki = '+-'
        self.lineex= str(round((random.random()*10+1),1))+'x'+' '+random.choice(znaki)+str(random.randint(1,300))+" "+' = '+str(random.randint(1,300))
       # print(self.strrand)
        self.task_display1.update_content(self.lineex)

    def generate_squex_ex(self):
        a = random.randint(1,5)
        x1 = random.randint(1,5)
        x2 = random.randint(6,15)
        self.squex= str(a)+'x²'+' + '+str(a*x2 - a*x1)+'x'+' - '+str(a*x1*x2)+' = 0 '
        self.task_display2.update_content(self.squex)
  
    # Методы для работы с базой
   
    def _find_task_lin_ex_wrapper(self):
        thema_id = 13
        self.task_navigator1.find_tasks_thema_id(thema_id)
 
    def _find_task_squex_ex_wrapper(self):
        thema_id = 14
        self.task_navigator2.find_tasks_thema_id(thema_id)

    def _find_task_inequal_wrapper(self):
        thema_id = 15
        self.task_navigator3.find_tasks_thema_id(thema_id)
    
    def _show_next_task_lin_ex_wrapper(self):
        self.task_navigator1.show_next_task()

    def _show_next_task_squex_ex_wrapper(self):
        self.task_navigator2.show_next_task()

    def _show_next_task_inequal_wrapper(self):
        self.task_navigator3.show_next_task()
