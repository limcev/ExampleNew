﻿//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3



Console.Write("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число ");
int b = Convert.ToInt32(Console.ReadLine());
if (a>b){
    Console.WriteLine("Максимальное число" );
    Console.WriteLine(a);
    Console.WriteLine("Минимальное число"  );
    Console.WriteLine(b);
}
else {Console.WriteLine("Максимальное число" );
      Console.WriteLine(b);
      Console.WriteLine("Минимальное число"  );
      Console.WriteLine(a);
}