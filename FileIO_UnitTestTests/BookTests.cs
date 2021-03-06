﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileIO_UnitTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO_UnitTest.Tests {
    [TestClass()]
    public class BookTests {
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

        [TestMethod()]
        public void BookPrice_SmallEntry() {
            try {
                Book boo = new Book("CoolBook",
                    "Author", "0123456789", 0);
                Assert.Fail();
            }
            catch (ArgumentException ae) { }
        }

        [TestMethod()]
        public void BookPrice_LargeEntry() {
            try {
                Book boo = new Book("CoolBook",
                    "Author", "0123456789", 999999999);
                Assert.Fail();
            }
            catch (ArgumentException ae) { }
        }

        [TestMethod()]
        public void BookPrice_IncreasePrice() {
            Book boo = new Book(5.00);

            double addNum = 10.00;
            double Total = boo.Price + addNum;

            boo.IncreasePrice(addNum);

            Assert.IsTrue(Total == boo.Price);
        }

        [TestMethod()]
        public void BookPrice_IncreasePrice_2() {
            Book boo = new Book(25.00);

            double addNum = 0.25;
            double Total = boo.Price + addNum;

            boo.IncreasePrice(addNum);

            Assert.IsTrue(Total == boo.Price);
        }

        [TestMethod()]
        public void BookPrice_DecreasePrice_above0() {
            Book boo = new Book(10.00);

            double subNum = 5.00;
            double Total = boo.Price - subNum;

            boo.DecreasePrice(subNum);

            Assert.IsTrue(Total == boo.Price);
        }

        [TestMethod()]
        public void BookPrice_DecreasePrice_bellow0() {
            Book boo = new Book(10.00);

            double subNum = 20.00;
            double Total = 0;

            boo.DecreasePrice(subNum);

            Assert.IsTrue(Total == boo.Price);
        }
    }
}