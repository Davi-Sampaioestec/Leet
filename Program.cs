Console.Clear();

Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("Escreva seu nome completo");
Console.ResetColor();

string imput = Console.ReadLine() ?? string.Empty;


string transformado = imput
    .Replace("a", "4")
    .Replace("e", "3")
    .Replace("i", "1")
    .Replace("o", "0")
    .Replace("s", "5");

Console.WriteLine($"Transformado: {transformado}");
        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();

