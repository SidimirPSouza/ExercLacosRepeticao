Console.WriteLine("Digite até que numero que você deseja verificar se é primo: ");
int num = int.Parse(Console.ReadLine());

for (int i = 2; i <= num;i++)
{
    bool primo = true;

    for(int j = 2; j < i; j++)
    {
        if(i % j == 0)
        {
            primo = false;
            break;
        }
    }
    if(primo)
    {
        Console.WriteLine(i);
    }
}
