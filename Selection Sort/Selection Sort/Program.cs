int[] arr = { 2, 3, 1, 8, -6, -9 };
int temp = 0;


for (int i = 0; i < arr.Length; i++)
{
    for (int j = i; j < arr.Length; j++)
    {
        if (arr[i] > arr[j])
        {
            temp = arr[j];
            arr[j] = arr[i];
            arr[i] = temp;
        }
    }
}

foreach (int i in arr)
{
    Console.Write("{0}  ",i);
}