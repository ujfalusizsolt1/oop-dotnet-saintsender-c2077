using NUnit.Framework;
using SaintSender.DesktopUI.Converters;
using System.Collections.Generic;

namespace SaintSender.Core.Tests
{
    [TestFixture]
    internal class EmailAddressListConverterTests
    {
        private EmailAddressListConverter converter;
        private List<string> ListOfAddresses;
        private string StringOfAddresses;

        [SetUp]
        public void Setupdfsdfsdf()
        {
            converter = new EmailAddressListConverter();
            ListOfAddresses = new List<string>(new string[] { "test1@codecool.com", "test2@codecool.com", "test3@codecool.com" });
            StringOfAddresses = "test1@codecool.com, test2@codecool.com, test3@codecool.com";
        }

        [TearDown]
        public void Teardown()
        {
            converter = null;
            ListOfAddresses = null;
            StringOfAddresses = null;
        }

        [Test]
        public void TestConverter_ConvertFromList_ReturnconcatenatedString()
        {
            ///Arrange

            ///Act
            string actualConcat = (string)converter.Convert(ListOfAddresses, typeof(string), null, null);

            ///Assert
            Assert.AreEqual(StringOfAddresses, actualConcat);
        }

        [Test]
        public void TestConverter_ConvertFromString_ReturnListOfAddresses()
        {
            ///Arragne

            ///Act
            List<string> actualAddresses = (List<string>)converter.ConvertBack(StringOfAddresses, typeof(List<string>), null, null);

            ///Assert
            Assert.AreEqual(ListOfAddresses, actualAddresses);

        }
    }
}