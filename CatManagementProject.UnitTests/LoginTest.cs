using Services.Models;
using Services.Services;

namespace CatManagementProject.UnitTests
{
    [TestFixture]
    public class LoginTests
    {
        private static object[] TestData = new object[]
        {
        new object[] { "johndoe", "password123", false},
        new object[] { "janedoe", "wrongpassword", false},
        new object[] { "admin", "admin", false},
        new object[] { "", "", false},
        new object[] { "user", "", false},
        new object[] { "", "password", false},
        new object[] {"manager1", "345", true},
        new object[] {"customer1", "123", true},
        new object[] {"customer2", "123", true},
        new object[] {"customer3", "345", false},
        new object[] {"customer3", "", false},
        new object[] {"", "345", false},
        new object[] {"", "123", false}
        };

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCaseSource(nameof(TestData))]
        public void checkLogin_ValidUser_ReturnsWell(String username, String password, bool expected)
        {
            // Arrange - prepare testing object
            var login = new Login();
            var accountHelper = new AccountHelper();
            var check = login.checkLogin(accountHelper.GetAll(), username, password);


            // Act - actual work
            bool actual = check != null ? true : false;


            // Assert - verify result
            Assert.AreEqual(expected, actual);

            Assert.Pass();
        }


    }
}