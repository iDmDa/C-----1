#nullable disable

int[] int_number = new int[3];

for(int i = 0; i < int_number.Length; i++) {
    Console.Write($"Введите число ({i+1}): ");
    string str_number = Console.ReadLine();
    if(!Int32.TryParse(str_number, out int_number[i])) {
        Console.WriteLine("Введено не число");
        System.Environment.Exit(0);
    };
}

int max = 0;
string result = "";
foreach(int value in int_number) {
    max = max < value ? value : max;
    result += value + ", ";
}
result = result.Substring(0, result.Length-2);

Console.WriteLine(result + " -> " + max);
