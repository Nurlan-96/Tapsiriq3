float num1 = 2049;
float num2 = 2;
int count = 0;

for (float i = num1; num2<=num1; num2*=2)
    if (num1 / num2 == 1)
    {
        count++;
    }
    else
    {
        count = 0;
    };

if (count == 0)
{
    Console.WriteLine("Eded ikinin quvveti deyil");
}
else
{
    Console.WriteLine("Eded ikinin quvvetidir");
}