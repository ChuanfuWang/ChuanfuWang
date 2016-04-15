using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeDataAndDoc
{
    class Class1
    {
        [TestFixture]
        public class Tests
        {
            [Test]
            public void Test()
            {
                StringReader input = new StringReader("haha");
                StringWriter output = new StringWriter();
                Program.comment(input, output);

                Assert.That(output.ToString(), Is.EqualTo("#haha\r\n"));

            }
        }
    }
}
