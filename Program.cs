//Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
Console.WriteLine("Введите элементы массива ");
var elements = Console.ReadLine();
char[] separators = new char[] { ' ', ',', '.', ':', ';','|','/','?','!',};
string[] substring = elements.Split(separators, StringSplitOptions.RemoveEmptyEntries);


Console.Write("Массив из строк, длина которых меньше либо равна 3 символа: ");
int count = 1;
int i = 0;
string[] NeededArray;

foreach (string ElementsOfArray in substring)
{
if (ElementsOfArray.Length <=3)
{
NeededArray = new string[count];
NeededArray[i]=ElementsOfArray;
Console.Write(NeededArray[i] + " ");
count ++;
i++;
}
} 