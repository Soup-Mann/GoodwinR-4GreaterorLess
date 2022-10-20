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

    // Console.WriteLine("GREATER THAN OR LESS THAN");
    // Console.WriteLine("");

    // Console.WriteLine("Please Enter a number!");

    // string thisnumber = Console.ReadLine();
    // Console.WriteLine("");
    // Console.WriteLine("Please Enter a second number!");

    //The string is defined here as "Thatnumber"
    //string thatnumber = Console.ReadLine();

    //The string is then plugged in here to convert it to a int 
    //which means you must rename it (string plugged in on right)
    //and new int comes out on left
    // int thisnumbertwo = Convert.ToInt32(thisnumber);
    // int thatnumbertwo = Convert.ToInt32(thatnumber);

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