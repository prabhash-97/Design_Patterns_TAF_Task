using NUnit.Framework;

namespace Factory_example
{
    public class Tests
    {
        [SetUp]
        public void startBrowser()
        {
           
        }

        [Test]
        public void Test1()
        {
           var home =  Creator.Create("Customer");
            home.GoToPage();
            home.Signup();
            home.IsSignupSuccessful();
            home.IsTitleExists();
            home.Title();
        }

        [Test]
        public void Test2()
        {
            var home = Creator.Create("Admin");
            home.GoToPage();
            home.Signup();
            home.IsSignupSuccessful();
            home.IsTitleExists();
            home.Title();
        }

        [TearDown]
        public void closeBrowser()
        {
            
        }
    }
}