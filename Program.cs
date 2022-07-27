Console.Write("Введите массив из трех элементов через пробел : "); 

//Console.Write("Введите массив через пробел : "); 
 // ввод массива
int[] array = Console.ReadLine().Split(new char[] { ' ' }, 
StringSplitOptions.RemoveEmptyEntries).Select(e => Int32.Parse(e)).ToArray();

//вызываем функцию max
int result =array[1];

Console.Write("Второе число : "); 
Console.WriteLine(result);


