using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileIO_UnitTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO_UnitTest.Tests {
    [TestClass()]
    public class BookTests {

        // Made by Trystin St.Louis
        //  |
        //  V
        [TestMethod()]
        public void BookTitle_LongEntry() {
            try {
                Book boo = new Book("123456789012345678901234567890", 
                    "Person", "1234567890", 9.99);
                Assert.Fail();
            }
            catch (ArgumentException ae) {}
        }

        [TestMethod()]
        public void BookTitle_NullEntry() {
            try {
                Book boo = new Book("",
                    "Person", "1234567890", 9.99);
                Assert.Fail();
            }
            catch (ArgumentException ae){}
        }

        [TestMethod()]
        public void BookTitle_ShortEntry() {
            try {
                Book boo = new Book("B",
                    "JohnDoe", "0987654321", 9.99);
                Assert.Fail();
            }
            catch (ArgumentException ae) {}
        }

        [TestMethod()]
        public void BookAuthor_LongEntry() {
            try {
                Book boo = new Book("CoolBook",
                    "123456789012345678901234567890", 
                    "0123456789", 9.99);
                Assert.Fail();
            }
            catch (ArgumentException ae) {}
        }

        [TestMethod()]
        public void BookAuthor_NullEntry() {
            try {
                Book boo = new Book("CoolBook",
                    "", "0123456789", 9.99);
                Assert.Fail();
            }
            catch (ArgumentException ae) {}
        }

        [TestMethod()]
        public void BookAuthor_ShortEntry() {
            try {
                Book boo = new Book("CoolBook",
                    "A", "0123456789", 9.99);
                Assert.Fail();
            }
            catch (ArgumentException ae) {}
        }
        //  A
        //  |

        // Not made by Trystin St.Louis
    }
}