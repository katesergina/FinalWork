// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.


string[] FilterArray(string[] array) 
{ 
    string[] result = new string[array.Length]; 
    int count = 0; 
    for (int i = 0; i < array.Length; i++) 
    { 
        if (array[i].Length <= 3) 
        { 
            result[count] = array[i]; 
            count++; 
        } 
    } 
    Array.Resize<string>(ref result, count); 
 
    return result; 
} 
 
void PrintArray(string[] array) 
{ 
    for (int i = 0; i < array.Length; i++) 
    { 
        if (i > 0) { 
            Console.Write(", "); 
        } 
        Console.Write($"{array[i]}"); 
    } 
    Console.WriteLine(); 
} 
 
string[] array1 = new string[4] { "-5", "123", "hello", "abc" }; 
PrintArray(FilterArray(array1));