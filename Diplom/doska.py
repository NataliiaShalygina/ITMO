
import tkinter as tk
from tkinter import colorchooser

class DrawingBoard:
    def __init__(self, parent, bg_color="#ffffff"):
        self.parent = parent
        self.color = "black"
        self.thickness = 2
        self.tool = "pencil"  # текущий инструмент
        
        # Переменные для рисования
        self.start_x = None
        self.start_y = None
        self.current_item = None
        
        # Для спец. метода окружности
        self.circle_radius = None
        self.radius_point1 = None
        
        # Основной фрейм доски
        self.main_frame = tk.Frame(parent, bg="#d0d0d0", bd=2, relief="sunken")
        self.main_frame.pack(padx=20, pady=10, fill="both", expand=True)

        # Панель инструментов
        self.toolbar = tk.Frame(self.main_frame, bg="#eeeeee")
        self.toolbar.pack(side="top", fill="x", anchor="center", expand=True)

        self._build_toolbar()

        # Холст
        self.canvas = tk.Canvas(self.main_frame, bg=bg_color, cursor="cross", height=400)
        self.canvas.pack(fill="both", expand=True)

        # Привязка событий мыши
        self.canvas.bind("<Button-1>", self.on_button_press)
        self.canvas.bind("<B1-Motion>", self.on_move)
        self.canvas.bind("<ButtonRelease-1>", self.on_release)

    def _build_toolbar(self):
        # Очистка и Ластик
        tk.Button(self.toolbar, text="Очистить", command=self.clear_canvas).pack(side="left", padx=10)
        tk.Button(self.toolbar, text="Ластик", command=lambda: self.set_tool("eraser")).pack(side="left", padx=10)
        
        # Цвет и Толщина
        tk.Button(self.toolbar, text="Цвет", command=self.choose_color).pack(side="left", padx=10)
        self.thickness_scale = tk.Scale(self.toolbar, from_=1, to=10, orient="horizontal", label="Размер")
        self.thickness_scale.set(2)
        self.thickness_scale.pack(side="left", padx=10)

        # Фигуры
        tools = [
            ("Прямоугольник", "pencil"), ("Линия", "line"), 
            ("Квадрат", "square"), ("Прямоугольник", "triangle"), 
            ("Ромб", "rhombus"), ("Параллелограмм", "parallelogram"),
            ("Окружность(R)", "circle_radius"),
            ("Угол 90°", "right_angle")
        ]
        for text, tool in tools:
            btn = tk.Button(self.toolbar, text=text, command=lambda t=tool: self.set_tool(t))
            btn.pack(side="left", padx=5)

    def set_tool(self, tool):
        self.tool = tool
        self.radius_point1 = None # Сброс замера радиуса при смене инструмента

    def choose_color(self):
        color = colorchooser.askcolor(title="Choose color")[1]
        if color: self.color = color

    def clear_canvas(self):
        self.canvas.delete("all")

    def on_button_press(self, event):
        self.start_x, self.start_y = event.x, event.y
        self.thickness = self.thickness_scale.get()

        if self.tool == "circle_radius":
            if self.radius_point1 is None:
                self.radius_point1 = (event.x, event.y)
            elif self.circle_radius is None:
                dx = event.x - self.radius_point1[0]
                dy = event.y - self.radius_point1[1]
                self.circle_radius = (dx**2 + dy**2)**0.5
                print(f"Радиус установлен: {int(self.circle_radius)}")
            else:
                r = self.circle_radius
                self.canvas.create_oval(event.x-r, event.y-r, event.x+r, event.y+r, 
                                        outline=self.color, width=self.thickness)
                self.circle_radius = None # Сброс после построения
                self.radius_point1 = None

    def on_move(self, event):
        if self.tool == "pencil":
            self.canvas.create_line(self.start_x, self.start_y, event.x, event.y, 
                                    fill=self.color, width=self.thickness, capstyle="round")
            self.start_x, self.start_y = event.x, event.y
        
        elif self.tool == "eraser":
            # Просто рисуем фоновым цветом (белым)
            self.canvas.create_line(self.start_x, self.start_y, event.x, event.y, 
                                    fill="white", width=20, capstyle="round")
            self.start_x, self.start_y = event.x, event.y

        elif self.tool in ["line", "square", "triangle", "rhombus", "parallelogram","right_angle"]:
            # Предпросмотр фигуры (удаляем старую, рисуем новую)
            if self.current_item: self.canvas.delete(self.current_item)
            self.current_item = self.draw_shape(self.start_x, self.start_y, event.x, event.y)

    def on_release(self, event):
        self.current_item = None

    def draw_shape(self, x1, y1, x2, y2):
        t = self.thickness
        c = self.color
        if self.tool == "line":
            return self.canvas.create_line(x1, y1, x2, y2, fill=c, width=t)
        
        elif self.tool == "square":
            return self.canvas.create_rectangle(x1, y1, x2, y2, outline=c, width=t)
        
        elif self.tool == "triangle":
            return self.canvas.create_polygon(x1, y2, x2, y2, (x1+x2)/2, y1, 
                                              fill="", outline=c, width=t)
        
        elif self.tool == "rhombus":
            mid_x, mid_y = (x1+x2)/2, (y1+y2)/2
            return self.canvas.create_polygon(mid_x, y1, x2, mid_y, mid_x, y2, x1, mid_y, 
                                              fill="", outline=c, width=t)
        
        elif self.tool == "parallelogram":
            offset = (x2 - x1) * 0.2
            return self.canvas.create_polygon(x1+offset, y1, x2, y1, x2-offset, y2, x1, y2, 
                                              fill="", outline=c, width=t)
        
        elif self.tool == "right_angle":
            return self.canvas.create_line(x1, y1, x1, y2, x2, y2, fill=c, width=t)
