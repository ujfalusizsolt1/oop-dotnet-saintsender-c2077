using NUnit.Framework;
using SaintSender.Entities;
using System;
using System.Collections;
using System.Collections.Generic;

namespace SaintSender.Core.Tests
{
    [TestFixture]
    internal class MailTests
    {
        private Mail testEmail;

        [SetUp]
        public void Setup()
        {
            List<string> reciever = new List<string>() { "testsender@codecool.com" };
            string sender = "testreciever@codecool.com";
            DateTime date = new DateTime(2011, 10, 15);
            string subject = "Testing";
            bool isRead = false;
            string content = "This is the content of this test email";

            testEmail = new Mail(sender, reciever, date, subject, isRead, content);
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

            List<string> reciever = new List<string>() { "Code@cool.com" };
            string sender = "test@cool.com";
            DateTime date = new DateTime(2001, 10, 1);
            string subject = "Testing";
            bool isRead = false;
            string content = "This is the content of this test email";

            ///Act
            ArrayList expectedArray = new ArrayList();

            expectedArray.Add(sender);
            expectedArray.Add(reciever);
            expectedArray.Add(date);
            expectedArray.Add(subject);
            expectedArray.Add(isRead);
            expectedArray.Add(content);

            Mail testMail = new Mail(sender, reciever, date, subject, isRead, content);
            ArrayList actualArray = new ArrayList();

            actualArray.Add(testMail.Sender);
            actualArray.Add(testMail.Recievers);
            actualArray.Add(testMail.Date);
            actualArray.Add(testMail.Subject);
            actualArray.Add(testMail.IsRead);
            actualArray.Add(testMail.Content);

            ///Assert
            Assert.AreEqual(expectedArray, actualArray);
        }
    }
}