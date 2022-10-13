// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
//  Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решенни не рекомендуется пользоваться коллекциями, лучше обойтись исключительно масснвами.
// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", "-) "]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> D


// Контрольная работа

Console.Clear();

Console.Write("Введите слова или символы или цифры через пробел: ");
string[] array = Console.ReadLine().Split(' ').ToArray();

void PrintArray(string[] arra)
{
    Console.Write("[");
    for (int i = 0; i < arra.Length; i++)
    {
        if (arra[i] == arra[arra.Length - 1]) Console.Write($"'{arra[i]}'");
        else Console.Write($" '{arra[i]}',");
    }
    Console.Write("]");
}
string[] GetNewArray(string[] arra)
{

    Console.Write(" - > [");
    string[] ResultArray = new string[arra.Length];
    for (int i = 0; i < arra.Length; i++)
    {
        if (arra[i].Length < 4)
        {
            ResultArray[i] = arra[i];
            if (ResultArray[i] == ResultArray[ResultArray.Length - 1]) Console.Write($"'{ResultArray[i]}'");
            else Console.Write($" '{ResultArray[i]}'");
        }
    }
    Console.Write("]");
    return ResultArray;
}
PrintArray(array);
GetNewArray(array);
