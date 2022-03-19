int n1, n2, resultado;

Console.WriteLine("cálculo da soma entre dois números.\n");

Console.Write("digite o primeiro número: ");
n1 = Convert.ToInt32(Console.ReadLine()!);

Console.Write("digite o segundo número: ");
n2 = Convert.ToInt32(Console.ReadLine()!);

resultado = n1 + n2;

Console.WriteLine($"soma: {resultado}");
