Console.WriteLine("---Imitando Dory---");

Console.WriteLine("frase Baleies...");
string frase = Console.ReadLine()!;

string fraseEmBaleies = frase
    .Replace("a", "aaa")
    .Replace("A", "AAA")
    .Replace("e", "eee")
    .Replace("E", "EEE")
    .Replace("i", "iii")
    .Replace("I", "III")
    .Replace("o", "ooo")
    .Replace("O", "OOO")
    .Replace("u", "uuu")
    .Replace("U", "UUU")

    ;

 Console.WriteLine($"\nEm Baleiês:\n\n{fraseEmBaleies}");
