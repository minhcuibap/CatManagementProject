using Services.Models;
using Services.Services;
using System.Diagnostics.CodeAnalysis;

namespace CatManagementProject.UnitTests
{
    [TestFixture]
    public class UpdateServiceTests
    {
        private static object[] ValidTestData = new object[]
        {
            new object[] { 1 , true },
        };

        private static object[] InvalidTestData = new object[]
        {
            new object[] { 69 },
        };

        [SetUp]
        public void Setup()
        {
        }


        [Test]
        [TestCaseSource(nameof(ValidTestData))]
        public void FindService_WithValidId_ReturnsTrue(int id, Boolean expected)
        {
            Boolean actual = false;
            var update = new UpdateService();
            Service service = update.findService(id);
            if (service != null)
            {
                actual = true;
            }

            Assert.AreEqual(expected, actual);

            Assert.Pass();
        }

        [Test]
        [TestCaseSource(nameof(InvalidTestData))]
        public void FindService_WithInvalidId_ReturnsException(int id)
        {
            Boolean actual = false;
            var update = new UpdateService();
            var ex = Assert.Throws<ArgumentException>(() => update.findService(id));

            StringAssert.Contains("No ID Found", ex.Message.ToString());
        }
    }
}