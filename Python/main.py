import tkinter as tk
from PIL import Image, ImageTk
from base_window import Window, Icon
from arithmetic_window import ArithmeticWindow
from algebra_window import AlgebraWindow
from geometry_window import GeometryWindow

class MainPage(Window):
    def __init__(self):
        super().__init__(title="Математический тренажёр", )
        
        # Заголовок
        self.label = tk.Label(self.scrollable_frame, text="Выберите раздел", font=("Courier New", 20), bg=self.bg)
        self.label.pack(pady=30)

        # Контейнер для иконок
        self.icon_frame = tk.Frame(self.scrollable_frame, bg=self.bg, highlightbackground="silver", highlightthickness=2)
        self.icon_frame.pack(fill="x", expand=True)

        # Иконки
        self.icon1 = Icon(self, "math_app/icon1.png", ArithmeticWindow, text="Арифметика", place_to_put=self.icon_frame)
        self.icon2 = Icon(self, "math_app/icon2.png", AlgebraWindow, text="Алгебра", place_to_put=self.icon_frame)
        self.icon3 = Icon(self, "math_app/icon3.png", GeometryWindow, text="Геометрия", place_to_put=self.icon_frame)


# --- ЗАПУСК ---
if __name__ == "__main__":
    app = MainPage()
    app.run()
