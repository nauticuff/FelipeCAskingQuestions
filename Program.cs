/*
Carlos Felipe
10/19/22
Mini Challenge #3 - Asking Questions
This program asks the user for their name and the time they woke up. There is replayability and data validation.
*/
Console.Clear();
bool run = true;
while(run){
Console.WriteLine("What is your name?");
string name = Console.ReadLine();
if(name == ""){
name = "Blank";
}

Console.WriteLine("\nWhat time did you wake up");
string time = Console.ReadLine();
Console.WriteLine($"\nYour name is {name} and you woke up at {time}.");

Console.Write("\nRun program again?\nType YES or NO: ");
string runChoice = Console.ReadLine().ToUpper();
while(runChoice != "YES" && runChoice != "NO"){
    Console.WriteLine("\nI said 'YES or 'NO'\nTry again: ");
    runChoice = Console.ReadLine().ToUpper();
}
if(runChoice == "NO"){
    run = false;
    Console.WriteLine("Okay maybe next time!");
}
}