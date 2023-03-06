int dec, count;
int[] bin = new int[8];
bool valida = true;

while (valida)
{
    Console.WriteLine("Digite um número inteiro de 0 a 255");
    if (!int.TryParse(Console.ReadLine(), out dec))
    {
        Console.WriteLine("Por favor digite um número válido!\n");
    }
    else
    {
        if (dec > 0 && dec < 255)
        {
            fazBinario(dec);
            imprimeBinario();
            valida = false;
        }
        else
        {
            Console.WriteLine("O número deve estar entre 0 a 255\n");
        }
    }
}

void imprimeBinario()
{
    Console.Write("O valor em binário do número " + dec + " é: ");
    for (count = bin.Length - 1; count >= 0; count--)
    {
        Console.Write(bin[count]);
    }
}

int[] fazBinario(int aux)
{
    for (count = 0; count < bin.Length; count++)
    {
        bin[count] = aux % 2;
        aux /= 2;
    }
    return bin;
}