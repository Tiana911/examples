// Напишите программу, которая на вход принимает 
// число и выдаёт его квадрат (число умноженное на само себя).
// Например:
// 4 -> 16 
// -3 -> 9 
// -7 -> 49

// Однострочный комментарий
/*
Это
многострочный комментарий
*/
// тип данных имя - значение;

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine()); // в переменной number хранится число 5
// int result = number * number;
// result = number * number; result = 5+5 => res = 25
// Console.WriteLine("Квадра числа " +  number + " равен: " + result); //"1"+"2" ="12" - конкатинация, процесс сложения строк



// 1. Напишите программу, которая на вход принимает два числа и 
// проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет

// camelCase 
// Console.Write("Введите первое число: ");
// int firstDigit = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int secondDigit = Convert.ToInt32(Console.ReadLine());
// "=" - прис-я; "==" - проверка на равенство
// firstDigit == secondDigit * secondDigit
// if (firstDigit == secondDigit * secondDigit) // Точка с запятой НИКОГДА перед "{"
// {
// Console.WriteLine("Число " + firstDigit + " является квадратом от числа " + secondDigit);
// }
// else // Все остальные случаи
// {
// Console.WriteLine("Число " + firstDigit + " НЕ ЯВЛЯЕТСЯ квадратом от числа " + secondDigit);
// }



// Напишите программу, которая на вход принимает одно число (N),
//  а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

// Console.Write("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine()); // Перевод строчки в целое число
// if (N < 0) // Число N - отрц.
// {
// N = N * -1; // N = -5, N = 5
// }
// int negativeN = N * -1; // -N 
// while (negativeN <= N)
// {
// Console.WriteLine(negativeN); // -n = -2, то печатаю -2
// negativeN++; // Инкремент: negativeN = negativeN + 1
// Декремент: negativeN-- (negativeN = negativeN - 1)
// }


// 9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8 
// 12-> 2 
// 85 -> 8

// int randomNumber = new Random().Next(10, 100); // Число от 10 до 99 включительно 
// int firstDigit = randomNumber / 10; // Первая цифра в числе: 78 / 10 = 7
// int secondDigit = randomNumber % 10; // Первая цифра в числе: 78 % 10 = 8
// int max = firstDigit; // Пусть (можем ошибаться) первая цифра в числе - максимальная 
// if (secondDigit > max) // Если вторая цифра числа больше максимума,
// {
    // max = secondDigit; // то максимум - вторая цифра
// }
// Console.WriteLine("Максимальная цифра в числе: " + randomNumber + " -  это " + max); // Конкатенация 
// Console.WriteLine($"Максимальная цифра в числе: {randomNumber} - это: {max}"); // Интерполяция 
// "Текст : {Переменная} текст {Переменная}"

// int randomNumber = new Random().Next(100, 1000); // 100-999 включительно
// int firstDigit = randomNumber / 100;
// int thirdDigit = randomNumber % 10;
// int result = firstDigit * 10  + thirdDigit;
// Console.WriteLine($"В числе {randomNumber} -> {result}");
// Console.WriteLine($"Первая цифра: {firstDigit}; третья: {thirdDigit}");


// 11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

// int randomNumber = new Random().Next(100, 1000); // 100-999 включительно
// int result = (randomNumber / 100) * 10  + randomNumber % 10;
// Console.WriteLine($"В числе {randomNumber} -> {result}");


// 12. Напишите программу, которая будет принимать на вход два числа и выводить,
//  является ли второе число кратным первому. Если число 2 не кратно числу 1, 
//  то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

// Console.Write("Получаем первое число: ");
// int firstDigit = Convert.ToInt32(Console.ReadLine());

// Console.Write("Получаем второе число: ");
// int secondDigit = Convert.ToInt32(Console.ReadLine());

// // Является ли число secondDigit квадратом от firstDigit
// if (firstDigit % secondDigit == 0)
// {
//     Console.WriteLine($"Число {firstDigit} делится нацело, без остатка на {secondDigit}");
// }
// else
// {
//     Console.WriteLine($"Остаток от деления числа {firstDigit} на {secondDigit} : {firstDigit % secondDigit}");
// }


// 14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да

// Console.Write("Получаем  число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number % 7 == 0 && number % 23 == 0)// Число делится на 7 БЕЗ остатка
// {
//     Console.WriteLine($"Число {number} делится без остатка на 7 и на 23");
// }
// else
// {
//     Console.WriteLine($"Число {number} делится на 7 с остатком: {number % 7}");;
//     Console.WriteLine($"Число {number} делится на 23 с остатком: {number % 23}");;
// }

// Console.Write("Получаем  число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number % 7 == 0 && number % 23 == 0)// Число делится на 7 БЕЗ остатка
// {
//     Console.WriteLine($"Число {number} делится без остатка на 7 и на 23");
// }
// else
// {
//     Console.WriteLine($"Число {number} НЕ делится без остатка на 7 и на 23");
// }