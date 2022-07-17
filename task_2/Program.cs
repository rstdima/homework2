// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Write($"Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = number % 10;
int result1 = number / 10 % 10;
int result2 = number / 100 % 10;


if (number >= 0 && number <= 99) {
   Console.Write("Введите трехзначное число");
} else {
   if (number >= 100 && number <= 999){
      Console.Write($"Заданное число: {number} третья цифра от числа {result}");
   }
   if (number >= 1000 && number <= 9999) {
      Console.Write($"Заданное число: {number} третья цифра от числа {result1}");
   } 
   if (number >= 10000 && number <= 99999) {
      Console.Write($"Заданное число: {number} третья цифра от числа {result2}");
   } 
}