// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры либо задать на старте выполнения алгоритма. 

Console.Clear();
string[] CreateArrayFromUser(int size)
{
string[] array = new string[size];
for (int i = 0; i < size; i++)
{
array[i] = Console.ReadLine();
}
return array;
}
 
Console.WriteLine("УКажите желаемый размер массива - любое целое положительное число: ");
int lenght = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите любые слова или наборы букв любой длины через Enter: ");
string[] stringsMassive = CreateArrayFromUser(lenght);