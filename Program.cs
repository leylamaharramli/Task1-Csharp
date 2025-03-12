#region
string username = Console.Readline();
string password = Console.Readline();

if (username == "Admin" && password == "Admin123")
{
    Console.Writeline("xosh gelmisiniz");
}
else
{
    Console.Writeline("username ve ya password yanlisdir");
}
#endregion

#region
int num = Convert.ToInt32(Console.Readline());

if ( num % 2 == 0)
{
    Console.Writeline("eded cutdur");
}
else
{
    Console.Writeline("eded tekdir");
}
#endregion

