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

#region
int point = Convert.ToInt32(Console.Readline());

if (point>=91 && point <= 100)
{
    Console.Writeline("A");
}
else if (point>=81 && point<=90)
{
    Console.Writeline("B");
}
else if (point>=71 && point <= 80)
{
    Console.Writeline("C");
}
else if (point>=61 && point <= 70)
{
    Console.Writeline("D");
}
else if (point>=51 && point<= 60)
{
    Console.Writeline("E");
}
else
{
    Console.Writeline("kesilmisiniz");
}
#endregion

#region
int A = Convert.ToInt32(Console.Readline());
int B = Convert.ToInt32(Console.Readline());
int C = Convert.ToInt32(Console.Readline());
int sum = 0

if(A % 5 == 0)
{
    sum += A;
}
else if (B % 5 == 0)
{
    sum += B;
}
else
{
    sum += C;
}
#endregion

