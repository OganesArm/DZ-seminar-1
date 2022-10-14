//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, 
//а какое меньшее.

Console.WriteLine("Введите первое число до 7"); 
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число до 7"); 
int b = Convert.ToInt32(Console.ReadLine());
if (a>b && a<8 && b<8) {
Console.WriteLine("Число "+a + " больше");
} 
else if (a<b && b<8 && a<8) { 
Console.WriteLine("Число "+b + " больше");
} 
else if (a==b && b <8 && a <8) {
Console.WriteLine("Числа равны"); 
} 
else {
    Console.WriteLine("Ошибка ввода. Повторите попытку");
} 