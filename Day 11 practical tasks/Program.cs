//PART 1
/*
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

*/
//Task 2
//PART 1
int sum = 0;
do
{
   Console.WriteLine("Please enter the number");
   string input = Console.ReadLine();
   int.TryParse(input, out int inputNumber); 
   sum += inputNumber;
   Console.WriteLine("sum = {0}", sum);
   if (sum>100)
   break;
 }
while (sum <= 100);

//PART 2
/*
int[] numberArray = { 1, 2, 3 };
bool notGuessedAll = true;
int guessedNumber = 0;
while (notGuessedAll)
{
    Console.Write("Please guess the number: ");
    int enteredNumber = Convert.ToInt32(Console.ReadLine());
    bool correctNumber = false;

    foreach(int i in numberArray)
    {
        if (i == enteredNumber)
        {
            Console.WriteLine("You have guessed correctly!");
            guessedNumber++;
            correctNumber = true;
            break;
        }
    }
    if (correctNumber == false) { Console.WriteLine("You are incorrect. Please try again"); }
    if (guessedNumber == numberArray.Length) 
    {
        Console.WriteLine("Congratulations! You have correctly guessed all numbers!");
        notGuessedAll = false; 
    }
}
*/