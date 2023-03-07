int dec, count = 0;
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
        if (dec > -1 && dec < 256)
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
    if (aux != 0)
    {
        bin[count++] = aux % 2;
        aux /= 2;

        return fazBinario(aux);
    }
    else
    {
        return bin;
    }
}