Console.WriteLine("Eded daxil edin");
string input = Console.ReadLine();
int num1;
Int32.TryParse(input, out num1);

int num2 = 2;
int counter = 0;

if (num1 == 1)
{
    Console.WriteLine("1 ne murekkeb ne de sadedir.");
};

for (int i = num2; num2 <num1 && counter < 1; num2++)

if (num1 % num2 > 0)
{
        continue;
}

else
{
        counter++;
};

if (counter == 1)
{
    Console.WriteLine("Murekkeb Eded");
}
else
{
    Console.WriteLine("Sade Eded");

}