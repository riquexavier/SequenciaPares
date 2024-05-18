Console.Clear();

Console.Write("Números pares entre 0 e ? ");
int numero = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

for(int x = 0; x <= numero ; x+=2)
{
    Console.Write($"{x} ");

}