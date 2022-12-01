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
string[] FillArrayShortStrings(string[] array)
{
   int count = 0; 
   for (int i = 0; i < array.Length; i++)
   {
        if(array[i].Length <= 3) count++;
   }
   string[] newArray = new string[count];
   count = 0;
   for (int i = 0; i < array.Length; i++)
   {
        if(array[i].Length <= 3)
        {
            newArray[count] = array[i];
            count++;
        }
   }
   return newArray;
}

Console.WriteLine("УКажите желаемый размер массива - любое целое положительное число: ");
int lenght = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите любые слова или наборы букв любой длины через Enter: ");
string[] strMassive = CreateArrayFromUser(lenght);
string[] newStrMassive = FillArrayShortStrings(strMassive);