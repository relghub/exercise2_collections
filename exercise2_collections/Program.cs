/* 1. Сформувати колекцію з N цілих
випадкових чисел, що належать до інтервалу
[1;90]. Видалити з колекції всі числа, які є
кратними 3 і закінчуються на цифру 5. */

Console.InputEncoding = System.Text.Encoding.UTF8;
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Завдання 1");
Random rnd = new Random();
int N;
var ListTest = new List<int>();
while (true)
{
    Console.Write("Введіть кількість чисел: ");
    try
    {
        N = int.Parse(Console.ReadLine());
        if (N > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Введено недопустиму величину. Спробуйте знову.");
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Введено недопустиму величину. Спробуйте знову.");
    }
}
for (int i = 0; i < N; i++)
{
    ListTest.Add(rnd.Next(1,90));
}
Console.WriteLine("До обробки");
foreach (int i in ListTest)
{
    Console.Write($"{i}, ");
}
foreach (int i in ListTest.ToList())
{
    if (i % 3 == 0 && i % 5 == 0 && i % 10 != 0)
    {
        ListTest.Remove(i);
    }
}
Console.WriteLine("\nПісля обробки");
foreach (int i in ListTest)
{
    Console.Write($"{i}, ");
}
/*2. Сформувати колекцію з N символів. Символи
вводити з клавіатури. Переписати в іншу колекцію всі
знаки пунктуації і знайти їх кількість.*/
Console.WriteLine("\nЗавдання 2");
Console.Write("Введіть рядок з довільними символами: ");
List<char> ListPunctuation = new() {'.',',','?',';', '!', ':', '-', '_', '/', '@', '*'};
var ListSymbols = new List<char>();
string? InputText = Console.ReadLine();
foreach (char i in InputText)
{
    if (ListPunctuation.Contains(i)) 
    {
        ListSymbols.Add(i);
    }
}
Console.WriteLine($"Кількість символів пунктуації в рядку: " +
$"{ListSymbols.Count}");
