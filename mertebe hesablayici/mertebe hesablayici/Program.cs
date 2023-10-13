float num1 = 1475129;
float num2 = 10;
float counter = 1;

for (float i = num1; num2 <= 1000000; num2 *= 10)
{

    if (num1/num2 >= 1)
    {
        counter++;
    }
};
Console.WriteLine(counter);