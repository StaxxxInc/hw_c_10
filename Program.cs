Console.Write("Введите массив из трех элементов через пробел : "); 

int[] array = Console.ReadLine().Split(new char[] { ' ' }, 
StringSplitOptions.RemoveEmptyEntries).Select(e => Int32.Parse(e)).ToArray();

//присваиваем второй элемент
int result =array[1];

Console.Write("Второе число : "); 
Console.WriteLine(result);


