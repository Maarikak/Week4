

Random rnd = new Random();
int cpuRandom = rnd.Next(1, 4);

bool loopActive = true;

int numberoftries = 0;

while (numberoftries < 3)
{
    Console.WriteLine("Try to guess the cpu number:");
    int userGuess = Convert.ToInt32(Console.ReadLine());
    numberoftries++;

    if(userGuess == cpuRandom )
    { 
        Console.WriteLine("You won!");
        break;
    }


   
}

Console.WriteLine($"The number of tries: {numberoftries}");
Console.WriteLine("Have a nice day!");
