int[][] arr = new int[3][];
arr[0] = new int[] { 4, 2, 7, 1 };
arr[1] = new int[] { 20, 70, 40, 90 };
arr[2] = new int[] { 1, 2, 0 };


for (int i = 0; i < arr.Length; i++)
{
    int largest = arr[i][0];
    for (int j = 1; j < arr[i].Length; j++)
    {
        if (arr[i][j] > largest)
        {
            largest = arr[i][j];
            Console.WriteLine(largest);
        }
    }
}

