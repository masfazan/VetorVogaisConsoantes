char[] letras = new char[10];
char[] vogais = new char[10];
char[] consoantes = new char[10];
int QVogais = 0, QConsoantes = 0;

for (int i = 0; i < 10; i++)
{
    Console.Write($"Digite a letra({i}): ");
    letras[i] = char.Parse(Console.ReadLine());
}

for (int i = 0; i < 10; i++)
{

    if (letras[i] == 'a' || letras[i] == 'e' || letras[i] == 'i' || letras[i] == 'o' || letras[i] == 'u')
    {
        vogais[QVogais++] = letras[i];
    }
    else
    {
        consoantes[QConsoantes++] = letras[i];
    }
}

if (QVogais > 0)
{
    Console.WriteLine("Vogais:");

    for (int i = 0; i < QVogais; i++)
    {
        Console.Write($"{vogais[i]} ");
    }
}

if (QConsoantes > 0)
{
    Console.WriteLine("Consoantes:");

    for (int i = 0; i < QConsoantes; i++)
    {
        Console.Write($"{consoantes[i]} ");
    }
}

Console.Write("\nDigite qualquer tecla para sair: ");
