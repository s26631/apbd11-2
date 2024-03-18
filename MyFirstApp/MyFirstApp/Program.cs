// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Commit1");
Console.WriteLine("Commit2");
Console.WriteLine("Commit3");

static double Adavg(int[] numbers) {
    double sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        sum += numbers[i];
    }

    return sum / numbers.Length;
}
int[] arr = {1,2,3,4,};
double average = Adavg(arr);
Console.WriteLine(average);

static int biggest(int[]numbers)
{
    int biggestint = numbers[0];
    for(int i = 0 ; i < numbers.Length ; i++)
    {
        if (biggestint < numbers[i])
            biggestint = numbers[i];
    }


    return biggestint;
}
int[] numbers = { 1, 2, 3, 4, 5, 6 };
int biggestint = biggest(numbers);
Console.WriteLine(biggestint);