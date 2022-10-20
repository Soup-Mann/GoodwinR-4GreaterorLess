//Reed Goodwin
//10-19-2022
//Mini CHallenge #4
//THis is a console that will tell you which number is
//Greater, less than, or equal too
// Its also very polite :) 
Console.Clear();
bool farmman = false;
bool farmboy = false;
int validNum = 0;
int validNum2 = 0;

string stop = "";
while (stop != "no")
{


    Console.WriteLine("");

    while (farmman == false)
    {
        Console.WriteLine("Please Enter a number!");

        farmman = Int32.TryParse(Console.ReadLine(), out validNum);

        if (farmman == true)
        {
            Console.WriteLine("You entered " + validNum);
            Console.WriteLine("");
        }
        else
        {
            Console.WriteLine("Yo this shit wrong");
        }
    }
    while (farmboy == false)
    {
        Console.WriteLine("Please Enter a second number!");
        farmboy = Int32.TryParse(Console.ReadLine(), out validNum2);
        if (farmboy == true)
        {
            Console.WriteLine("You entered " + validNum2);
            Console.WriteLine("");
        }
        else
        {
            Console.WriteLine("Get it right bub");
        }
    }


    if (validNum > validNum2)
    {
        Console.WriteLine("");
        Console.WriteLine(validNum + " Is greater than " + validNum2 + "!");
    }
    else if (validNum == validNum2)
    {
        Console.WriteLine("");
        Console.WriteLine(validNum + " Is equal too " + validNum2 + "!");
    }
    else
    {
        Console.WriteLine("");
        Console.WriteLine(validNum + " Is less than " + validNum2 + "!");
    }
    Console.WriteLine("");
    Console.WriteLine("---------------------");
    Console.WriteLine("Wow! Your so cool! Keep it up!");
    Console.WriteLine("Thank you for using my program :)");
    Console.WriteLine("Would you like to play again?");
    Console.WriteLine("Enter anything to restart, type \"no\" to exit");
    stop = Console.ReadLine();
    farmman = false;
    farmboy = false;
}