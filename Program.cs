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