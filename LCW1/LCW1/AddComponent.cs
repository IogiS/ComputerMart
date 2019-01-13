using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LCW1
{
    public partial class addCompon : Form
    {
        EditComponent ec;
        public addCompon()
        {
            InitializeComponent();
            ec = new EditComponent(enterCompany,enterModel, enterTypeComponents, textBox1, textBox2, textBox3, textBox4);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ec.addComponents();
        }

         

        

        private void button2_Click(object sender, EventArgs e)
        {
            ec.addCharacteristicsComp();
        }

         

        private void button3_Click(object sender, EventArgs e)
        {
            ec.delete();
        }
    }


    }

