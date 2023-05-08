Console.WriteLine("Are You coming or leaving? (in or out):*");
string UserChoice = Console.ReadLine();

if (UserChoice == "in")
{
    PrintHello();
}
else
{
    PrintGoodBye();
}
static void PrintHello()
{
    Console.WriteLine("Hello,world!");
}

static void PrintGoodBye()
{
    Console.WriteLine("See you later,aligator.");
}
