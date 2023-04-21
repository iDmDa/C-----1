#nullable disable

int int_number;
Console.Write("Введите число: ");
string str_number = Console.ReadLine();
if(!Int32.TryParse(str_number, out int_number)) {
    Console.WriteLine("Введено не число");
    System.Environment.Exit(0);
};

string result = "";

for(int i = 2; i <= int_number; i += 2) {
    result += i + ", ";
}

result = result.Substring(0, result.Length-2);

Console.WriteLine(int_number + " -> " + result);