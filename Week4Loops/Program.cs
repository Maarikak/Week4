
Random random = new Random();

int myrandom;


for (int i = 0; i < 90; i++)
{
    myrandom = random.Next(1, 11);
    Console.WriteLine($"{i + 1}. {myrandom}");
}






//for(int i = 0; i < 4; i++) // i++==> i + 1
//{
//    Console.WriteLine($"{i + 1}. I will not skip Zoom Class.");
//}


