int[][] exampleJavaScript = new int[3][];
exampleJavaScript[0] = new int[] { 4, 2, 7, 1 };
exampleJavaScript[1] = new int[] { 20, 70, 40, 90 };
exampleJavaScript[2] = new int[] { 1, 2, 0 };

for (int i = 0; i < exampleJavaScript.Length; i++)
{
    int largest = exampleJavaScript[i][0];
    for (int j = 0; j < exampleJavaScript[i].Length; j++)
    {
        if (exampleJavaScript[i][j] > largest)
        {
            largest = exampleJavaScript[i][j];
        }
    }
};
