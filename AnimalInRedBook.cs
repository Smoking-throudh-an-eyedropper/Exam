using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class AnimalInRedBook : Animal
    {
        private int _colvo;
        public int Colvo
        {
            get { return _colvo; }
            private set { _colvo = value; }
        }
        public AnimalInRedBook(string name, int timeLive, Famile famile, int colvo): base (name, timeLive, famile)
        {
            Colvo = colvo;
        }
    }
}
