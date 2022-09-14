// See https://aka.ms/new-console-template for more information

//rakendus küsib kasutajal sisestada tema vanude
//kui kasutaja vanus on v'iksem kui 13, siis konsolis kuvatakse:
//"You are too young to use Instagram"
//muul juhul
//konsoolis kuvatakse "Welcome to Instagram"

Console.WriteLine("Enter you age:");

int userAge = Int32.Parse(Console.ReadLine()); //"13" - heap, 13 - stack

if(userAge >= 13)
{
    Console.WriteLine("Welcome to Instagram!");
}
else //if (userAge < 13)
{
    Console.WriteLine("You are too young to use Instagram.");
}    

