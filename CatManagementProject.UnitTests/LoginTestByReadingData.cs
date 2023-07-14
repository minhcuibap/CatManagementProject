using NUnit.Framework;
using Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CatManagementProject.UnitTests
{
    [TestFixture]
    public class LoginTestByReadingData
    {
        [SetUp]
        public void Setup()
        {
            var login = new Login();
            var accountHelper = new AccountHelper();
        }

        private static IEnumerable<String[]> GetTestData(string path)
        {
            using (var reader = new StreamReader(path))
            {
                reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(",");
                    yield return values;
                }
            }
        }

        [Test]
        [TestCaseSource(nameof(GetTestData), new object[] {"test_data.txt"})]
        public void checkLogin_GivenRightInput_ReturnsWell(String username, String password, String expectedResult)
        {
            bool expectedValue = bool.Parse(expectedResult);

            var login = new Login();
            var accountHelper = new AccountHelper();

            var valid = login.checkLogin(accountHelper.GetAll(), username, password);
            bool actualValue = valid != null ? true : false;

            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
