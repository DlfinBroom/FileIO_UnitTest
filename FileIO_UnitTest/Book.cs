﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO_UnitTest {
    /// <summary>
    /// This class is only for unit testing
    /// </summary>
    public class Book {
        public string Title { get; private set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string Genre { get; set; }
        public double Price { get; set; }
        public string ISBN { get; private set; }

        public Book(string tit, string aut, 
                    string isbn, double pri) {
            if(tit.Length <= 2 || tit.Length < 25) {
                throw new ArgumentException();
            }
            if (aut.Length <= 2 || aut.Length < 25) {
                throw new ArgumentException();
            }
            if(isbn.Length != 10) {
                throw new ArgumentException();
            }
            if(pri <= 0.0 || pri > 1000000.0) {
                throw new ArgumentException();
            }
            Title = tit;
            Author = aut;
            Publisher = "John Doe";
            Price = 0.0;
            ISBN = isbn;
        }
        public Book(double pri) {
            Title = "Title";
            Author = "Author";
            Publisher = "John Doe";
            Price = pri;
            ISBN = "1234567890";
        }

        public void IncreasePrice(double amount) {
            Price += amount;
        }

        public void DecreasePrice(double amount) {
            if(Price - amount <= 0) {
                Price = 0;
            }
            else {
                Price -= amount;
            }
        }
    }
}
