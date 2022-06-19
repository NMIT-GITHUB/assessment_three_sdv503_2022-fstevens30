int[][] arr = new int[3][]; //Declaring a jagged array with 3 indexes
arr[0] = new int[] { 4, 2, 7, 1 }; //Initializing the elements within each sub-array
arr[1] = new int[] { 20, 70, 40, 90 };
arr[2] = new int[] { 1, 2, 0 };

int num1 = arr[0].Max(); //Using .Max() to get the max value of each sub-array and save it as an integer
int num2 = arr[1].Max();
int num3 = arr[2].Max();

int[] finalArr = new int[] { num1, num2, num3 }; //Declaring a single-dimensional array

Console.WriteLine(String.Join(",", finalArr.Cast<int>()));
//Using String.Join to print the finalArr with "," between each integer
//Also using .Cast to convert the elements of finalArr to integer