using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LCW1
{
    public partial class buildCmp : Form
    {
        CheckCompability check = new CheckCompability();

        static Form_Filling filling;

        public buildCmp()
        {
            InitializeComponent();

            filling = new Form_Filling(comboBox1, comboBox2, comboBox3, comboBox4, comboBox5, comboBox6, dataGridView1);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            filling.loadComponents();
            
            comboBox6.Items.Add("Kingston SSDNow A400");
            comboBox6.Text = comboBox6.Items[0].ToString();
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }



        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            filling.cb2filling();
        }

        private void comboBox4_SelectionChangeCommitted(object sender, EventArgs e)
        {
            filling.cb4filling();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            filling.cb1filling();
        }

        private void comboBox3_SelectionChangeCommitted(object sender, EventArgs e)
        {
            filling.cb3filling();
        }

        private void comboBox6_SelectionChangeCommitted(object sender, EventArgs e)
        {
            filling.cb6filling();
        }

        private void comboBox5_SelectionChangeCommitted(object sender, EventArgs e)
        {
            filling.cb5filling();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            dataGridView1.Rows.Clear();
            filling.writes(comboBox1, "Processor");
            filling.writes(comboBox2, "Motherboard");
            filling.writes(comboBox3, "Videocard");
            filling.writes(comboBox4, "Power");
            filling.writes(comboBox5, "RAM");
            //writes(comboBox6, "HDD");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            filling.clearboxes();     
            filling.loadComponents();
        }
    }
}




