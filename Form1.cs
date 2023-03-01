using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr2
{
    public partial class Form1 : Form
    {
        public Knigi _knigi;
        public Form1()
        {
            InitializeComponent();

            _knigi = new Knigi();
            _knigi.Initialize();

            dataGridView1.DataSource = _knigi.Books.ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            List<Books> _Poisk = _knigi.Books.Where(x => x.surname.ToLower().Contains(textBox1.Text.ToLower())).ToList();
            dataGridView1.DataSource = _Poisk;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Books> _Minus = _knigi.Books.OrderByDescending(x => x.Pages).ToList();
            dataGridView1.DataSource = _Minus;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Books> _Plus = _knigi.Books.OrderBy(x => x.Pages).ToList();
            dataGridView1.DataSource = _Plus;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _knigi.Books.ToList();
            textBox1.Text = "";
        }
    }
}
