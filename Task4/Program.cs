Console.WriteLine("Введи первое число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введи второе число: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введи третье число: ");
int c = int.Parse(Console.ReadLine());

if (a >= b) {
    if (a >= c) { 
        Console.WriteLine("max = " + a);
    } else {
        Console.WriteLine("max = " + c);
    }   
} else {
    if (b >= c) {
        Console.WriteLine("max = " + b);
        
    } else {
        Console.WriteLine("max = " + c);
    }
}



