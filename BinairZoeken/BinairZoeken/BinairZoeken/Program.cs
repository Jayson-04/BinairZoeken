using System;
using System.Diagnostics;

bool BinarySearch(int[] array, int target, int low, int high)
{
    if (low > high)
        return false;

    int mid = (low + high) / 2;

    if (array[mid] == target)
        return true;
    else if (array[mid] > target)
        return BinarySearch(array, target, low, mid - 1);
    else
        return BinarySearch(array, target, mid + 1, high);
}

Random random = new Random();
int[] numbers = new int[10000];
for (int i = 0; i < numbers.Length; i++)
    numbers[i] = random.Next(1, 10001);

Array.Sort(numbers);

Console.Write("Welk getal zoek je (1 t/m 10000)? ");
int target = int.Parse(Console.ReadLine());

Stopwatch timer = Stopwatch.StartNew();
bool found = BinarySearch(numbers, target, 0, numbers.Length - 1);
timer.Stop();

Console.WriteLine($"Target {target} gevonden: {found}");
Console.WriteLine($"Tijd: {timer.Elapsed.TotalMilliseconds:F4} ms");