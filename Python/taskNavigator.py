class TaskNavigator:
    def __init__(self, db_manager, task_display_widget, next_button_widget):

        self.db = db_manager 
        self.task_display = task_display_widget
        self.next_button = next_button_widget

        self.selected_theme_id = None
        self.selected_theme = None
        self.selected_type = None
        self.selected_book = None
        self.selected_number = None

        self.current_tasks = []
        self.current_task_index = 0

    # Принимает значения со списков из окон

    def on_selected_thema(self, theme_name):
        self.selected_theme = theme_name

    def on_selected_type(self, type_name):
        self.selected_type = type_name

    def on_selected_book(self, book_name):
        self.selected_book = book_name

    def on_selected_number(self, number_task):
        self.selected_number = number_task

    # Методы осуществления поиска 
 
    def find_tasks_thema_id(self, selected_theme_id):
  
        all_data = self.db.get_data_by_thema_id(selected_theme_id) 

        if all_data:
            self.current_tasks = [row[0] for row in all_data]
            self.current_task_index = 0
            self._display_current_task()

            if self.next_button:
                if len(self.current_tasks) > 1:
                    self.next_button.config(state="normal")
                else:
                    self.next_button.config(state="disabled") # Если только одна задача, кнопка не нужна
        else:
            self.task_display.update_content(f"Нет задач в базе данных."
            )
            self.current_tasks = []
            self.current_task_index = 0
            if self.next_button:
                self.next_button.config(state="disabled")


    def find_tasks_thema_type(self):
  
        all_data = self.db.get_data_by_thema_type(self.selected_theme, self.selected_type) 

        if all_data:
            self.current_tasks = [row[0] for row in all_data]
            self.current_task_index = 0
            self._display_current_task()

            if self.next_button:
                if len(self.current_tasks) > 1:
                    self.next_button.config(state="normal")
                else:
                    self.next_button.config(state="disabled") # Если только одна задача, кнопка не нужна
        else:
            self.task_display.update_content(f"Нет задач в базе данных."
            )
            self.current_tasks = []
            self.current_task_index = 0
            if self.next_button:
                self.next_button.config(state="disabled")

    def find_tasks_book_number(self):
  
        all_data = self.db.get_data_by_books(self.selected_book, self.selected_number) 

        if all_data:
            self.current_tasks = [row[0] for row in all_data]
            self.current_task_index = 0
            self._display_current_task()

            if self.next_button:
                if len(self.current_tasks) > 1:
                    self.next_button.config(state="normal")
                else:
                    self.next_button.config(state="disabled") # Если только одна задача, кнопка не нужна

        else:
            self.task_display.update_content(f"Текст задачи не найден в базе данных."
            )
            self.current_tasks = []
            self.current_task_index = 0
            if self.next_button:
                self.next_button.config(state="disabled")

    # Методы обновления окошка

    def _display_current_task(self):
        if self.current_tasks and 0 <= self.current_task_index < len(self.current_tasks):
            current_body = self.current_tasks[self.current_task_index]
            display_text = f"Задача {self.current_task_index + 1} из {len(self.current_tasks)}:\n\n{current_body}"
            self.task_display.update_content(display_text)
        else:
            self.task_display.update_content("Нет задач для отображения в текущей теме.")
            print("TaskNavigator: ОШИБКА: Попытка отобразить несуществующую задачу.")
            if self.next_button:
                self.next_button.config(state="disabled")

    def show_next_task(self):

        if self.current_tasks:
            self.current_task_index = (self.current_task_index + 1) % len(self.current_tasks) 
            self._display_current_task()
        else:
            if self.next_button:
                self.next_button.config(state="disabled")
            print("TaskNavigator: Нет задач для переключения.")
