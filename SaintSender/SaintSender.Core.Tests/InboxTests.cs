using NUnit.Framework;
using SaintSender.Entities;

namespace SaintSender.Core.Tests
{
    [TestFixture]
    public class InboxTests
    {
        [Test]
        public void Inbox_GetMails_ReturnMails()
        {
            // Arrange
            var service = new Inbox();
            List expected = new List();
            // Act
            var mails = service.GetMails();
            // Assert
            Assert.IsNotInstanceOf(expected.GetType(), mails.GetType());
            //Assert.AreEqual(expected, mails);
            //var expected = System.Collections.Generic.List`1[SaintSender.Entities.Mail];
        }
    }
}
