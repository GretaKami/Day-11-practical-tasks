//PART 1
for (int i=1; i<9; i+=2)
{ 
Console.WriteLine(i);
}

Console.WriteLine("\n");

//PART 2
string[] myArray = new string[5];

myArray[0] = "one";
myArray[1] = "two";
myArray[2] = "three";
myArray[3] = "four";
myArray[4] = "five";

for (int i = 0; i < myArray.Length; i++)
{
    Console.WriteLine(myArray[i]);
}

//PART 3
Console.WriteLine("\n");

string [,] array2 = { { "one", "two", "three"}, { "four", "five", "six" }, { "seven", "eight", "nine" } };

for (int row= 0; row < array2.GetLength(0); row++)
{
    for (int j=0; j < array2.GetLength(1); j++)
    {
        Console.Write($"{array2[row, j]} ");
    }
    Console.WriteLine();
}
