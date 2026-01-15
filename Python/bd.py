import pyodbc

class DatabaseManager:
    def __init__(self):
#   Настройки подключения
      self.driver = '{ODBC Driver 18 for SQL Server}'
      self.server = r'DESKTOP-MAHVHFA\SQLEXPRESS' # Укажите имя вашего сервера
      self.database = '01'       # Укажите имя вашей базы данных
      self.username = 'User999'             # Тот логин, который создали
      self.password = 'math999'         # Тот пароль, который создали

#  Строка подключения (для проверки подлинности SQL Server)
      self.conn_str = (
      f'DRIVER={self.driver};'
      f'SERVER={self.server};'
      f'DATABASE={self.database};'
      f'UID={self.username};'
      f'PWD={self.password};'
      'TrustServerCertificate=yes;'
       )
 # Метод создания и возвращения объекта полключения
    def _get_connection(self):
      return pyodbc.connect(self.conn_str)

 # Методы формирования и отправки запросов

    def get_data_by_thema_id(self, thema_task):
        try:
            with self._get_connection() as conn:
                with conn.cursor() as cursor:
                    query = """
                SELECT TekstTask
                FROM TextTask 
                WHERE CodeThema = ?
                """
                    cursor.execute(query, (thema_task))
                    rows = cursor.fetchall()
                    return rows 
        except Exception as e:
            print(f"Ошибка при запросе к БД: {e}")
            return [] # Возвращаем пустой список в случае ошибки


    def get_data_by_thema_type(self, thema_task, type_task):
        try:
            with self._get_connection() as conn:
                with conn.cursor() as cursor:
                    query = """
                SELECT tt.TekstTask
                FROM TextTask tt 
                INNER JOIN Thema t
                ON tt.CodeThema = t.CodeThema
                INNER JOIN TypeTask tp
                ON tp.CodeTask=tt.CodeTask
                WHERE RTRIM(t.Thema) = ? AND RTRIM(tp.TypeTask) = ?
                """
                    cursor.execute(query, (thema_task, type_task))
                    rows = cursor.fetchall()
                    return rows 
        except Exception as e:
            print(f"Ошибка при запросе к БД: {e}")
            return [] # Возвращаем пустой список в случае ошибки

    def get_data_by_books(self, book_task, number_task):
        try:
            with self._get_connection() as conn:
                with conn.cursor() as cursor:
                    query = """
                SELECT tt.TekstTask
                FROM TextTask tt  
                INNER JOIN Manual m
                ON tt.CodeManual = m.CodeManual
                WHERE RTRIM(m.Manual) = ? AND RTRIM(tt.NumberTask) = ?
                """
                    cursor.execute(query, (book_task, number_task))
                    rows = cursor.fetchall()
                    return rows 
        except Exception as e:
            print(f"Ошибка при запросе к БД: {e}")
            return [] # Возвращаем пустой список в случае ошибки
 
    # Методы извлечения объектов для создания списков

    def get_all_codes(self):
        try:
            with self._get_connection() as conn:
                with conn.cursor() as cursor:
                    query = "SELECT Thema FROM Thema WHERE FieldThema='Геометрия'"
                    cursor.execute(query)
                    rows = cursor.fetchall()
                    codes = [row[0] for row in rows]
                return codes
        except Exception as e:
            print(f"Ошибка при получении кодов: {e}")
            return []
    
    def get_all_books(self):
        try:
            with self._get_connection() as conn:
                with conn.cursor() as cursor:
                    query = "SELECT Manual FROM Manual WHERE Manual LIKE 'Г%' OR Manual LIKE 'О%'"
                    cursor.execute(query)
                    rows = cursor.fetchall()
                    codes = [row[0] for row in rows]
                return codes
        except Exception as e:
            print(f"Ошибка при получении кодов: {e}")
            return []


if __name__ == "__main__":
    db = DatabaseManager()
    try:
        connection = db._get_connection()
        print("Подключение к SQL Server прошло успешно!")
        connection.close()
    except Exception as e:
        print(f"Ошибка подключения: {e}")
