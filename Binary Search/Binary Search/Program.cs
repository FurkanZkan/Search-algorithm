int[] elements = new int[] { 4, 8, 5, 7, 2, 6, 10 };
Console.WriteLine(binarySearch(elements, 10));


int binarySearch(int[] elements, int x)
{
    int start = 0; 
    int stop = elements.Length - 1;
    int middle = (int)((start + stop) / 2);

    while (elements[middle] != x  && start < stop )
    {
        if (x < elements[middle])
            stop = middle - 1;
        else
            start = middle +1;


        middle = (int)((start + stop) / 2); 
    }
    return (elements[middle] != x) ? -1 : middle;
}



  
