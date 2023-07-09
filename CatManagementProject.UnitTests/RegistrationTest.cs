using Services.Models;
using Services.Services;

namespace CatManagementProject.UnitTests
{
    [TestFixture]
    public class RegistrationTests
    {
        string usernameFormat = @"^[a-zA-Z0-9@]+$";
        string passwordFormat = @"^(?=.*[A-Z])(?=.*\d)(?=.*[^\w\s]).+$";

        private static object[] TestUsernameData = new object[]
        {
            new object[] { "khanh" , true },
            new object[] { "minhcuibap" , true },
            new object[] { "tan" , true },
            new object[] { "tiendaden" , true },
            new object[] { "haodaden" , true },
            new object[] { "cai nay co dau cach" , false },

        };

        private static object[] TestPasswordData = new object[]
        {
            new object[] { "khanh" , false },
            new object[] { "minhcuibap" , false },
            new object[] { "tan" , false },
            new object[] { "tiendaden" , false },
            new object[] { "haodaden" , false },
            new object[] { "cai nay co dau cach" , false },
            new object[] { "KhanhBui1!" , true },
            new object[] { "Khanh#Bui1" , true },

        };
        [SetUp]
        public void Setup()
        {
        }

        
        [Test]
        [TestCaseSource(nameof(TestUsernameData))]
        public void isValidUsername_GivenRightUsername_ReturnsTrue(String username, bool expected)
        {
            bool actual = Utils.isValidUsername(username, usernameFormat);

            Assert.AreEqual(expected, actual);

            Assert.Pass();
        }

        [Test]
        [TestCaseSource(nameof(TestPasswordData))]
        public void isValidPassword_GivenRightPassword_ReturnsTrue(String password, bool expected)
        {
            bool actual = Utils.isValidPassword(password, passwordFormat);

            Assert.AreEqual(expected, actual);

            Assert.Pass();
        }
    }
}