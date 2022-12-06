Console.WriteLine("Введите число");
string N=Console.ReadLine();
int A= int.Parse(N);
int i=1;
while(i<= A)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i + " ,");
    
    }
    i++;
}