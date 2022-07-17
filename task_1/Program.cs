// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трех значное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = number / 10;
int ost = result % 10;

if(number <= 99 || number >= 1000) {
   Console.Write($"Вы вели не верное число {number}");
} else {
   Console.Write($"Вторая цифра нашего числа {number} равна {ost}");
}
