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

#region
int num1 = Convert.ToInt32(Console.Readline());
int num2 = Convert.ToInt32(Console.Readline());

if (num1 % 2 == 0 && num2 % 2 == 0)
{
    Console.Writeline(num1 + num2);
}
else
{
    Console.Writeline("daxil olunan ededler cut olmalidir")
}
#endregion

