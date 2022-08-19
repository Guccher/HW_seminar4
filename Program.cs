// Console.Write("Input A: ");
// int A = int.Parse(Console.ReadLine());
// Console.Write("Input B: ");
// int B = int.Parse(Console.ReadLine());
// double res = Math.Pow(A,B);
// Console.WriteLine("A в степени B = " + res);


// Задача №27

// Console.Write("Input number: ");
// int number = int.Parse(Console.ReadLine() ?? "0");
// int sum = 0;
// while (number > 0)
// {
//     sum += number % 10;
//     number /= 10;
// }
// Console.WriteLine(sum);


// Задача №29

// int[] CreateRandomArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {

//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine("Input size: ");
// int size = int.Parse(Console.ReadLine() ?? "0");
// Console.WriteLine("Input min: ");
// int min = int.Parse(Console.ReadLine() ?? "0");
// Console.WriteLine("Input max: ");
// int max = int.Parse(Console.ReadLine() ?? "0");
// int[] array = CreateRandomArray(size, min, max);
// ShowArray(array);
// Console.WriteLine($"[{String.Join(", ", array)}]");

