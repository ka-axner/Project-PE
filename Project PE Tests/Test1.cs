[TestClass]
public sealed class AuthTest
{
    [TestMethod]
    public void TestSignInEmpty()
    {
        var auth = new Auth();
        string login = "something";
        string password = "";

        string result = auth.SignIn(login, password);
        string expected = "Error";
        Assert.AreEqual(result, expected);
    }
}
