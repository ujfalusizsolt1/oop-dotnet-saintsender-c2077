using NUnit.Framework;
using SaintSender.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaintSender.Services.Tests
{
    [TestFixture()]
    public class ConnectionHandlerTests
    {
        [Test()]
        public void SaveAuthTest()
        {
            var conn = new ConnectionHandler("c2077test@gmail.com", "SuperSecure1234");
        }
    }
}