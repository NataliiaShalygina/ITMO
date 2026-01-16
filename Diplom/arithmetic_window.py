import tkinter as tk
import random
from fractions import Fraction 
from base_window import Window, InfoBlock, CustomDropdown, CustomButton

class ArithmeticWindow(Window):
    def __init__(self, master):
        super().__init__(title="Калькулятор", master=master)

        # Содержимое информационных контейнеров
        self.strrand = ""
        self.obdrob = "" 
        self.randomprimer = ""

        # Первый блок - контейнер + кнопка, запускающая обновление контента (генерация чисел)
        tk.Label(self.scrollable_frame, text="Таблица умножения:", font=("Courier New", 14), bg=self.bg).pack(pady=15)
        
        self.task_display1 = InfoBlock(
            parent=self.scrollable_frame, 
            body_text=self.strrand,
            font=("Arial", 20)
        )
        self.task_display1.pack(padx=20, pady=20, fill="both", expand=False)
        
        self.find_button1 = CustomButton(
            parent=self.scrollable_frame,
            text="Сгенерировать",
            command=self.randomTablMn
        )
        self.find_button1.pack(padx=5)

        # Второй блок - контейнер + кнопка, запускающая обновление контента (генерация чисел и отображение дробей)
        tk.Label(self.scrollable_frame, text="Вычислить:", font=("Courier New", 14), bg=self.bg).pack(pady=5)
        self.task_display2 = InfoBlock(
            parent=self.scrollable_frame, 
            body_text=self.obdrob,
            font=("Arial", 20)
        )
        self.task_display2.pack(padx=20, pady=20, fill="both", expand=False)

        self.find_button2 = CustomButton(
            parent=self.scrollable_frame,
            text="Сгенерировать",
            command=self.randomObDrob
        )
        self.find_button2.pack(padx=5)

        # Третий блок - контейнер + кнопка, запускающая обновление контента (генерация примера)
        self.task_display3 = InfoBlock(
            parent=self.scrollable_frame, 
            body_text=self.randomprimer,
            font=("Arial", 20)
        )
        self.task_display3.pack(padx=20, pady=20, fill="both", expand=False)

        self.find_button3 = CustomButton(
            parent=self.scrollable_frame,
            text="Сгенерировать",
            command=self.randomPrimer
        )
        self.find_button3.pack(padx=5)

    # Методы для генерации значений и передачи их блоку

    def randomTablMn(self):
        self.strrand= str(random.randint(1,15))+' x ' +str(random.randint(1,15))+' = '
        print(self.strrand)
        self.task_display1.update_content(self.strrand)
    
    def randomObDrob(self):
        frac1 = Fraction(random.randint(1,300),random.randint(1,300))
        frac2 = Fraction(random.randint(1,300),random.randint(1,300))
        znaki = '+-x:'
        self.obdrob= str(frac1)+' '+random.choice(znaki)+' '+str(frac2)+' = '
        print(self.obdrob)
        self.task_display2.update_content(self.obdrob)

    def randomPrimer(self):
        frac = Fraction(random.randint(1,50),random.randint(1,50))
        znaki = '+-'
        self.randomprimer= str(frac)+' '+random.choice(znaki)+' '+str(round((random.random()*10+1),2))+' '+random.choice(znaki)+' '+str(random.randint(1,50))+' = '
        print(self.obdrob)
        self.task_display3.update_content(self.randomprimer)
