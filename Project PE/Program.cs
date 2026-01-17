public class Auth()
{

    public bool SignIn(string login, string password)
    {
        if (password == null || password.Length == 0)
        {
            throw new Exception();
        }
        return true;
    }
}
