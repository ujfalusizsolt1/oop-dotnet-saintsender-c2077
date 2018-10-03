using NUnit.Framework;
using SaintSender.Entities;
using System;
using System.Collections;

namespace SaintSender.Core.Tests
{
    [TestFixture]
    internal class MailTests
    {
        private Mail testEmail;

        [SetUp]
        public void Setup()
        {
            int id = 0;
            string sender = "testsender@codecool.com";
            string reciever = "testreciever@codecool.com";
            DateTime date = new DateTime(2011, 10, 15);
            string subject = "Testing";
            bool isRead = false;
            string content = "This is the content of this test email";

            testEmail = new Mail(id, sender, reciever, date, subject, isRead, content);
        }

        [TearDown]
        public void Teardown()
        {
            testEmail = null;
        }

        [Test]
        public void TestMailCtor_PassedAllArguments_SetContentProperly()
        {
            ///Arrange
            int id = 0;
            string sender = "Code@cool.com";
            string reciever = "test@cool.com";
            DateTime date = new DateTime(2001, 10, 1);
            string subject = "Testing";
            bool isRead = false;
            string content = "This is the content of this test email";

            ///Act
            ArrayList expectedArray = new ArrayList();
            expectedArray.Add(id);
            expectedArray.Add(sender);
            expectedArray.Add(reciever);
            expectedArray.Add(date);
            expectedArray.Add(subject);
            expectedArray.Add(isRead);
            expectedArray.Add(content);

            Mail testMail = new Mail(id, sender, reciever, date, subject, isRead, content);
            ArrayList actualArray = new ArrayList();
            actualArray.Add(testMail.Id);
            actualArray.Add(testMail.Sender);
            actualArray.Add(testMail.Reciever);
            actualArray.Add(testMail.Date);
            actualArray.Add(testMail.Subject);
            actualArray.Add(testMail.IsRead);
            actualArray.Add(testMail.Content);

            ///Assert
            Assert.AreEqual(expectedArray, actualArray);
        }
    }
}