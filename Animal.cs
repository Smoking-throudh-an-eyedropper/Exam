using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public enum Famile
    {
        dog,
        cat,
        fish,
        beard
    }
    internal class Animal
    {
        private string _name;
        private int _timeLive;
        private Famile _famile = Famile.beard;
        public string Name
        {
            get { return _name; }
            private set { _name = value; }
        }
        public int TimeLive
        {
            get { return _timeLive; }
            private set { _timeLive = value; }
        }
        public Famile Famile
        {
            get { return _famile; }
            private set { _famile = value; }
        }
        public Animal (string name, int timeLive, Famile famile)
        {
            Name = name;
            TimeLive = timeLive;
            Famile = famile;
        }
    }
}
