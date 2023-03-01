using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr2
{
    internal class NazvanieBook
    {
        private string _nazvanie;

        public string Nazvanie
        {
            get => _nazvanie;
            private set => _nazvanie = value;
        }
        public NazvanieBook(string Nazvanie)
        {
            _nazvanie = Nazvanie;
        }
    }
}
