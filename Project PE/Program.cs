public static class MainClass
{
    public static void Main(String[] args)
    {
        return;
    }
}

public class Auth()
{

    public string SignIn(string login, string password)
    {
        if (login == "login" && password == "123456")
        {
            Console.WriteLine("Alarms deactivated. Welcome home, Marcus");
        }
        else
        {
            Console.WriteLine("Access Denied");
        }
    }
}
