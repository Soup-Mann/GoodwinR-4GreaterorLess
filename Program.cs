//Reed Goodwin
//10-19-2022
//Mini CHallenge #4
//THis is a console that will tell you which number is
//Greater, less than, or equal too
// Its also very polite :) 

Console.Clear();

string stop = "";
while(stop != "no"){
Console.WriteLine("");

Console.WriteLine("GREATER THAN OR LESS THAN");
Console.WriteLine("");

Console.WriteLine("Please Enter a number!");

string thisnumber = Console.ReadLine();
Console.WriteLine("");
Console.WriteLine("Please Enter a second number!");

string thatnumber = Console.ReadLine();

int thisnumbertwo = Convert.ToInt32(thisnumber);
int thatnumbertwo = Convert.ToInt32(thatnumber);


if( thisnumbertwo > thatnumbertwo ){
    Console.WriteLine("");
    Console.WriteLine(thisnumber + " Is greater than " + thatnumber + "!" );
} else if( thisnumber == thatnumber ){
    Console.WriteLine("");
Console.WriteLine( thisnumber + " Is equal too " + thatnumber + "!" );
}else{
    Console.WriteLine("");
    Console.WriteLine(thisnumber + " Is less than " + thatnumber + "!" );
}
Console.WriteLine("");
Console.WriteLine("Wow! Your so cool! Keep it up!");
Console.WriteLine("");
Console.WriteLine("Thank you for using my program :)");
Console.WriteLine("");
Console.WriteLine("Would you like to play again?");
stop = Console.ReadLine();
}