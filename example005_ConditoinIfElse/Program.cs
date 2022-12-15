Console.WriteLine("Введите свое имя");
string username = Console.ReadLine();
if(username.ToLower() == "маша")
{
    Console.WriteLine("Ура! Привет, МАША!");
}
else
{
    Console.WriteLine("Привет, "); 
    Console.WriteLine(username);
}
