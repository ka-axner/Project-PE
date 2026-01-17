namespace Project_Test

    [TestClass]
    public sealed class AuthTest
    {
        [TestMethod]
        public void SignInTest()
        {
            var auth = new Auth();
            string login = "login";
            string password = "";

            var result = auth.SignIn(login, password);
            var expected = "Error";
            Assert.AreEqual(expected, result );
        }
    }
}
