#nullable disable

Console.Write("Введите первое число (a): ");
string a = Console.ReadLine();
if(!Int32.TryParse(a, out int a_int)) {
    Console.WriteLine("Введено не число");
    System.Environment.Exit(0);
};

Console.Write("Введите второе число (b): ");
string b = Console.ReadLine();
if(!Int32.TryParse(b, out int b_int)) {
    Console.WriteLine("Введено не число");
    System.Environment.Exit(0);
};

int max = a_int > b_int ? a_int : b_int;
string result = $"a = {a_int}, b = {b_int} -> max = {max}";
Console.WriteLine(result);