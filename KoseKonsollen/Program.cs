/* Lage en konsoll app!
      Brukeren skal kunne velge mellom følgende ting å gjøre: 
      - Tell me a joke, 
      - Play number guessing game
      - Say goodbye 

      Om vi rekker mer: 
      - Tenker å kjøre en liten debugging intro
*/
string[] jokes = new string[] {"Your life", 
                               "how does this aircraft work?\n which craft?\n Wow, I thought they used jet fuel",
                               "Cat with tie"};
Random randomizerTool = new Random();

Menu();
void Menu()
{
    while (true)
    {
        Console.WriteLine("Hey, Welcome to this awesome app!");
        Console.WriteLine("What do you want to do?");
        Console.WriteLine("1. Tell me a joke");
        Console.WriteLine("2. Play number guessing game");
        Console.WriteLine("3. Say goodbye");

        var userInput = Console.ReadLine();
        CheckUserInput(userInput);
    }    
}
void CheckUserInput(string input)
{
    if (input == "1")
    {
        Console.WriteLine(TellJoke());
    }
    else if (input == "2")
    {
        PlayNumberGame();
    }
    else
    {
        SayGoodBye();
    }
}

string TellJoke()
{
   var randNum = randomizerTool.Next(0, jokes.Length);
   return jokes[randNum];
}
void PlayNumberGame()
{
    var randomNumber = randomizerTool.Next(1, 3000);
    int guessedNumber = 0;
    Console.WriteLine("A random number is now selected! \n GUESS AWAY!!!");
    
    while (guessedNumber != randomNumber)
    {
        guessedNumber = int.Parse(Console.ReadLine());
        if (guessedNumber < randomNumber)
        {
            Console.WriteLine("Too low biach!");
        }
        else if (guessedNumber > randomNumber)
        {
            Console.WriteLine("Too HIGH biach!");
        }
        else
        {
            Console.WriteLine("NAILED IT!");
        }
    }    
}
void SayGoodBye()
{
    Console.WriteLine("GOODBYE");
    System.Environment.Exit(0);
}