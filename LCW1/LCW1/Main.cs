using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LCW1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        void addCharac()
        {

            using (LCWContext lcw = new LCWContext())
            {
                //Characteristic cg = new Characteristic { CHARA_NAME = textBox1.Text };

                //lcw.Characteristics.Add(cg);
                //lcw.SaveChanges();

            }
        }

        private void addComponent_Click(object sender, EventArgs e)
        {
            addCompon f = new addCompon();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void buildComputer_Click(object sender, EventArgs e)
        {
            buildCmp f = new buildCmp();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            addCharac();
        }
    }
}
