Console.WriteLine("Введите первое число: ");
int namber1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int namber2 = int.Parse(Console.ReadLine());
if (namber1 < namber2) {
    Console.WriteLine("max = " + namber2);
    Console.WriteLine("mix = " + namber1);
} else if (namber1 > namber2) {
    Console.WriteLine("max = " + namber1);
    Console.WriteLine("mix = " + namber2);
} else {
    Console.WriteLine("Числа равны!");
}
