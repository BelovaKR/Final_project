string[] array = new string[4] { "Hello", "2", "world", ":-)" };
// string[] array = new string[4] { "1234", "1567", "-2", "computer science" };
// string[] array = new string[3] { "Russia", "Denmark", "Kazan" };

Console.Clear();
Console.WriteLine($"Оригинальный массив: [ {string.Join(", ", array)} ]");

int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
        count++;
}

if (count > 0)
{
    Console.WriteLine($"В массиве {count} элементов, длинной до трех символов");
    string[] rez = new string[count];
    count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= 3)
        {
            rez[count] = array[i];
            count++;
        }
    Console.WriteLine($"Результирующий массив: [ {string.Join(", ", rez)} ]");
}  
else
{
    Console.WriteLine($"В массиве нет элементов, длинной до трех символов.");
} 
