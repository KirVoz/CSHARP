Console.WriteLine("Insert name: ");
string username = Console.ReadLine();

if(username.ToLower() == "masha")
{
    Console.WriteLine("ooops");
}
else
{
    Console.Write("Hi, ");
    Console.WriteLine(username);
}