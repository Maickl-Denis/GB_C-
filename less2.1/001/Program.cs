//001

Console.Clear();
// int numberA = new Random().Next(10,100);
// Console.WriteLine(numberA);
// int num1 = numberA / 10;
// int num2 = numberA % 10;

// if (num1 > num2)
// {
//     Console.WriteLine($"{num1} больше чем {num2}");
// }
// else
// {
//     Console.WriteLine($"{num2} больше чем {num1}");
// }



//002 Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98


// int numberA = new Random().Next(100,1000);
// Console.WriteLine(numberA);
// int num1 = numberA / 100;
// int num2 = numberA % 10;

// Console.WriteLine($"{num1}{num2}");


//003 Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
//    Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

// int num1 = Convert.ToInt32(Console.ReadLine());
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1 % num2 == 0)
// {
//     Console.WriteLine($"кратно");
// }
// else
// {
//     Console.WriteLine($"не кратно, остаток {num1 % num2}");
// }

//004 Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да

// Console.Write("Введите число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// // int num1 = new Random().Next(1,1000);
// Console.WriteLine(num1);
// if ((num1 % 7 == 0) && (num1 % 23 == 0))
// {
//     Console.WriteLine("да");
// }
// else
// {
//     Console.WriteLine("нет");
// }


//005 16. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

// int num1 = Convert.ToInt32(Console.ReadLine());
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1 == Math.Pow(num2, 2) || num2 == Math.Pow(num1, 2))
// {
//     Console.WriteLine("да");
// }
// else
// {
//     Console.WriteLine("нет");
// }


//006 Генерируется случайное целое число n в интервале [ 20 – 99 ]. Проверяется, делится ли оно на введенное с клавиатуры целое число d
// (используйте тернарный оператор).

// int num = new Random().Next(20,100);
// Console.WriteLine(num);
// int num1 = Convert.ToInt32(Console.ReadLine());
// if (num % num1 == 0)
// {
//     Console.WriteLine($"Число {num} Делится на {num1}");
// }
// else
// {
//     Console.WriteLine("Не делится");
// }

//007 Генерируются два случайных целых числа a и b в интервале [10 – 30]. Если a > b, выводится их разность, eсли a < b, выводится сумма,
//    eсли a == b, выводится сообщение “числа равны”. (оператор if)

// int num1 = new Random().Next(10,31);
// int num2 = new Random().Next(10,31);

// if (num1 > num2)
// {
//     Console.WriteLine($"Разность чисел: {num1-num2}");
// }
// else if (num1 < num2)
// {
//     Console.WriteLine($"Сумма чисел: {num1+num2}");
// }
// else
// {
//     Console.WriteLine($"Числа равны");
// }