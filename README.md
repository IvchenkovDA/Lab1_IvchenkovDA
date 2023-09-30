# Lab1Triangle
1 проект: Вычисление вида треугольника и координат его вершин.
Реализовать метод, который вычисляет вид треугольника и координаты
трех его вершин для отрисовки в поле 100х100 px.
Входные данные:
- строка1 (представляет длину стороны А)
- строка2 (представляет длину стороны Б)
- строка3 (представляет длину стороны С)
Ограничения: Все три строки должны представлять вещественные
положительные числа точности float. Все другие входные данные должны
считаться ошибочными, но не должны приводить к прерыванию
выполнения программы.
Выходные данные:
- Строка (представляет тип треугольника). Возможные типы –
«равносторонний», «равнобедренный», «разносторонний», «не
треугольник», «» (пустая строка для нечисловых входных данных).
- Список (или массив) из 3 кортежей вида (int, int). Кортежи представляют
координаты (X, Y) для вершины_А, вершины_Б и вершины_С,
отмасштабированные для возможности отображения вершин в поле с
размерами 100x100 px. Для числовых данных, которые не представляют
треугольник, значение всех трех координат определяется равным (-1, -1).
Для невалидных (нечисловых) данных – значения координат равны (-2, -
2).

- Логирование всех «успешных» запросов: дата-время запроса, параметры
запроса, результаты запроса (тип треугольника и координаты его
вершин).
- Логирование всех «неуспешных» запросов: дата-время запроса, параметры
запроса, результат запроса и/или текст ошибки (включая трассировку
стека исключения).

- Логирование должно быть реализовано в файл и в консоль.
- «Успешные» запросы – это запросы, которые приводят к вычислению
следующих видов треугольников: «равносторонний»,
«равнобедренный», «разносторонний». «Неуспешные» запросы – все
остальные (в том числе те, которые приводят к ошибкам).
