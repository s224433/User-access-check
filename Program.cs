Console.Write("Enter username:");
string username = Console.ReadLine();
Console.Write("Enter password:");
string password = Console.ReadLine();
Console.Write("Enter user ID:");
uint userId = uint.Parse(Console.ReadLine());

var userIsAdmin = userId >65536;
var usernameValid = username.Length >= 3;
var passwordValid = (password.Contains("$") || password.Contains("|") || password.Contains("@")) &&
                    (userIsAdmin ? password.Length >= 20 : password.Length >= 16);

Console.WriteLine("User is admin" + userIsAdmin);             
Console.WriteLine("Username is valid" + usernameValid);
Console.WriteLine("Password is vaild" + passwordValid);

if (usernameValid && passwordValid)
{
    Console.WriteLine("Login successful");
}
else 
{
    Console.WriteLine("Login failed");
}    