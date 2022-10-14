Console.WriteLine("Пожалуйста, введите три числа и наша система найдет максимальное число. Учтите, значение любого числа не может превышать 78"); 
Console.WriteLine("Введите первое число"); 
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число"); 
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число"); 
int c = Convert.ToInt32(Console.ReadLine());

if (a>b && a>c && a<79) {
Console.WriteLine("Число "+a + " максимальное");
}
else if (b>a && b>c && b<79) {
    Console.WriteLine("Число "+b + " максимальное");
}
else if (c>a && c>b && c<79) {
    Console.WriteLine("Число "+c + " максимальное");
}
else {
    Console.WriteLine("Ошибка ввода. Число не должно превышать 78. Повторите попытку");
} 