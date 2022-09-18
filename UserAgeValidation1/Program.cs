// See https://aka.ms/new-console-template for more information

//rakendus küsib kasutajal sisestada tema vanuse
//kui kasutajal vanus on väiksem kui 13, siis konsoolis kuvatakse:
//"Your are not old enough to use this app"
//muul juhul
//konsoolis kuvatakse "Welcome to My App"

Console.WriteLine("Enter your age:");

string userAge = Console.ReadLine();

int userAgeNum = 0;

//booleab - true/false

bool isAgeNumber = Int32.TryParse(userAge, out userAgeNum);

Console.WriteLine($"Parse result {isAgeNumber}. User is {userAgeNum} years old.");

if (isAgeNumber == true)
{
    if (userAgeNum >= 13)
    {
        Console.WriteLine("Welcome to My App!");
    }
    else
    {
        Console.WriteLine("You are not old enough to use My App.");
    }
}
else
{
    Console.WriteLine("Could not read your age.");
}