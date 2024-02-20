
int[] numbers = { 150, 120, 1300, 1240, 15000, 12000, 140000 };
int sum3reqemli = 0;
int sum4reqemli = 0;
int sum5reqemli = 0;
int sum6reqemli = 0;

int vur3reqem = 1;
int vur4reqem = 1;
double result = 0;
foreach (var i in numbers)
{
    if (i >= 100 && i < 1000)
    {
        sum3reqemli += i;

    }
    else if (i >= 1000 && i < 10000)
    {
        sum4reqemli *= i;
    }
}
foreach (int i in numbers)
{
    if (i >= 100 && i < 1000)
    {
        sum3reqemli *= i;

    }
    else if (i >= 1000 && i < 10000)
    {
        sum4reqemli += i;
    }
    else if (i >= 10000 && i < 100000)
    {
        sum5reqemli += i;
    }
    else
    {
        sum6reqemli += i;
    }
}
result = sum3reqemli + vur4reqem;
result *= 10;
result += 7;
result += sum5reqemli;
result = vur3reqem* 10;
result += 1;
result += sum6reqemli;
result -= (sum3reqemli + sum4reqemli);
result /= 100;
result *= 18;
result /= 100;
result *= 3;
result /= 100;
result *= 1;
result += sum5reqemli;

Console.WriteLine(result);


