Console.WriteLine("Digite o numero desejado");
int num = int.Parse(Console.ReadLine());
int antigo = num;
int result;
int cont = num;

while(cont > 0)
{
    result = antigo * cont;
    Console.WriteLine($"{antigo} X {cont} = {result}");
    antigo = result;
    cont--;
}