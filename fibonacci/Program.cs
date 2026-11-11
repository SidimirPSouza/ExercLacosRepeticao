Console.WriteLine("Digite a posição desejada: ");
int num = int.Parse(Console.ReadLine());
int cont = 0;
int fibonacci = 1;
int termo = 0;
while(cont < num)
{
    Console.WriteLine($"A posição {cont} da sequencia de fibonacci é: {fibonacci}");
    int antigoTermo = termo;
    termo = fibonacci;
    fibonacci += antigoTermo;
    cont++;
}

