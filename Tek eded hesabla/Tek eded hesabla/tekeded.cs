int n = 26;
int m = 37;
int result = 0;

for (int a = n; a < m; a++)
{
    if (a % 2 > 0)
    {
        result++;
    }
}
Console.WriteLine(result);