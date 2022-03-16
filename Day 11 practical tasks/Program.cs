for (int i=1; i<9; i+=2)
{ 
Console.WriteLine(i);
}

Console.WriteLine("\n");

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

