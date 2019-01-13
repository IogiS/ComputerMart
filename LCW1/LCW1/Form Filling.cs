using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LCW1
{

    class Form_Filling : CheckCompability
    {
        int place = 0;

        public ComboBox comboBox1 { get; private set; }
        public ComboBox comboBox2 { get; private set; }
        public ComboBox comboBox3 { get; private set; }
        public ComboBox comboBox4 { get; private set; }
        public ComboBox comboBox5 { get; private set; }
        public ComboBox comboBox6 { get; private set; }
        public DataGridView dataGridView1 { get; private set; }


        public Form_Filling(ComboBox combobox1, ComboBox combobox2, ComboBox combobox3, ComboBox combobox4, ComboBox combobox5, ComboBox combobox6, DataGridView dgv)
        {
            comboBox1 = combobox1;
            comboBox2 = combobox2;
            comboBox3 = combobox3;
            comboBox4 = combobox4;
            comboBox5 = combobox5;
            comboBox6 = combobox6;
            dataGridView1 = dgv;
        }




       public void writes( ComboBox cbname, string componentname)
        {
            try
            {
                if (cbname.Items[cbname.SelectedIndex].ToString() != "-1")
                {
                    int rowi = 0;
                    //dataGridView1.Columns.Add(componentname, componentname);
                    string mother = cbname.Items[cbname.SelectedIndex].ToString();
                    string ressplit = mother.Substring(mother.IndexOf(" ", 0) + 1);

                    string result = "", resultProc = "";
                    int idmother = 0;

                    using (LCWContext lcw = new LCWContext())
                    {
                        foreach (Component charka2 in lcw.Components)
                        {
                            if (charka2.MODEL == ressplit)
                            {
                                idmother = charka2.ID_COMPONENT;
                            }
                        }
                        foreach (CharacteristicComp charka1 in lcw.CharacteristicsComps)
                        {
                            if (charka1.ID_COMPONENT == idmother)
                            {
                                resultProc += charka1.CC_VALUE + ";" + charka1.ID_CHARACTERISTIC + " ";
                            }
                        }

                        result = result.TrimEnd(' ');
                        resultProc = resultProc.TrimEnd(' ');
                        char[] charr = resultProc.ToCharArray();

                        for (int g = 0; g < resultProc.Split(' ').Count(); g++)
                        {

                            string str = resultProc.Split(' ')[g].Split(';')[1];
                            int digit = Convert.ToInt32(str);
                            foreach (Characteristic charka1 in lcw.Characteristics)
                            {

                                if (digit == charka1.ID_CHARACTERISTIC)
                                {
                                    string rg = "";
                                    string rt = "";
                                    rt = resultProc.Split(' ')[g].Replace(resultProc.Split(' ')[g].Split(';')[1], charka1.CHARA_NAME);
                                    rt = rt.Replace(';', ' ');
                                    rg = String.Join(" ", rt.Split(' ').Reverse());
                                    rg = rg.Replace(" ", ": ");
                                    dataGridView1.Rows.Add();
                                    dataGridView1[place, rowi].Value = rg.ToString();
                                    rowi++;
                                    break;
                                }
                            }
                        }
                    }
                    if (place < 4)
                        place++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

       public void loadComponents()
        {


            using (LCWContext lcw = new LCWContext())
            {
                foreach (Component component in
                lcw.Components.Where(c => c.TYPE_COMPONENTS.Contains("Processor")))
                {
                    comboBox1.Items.Add(component.COMPANY + " " + component.MODEL);
                }

                foreach (Component component in
                lcw.Components.Where(c => c.TYPE_COMPONENTS.Contains("Videocard")))
                {
                    comboBox3.Items.Add(component.COMPANY + " " + component.MODEL);
                }

                foreach (Component component in

                    lcw.Components.Where(c => c.TYPE_COMPONENTS.Contains("RAM")))
                {
                    comboBox5.Items.Add(component.COMPANY + " " + component.MODEL);
                }

                foreach (Component component in
                lcw.Components.Where(c => c.TYPE_COMPONENTS.Contains("Motherboard")))
                {
                    comboBox2.Items.Add(component.COMPANY + " " + component.MODEL);
                }

                foreach (Component component in
                lcw.Components.Where(c => c.TYPE_COMPONENTS.Contains("Power")))
                {
                    comboBox4.Items.Add(component.COMPANY + " " + component.MODEL);
                }

            }
            

        }

       public void clearboxes()
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            comboBox4.Items.Clear();
            comboBox5.Items.Clear();
        }

       public void cb2filling()
        {
            try
            {

                comboBox1.Items.Clear();
                comboBox3.Items.Clear();
                comboBox4.Items.Clear();
                comboBox5.Items.Clear();
                string mother = comboBox2.Items[comboBox2.SelectedIndex].ToString();
                string ressplit = mother.Substring(mother.IndexOf(" ", 0) + 1);
                check(ressplit,  comboBox1, "Processor");
                check(ressplit,  comboBox3, "Videocard");
                check(ressplit,  comboBox4, "Power");
                check(ressplit,  comboBox5, "RAM");
                //check(ressplit, comboBox6, "HDD");
                comboBox1.Text =  comboBox1.Items[0].ToString();
                comboBox3.Text =  comboBox3.Items[0].ToString();
                comboBox4.Text =  comboBox4.Items[0].ToString();
                comboBox5.Text =  comboBox5.Items[0].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

       public void cb4filling()
        {
            buildCmp bcmp = new buildCmp();
            try
            {
                 comboBox1.Items.Clear();
                 comboBox3.Items.Clear();
                 comboBox2.Items.Clear();
                 comboBox5.Items.Clear();
                string mother =  comboBox4.Items[ comboBox4.SelectedIndex].ToString();
                string ressplit = mother.Substring(mother.IndexOf(" ", 0) + 1);
                check(ressplit,  comboBox1, "Processor");
                check(ressplit,  comboBox2, "Motherboard");
                check(ressplit,  comboBox3, "Videocard");
                check(ressplit,  comboBox5, "RAM");
                //check(ressplit, comboBox6, "HDD");
                 comboBox2.Text =  comboBox2.Items[0].ToString();
                 comboBox3.Text =  comboBox3.Items[0].ToString();
                 comboBox1.Text =  comboBox1.Items[0].ToString();
                 comboBox5.Text =  comboBox5.Items[0].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

       public void cb1filling()
        {

            buildCmp bcmp = new buildCmp();
            try
            {
                 comboBox2.Items.Clear();
                 comboBox3.Items.Clear();
                 comboBox4.Items.Clear();
                 comboBox5.Items.Clear();
                string mother =  comboBox1.Items[ comboBox1.SelectedIndex].ToString();
                string ressplit = mother.Substring(mother.IndexOf(" ", 0) + 1);
                check(ressplit,  comboBox2, "Motherboard");
                check(ressplit,  comboBox3, "Videocard");
                check(ressplit,  comboBox4, "Power");
                check(ressplit,  comboBox5, "RAM");
                //check(ressplit, comboBox6, "HDD");
                 comboBox2.Text =  comboBox2.Items[0].ToString();
                 comboBox3.Text =  comboBox3.Items[0].ToString();
                 comboBox4.Text =  comboBox4.Items[0].ToString();
                 comboBox5.Text =  comboBox5.Items[0].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
} 

       public void cb3filling()
        {
            buildCmp bcmp = new buildCmp();
            try
            {
                 comboBox1.Items.Clear();
                 comboBox2.Items.Clear();
                 comboBox4.Items.Clear();
                 comboBox5.Items.Clear();
                string mother =  comboBox3.Items[ comboBox3.SelectedIndex].ToString();
                string ressplit = mother.Substring(mother.IndexOf(" ", 0) + 1);
                check(ressplit,  comboBox1, "Processor");
                check(ressplit,  comboBox2, "Motherboard");
                check(ressplit,  comboBox4, "Power");
                check(ressplit,  comboBox5, "RAM");
                //check(ressplit, comboBox6, "HDD");
                 comboBox2.Text =  comboBox2.Items[0].ToString();
                 comboBox1.Text =  comboBox1.Items[0].ToString();
                 comboBox4.Text =  comboBox4.Items[0].ToString();
                 comboBox5.Text =  comboBox5.Items[0].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

       public void cb6filling()
        {
            buildCmp bcmp = new buildCmp();
            try
            {

                string mother =  comboBox6.Items[ comboBox6.SelectedIndex].ToString();
                string ressplit = mother.Substring(mother.IndexOf(" ", 0) + 1);
                check(ressplit,  comboBox1, "Processor");
                check(ressplit,  comboBox2, "Motherboard");
                check(ressplit,  comboBox3, "Videocard");
                check(ressplit,  comboBox4, "Power");
                check(ressplit,  comboBox5, "RAM");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        
       public void cb5filling()
        {
            try
            {

                 comboBox1.Items.Clear();
                 comboBox3.Items.Clear();
                 comboBox4.Items.Clear();
                 comboBox2.Items.Clear();
                string mother =  comboBox5.Items[ comboBox5.SelectedIndex].ToString();
                string ressplit = mother.Substring(mother.IndexOf(" ", 0) + 1);
                check(ressplit,  comboBox1, "Processor");
                check(ressplit,  comboBox2, "Motherboard");
                check(ressplit,  comboBox3, "Videocard");
                check(ressplit,  comboBox4, "Power");
                //check(ressplit, comboBox6, "HDD");
                 comboBox2.Text =  comboBox2.Items[0].ToString();
                 comboBox3.Text =  comboBox3.Items[0].ToString();
                 comboBox4.Text =  comboBox4.Items[0].ToString();
                 comboBox1.Text =  comboBox1.Items[0].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
