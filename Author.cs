using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr2
{
    internal class Author
    {
        private string _Surname;

        public string Surname
        {
            get => _Surname;
            private set => _Surname = value;
        }
        public Author(string Surname)
        {
            _Surname = Surname;
        }
    }
}
