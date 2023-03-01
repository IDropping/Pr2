using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr2
{
    class Books
    {
        private int _pages;
        private NazvanieBook _nazvanie;
        private Author _author;
        private int _god;

        public int Pages
        {
            get => _pages;
        }
        private Author Author
        {
            get => _author;
        }
        public string surname
        {
            get { return Author != null ? Author.Surname : "Ne naznacheno"; }
        }
        private NazvanieBook NazvanieBook
        {
            get => _nazvanie;
        }
        public string nazvanie
        {
            get { return NazvanieBook != null ? NazvanieBook.Nazvanie : "Ne naznacheno"; }
        }
        public int God
        {
            get => _god;
        }
        public Books(int Pages, NazvanieBook Nazvanie, int God, Author Author)
        {
            _pages = Pages;
            _nazvanie = Nazvanie;
            _author = Author;
            _god = God;
        }
    }
}
