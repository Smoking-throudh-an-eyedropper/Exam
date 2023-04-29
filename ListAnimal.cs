using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Exam
{
    internal class ListAnimal
    {
        internal List<AnimalInRedBook> AnimalsInRedBook
            {
                get;
                private set;
            }
        public void Initialize()
        {

            AnimalsInRedBook = new List<AnimalInRedBook>
            {
                new AnimalInRedBook("Animal 1", 12, Famile.beard, 200),
                new AnimalInRedBook("Animal 2", 22, Famile.cat, 200),
                new AnimalInRedBook("Animal 3", 40, Famile.cat, 200),
                new AnimalInRedBook("Animal 4", 12, Famile.dog, 200),
                new AnimalInRedBook("Animal 5", 12, Famile.fish, 200),
                new AnimalInRedBook("Animal 6", 23, Famile.beard, 200),
                new AnimalInRedBook("Animal 7", 8, Famile.beard, 200),
                new AnimalInRedBook("Animal 8", 11, Famile.beard, 200),
            };
        }
    }
}
