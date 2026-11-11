Console.WriteLine("Digite um numero inteiro");
int num = int.Parse(Console.ReadLine());

Console.WriteLine("Numeros Impares: ");
for (int i = 1; i <= num; i++)
{
    if(i % 2 != 0 )
    {
        Console.WriteLine(i);
    }
}

Console.WriteLine("\nNumeros pares: ");
for (int i = num; i > 0; i--)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}