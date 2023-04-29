using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam
{
    public partial class Form1 : Form
    {
        private ListAnimal animal;
        public Form1()
        {
            InitializeComponent();

            animal = new ListAnimal();
            animal.Initialize();

            dataGridView1.DataSource = animal.AnimalsInRedBook.ToList();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = animal.AnimalsInRedBook.Where(u => u.Name.Contains(textBox1.Text)).ToList();
        }
    }
}
