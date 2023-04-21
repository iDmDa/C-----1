#nullable disable

int int_number;
Console.Write("Введите число (для проверки - является ли число чётным): ");
string str_number = Console.ReadLine();
if(!Int32.TryParse(str_number, out int_number)) {
    Console.WriteLine("Введено не число");
    System.Environment.Exit(0);
};

string result = int_number%2 == 0 ? "Да" : "Нет";

Console.WriteLine(int_number + " -> " + result);
