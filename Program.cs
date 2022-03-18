String frasedigitada, frasecomL;

Console.Write("digite uma frase: ");
frasedigitada = Console.ReadLine()!;

frasecomL = frasedigitada
.Replace("r","l")
.Replace("R", "L");

Console.WriteLine(frasecomL);

