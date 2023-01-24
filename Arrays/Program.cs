Console.WriteLine("Enter N: ");
int n = int.Parse(Console.ReadLine());
double[] array = new Double[n];
double sumNegativ = 0, max = 0, maxIndex = 0, positivIndex = 0;

Console.WriteLine("Enter the array values: ");
for (int i = 0; i < n; i++)
{
    array[i] = int.Parse(Console.ReadLine());
    if (array[i] < 0)
    {
        sumNegativ += array[i];
    }
    
    
}

max = array[0];
double maxAbs = array[0];
for (int i = 0; i < n; i++)
{
    if (array[i] >= max)
    {
        max = array[i];
        maxIndex = i;
    }

    if (Math.Abs(array[i]) >= Math.Abs(maxAbs))
    {
        maxAbs = array[i];
    }

    if (array[i] > 0)
    {
        positivIndex += i;
    }
}


Console.WriteLine($"sum Negativ = {sumNegativ}");
Console.WriteLine($"max = {max}");
Console.WriteLine($"max index = {maxIndex}");
Console.WriteLine($"max Abs = {Math.Abs(maxAbs)}");
Console.WriteLine($"positiv index = {positivIndex}");
