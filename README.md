## Задача
**Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
Первоначальный массив можно ввести с клавиатуры либо задать на старте выполнения алгоритма.**

### При решении данной задачи руководствовалась следующей логикой:
1. Прежде всего необходимо создать массив строк. Выбран вариант, при котором пользователь задает размер будущего массива и вводит поочередно строковые элементы. 
   Создаем метод для заполнения массива пользователем.
2. Поскольку с динамическими массоивами мы еще не работали, для создания нового массива из элементов не длиннее 3 символов необходимо определить количество таких 
   элементов в массиве пользователя с помощью цикла и счетчика count. 
3. Затем мы создаем новый массив  размера count и присваиваем его эелементам соответствующие значения из изначального массива. 
   Действия из пунктов 2-3 мы вывели в отдельный метод.
4. Полученный массив необходимо вывести в консоль. Создаем метод для вывода.
5. Пишем собственно код с использованием методов: запрашиваем у пользователя размер будущего массива, создаем из него новый с короткими строками и выводим в консоль.
