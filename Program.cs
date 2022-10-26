//Valerie Aguilar
//October 22, 2022
//----------Adding Two Numbers -----------//

// --- Reviewed by Mauricio Zavala -- Great job!

bool playAgain = true;
bool validInput = true;
bool validTime = true;
bool repeatGame = true;
bool tryAgain = true;
string name;
int time;

Console.WriteLine("Welcome! I would like to get to know you!");

while (playAgain)

{
    Console.WriteLine("What is your name?");
    name = Console.ReadLine();


    for (int i = 0; i < name.Length; i++)
    {
        validInput = char.IsLetter(name[i]);

    }

    if (!validInput)
    {
        Console.WriteLine("Please type a valid name containing letters only");


    }
    else
    {
        
        Console.WriteLine("Awesome!");
        Console.WriteLine("What time did you wake up today? Please type in a digit.");
        repeatGame = false;
    }



    while (!repeatGame)
    {
        validTime = int.TryParse(Console.ReadLine(), out time);

        if (!validTime)
        {
            Console.WriteLine("Please type in a valid digit");
        }
        else
        {
         Console.WriteLine("Wow! I've learned that your name is " + name + " and you woke up today at " + time + ".");
        tryAgain = false;
        repeatGame = true;
        }

       

    }
    while(!tryAgain)
    {
        Console.WriteLine("Would you like to try again with a differnt name? if so type YES, or if not, type NO");
      
        if (Console.ReadLine().ToUpper() != "YES")
        {
            playAgain = false;
        }
        tryAgain = true;

    }









}



Console.WriteLine("It was great to meet you! See you later!");