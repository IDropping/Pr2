using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr2
{
    public class Knigi
    {
        private Random _random = new Random();
        private int RandomInt
        {
            get => _random.Next(1700, 2023);
        }
        private int RandomPage
        {
            get => _random.Next(5, 2000);
        }
        internal List<Books> Books { get; private set; }

        public void Initialize()
        {
            Books = new List<Books>
            {
                new Books(RandomPage, new NazvanieBook ("Regnorum"), RandomInt, new Author("Никита.А.А")),
                new Books(RandomPage, new NazvanieBook ("RWBY"), RandomInt, new Author("Ганнадий.А.А")),
                new Books(RandomPage, new NazvanieBook ("BlazBlue"), RandomInt, new Author("Мори.В.В")),
                new Books(RandomPage, new NazvanieBook ("Scissor Seven"), RandomInt, new Author("Рена.Ю.А"))
            }; 
        } 
    }
}
