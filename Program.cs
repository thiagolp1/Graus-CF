double tempf, tempc;
Console.Write("Digite a temperatura em graus Celsius: ");
tempc = Convert.ToDouble(Console.ReadLine());

tempf = tempc * 1.8 + 32;

Console.WriteLine($"{tempc}°C equivalem a {tempf}°F");
