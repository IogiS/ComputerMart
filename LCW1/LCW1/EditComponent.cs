using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LCW1
{
    class EditComponent 
    {

        public TextBox enterCompany { get; private set; }
        public TextBox enterModel { get; private set; }
        public TextBox enterTypeComponents { get; private set; }
        public TextBox textBox1 { get; private set; }
        public TextBox textBox2 { get; private set; }
        public TextBox textBox3 { get; private set; }
        public TextBox textBox4 { get; private set; }


        public EditComponent(TextBox combobox1, TextBox combobox2, TextBox combobox3, TextBox combobox4, TextBox combobox5, TextBox combobox6, TextBox dgv)
        {
            enterCompany = combobox1;
            enterModel = combobox2;
            enterTypeComponents = combobox3;
            textBox1 = combobox4;
            textBox2 = combobox5;
            textBox3 = combobox6;
            textBox4 = dgv;
        }
        public void addComponents()
        {

            using (LCWContext lcw = new LCWContext())
            {
                Component cg = new Component { };
                cg.COMPANY =  enterCompany.Text;
                cg.MODEL =  enterModel.Text;
                cg.TYPE_COMPONENTS =  enterTypeComponents.Text;
                lcw.Components.Add(cg);
                lcw.SaveChanges();
            }
            MessageBox.Show("Success", "Add result");

        }

        public void addCharacteristicsComp()
        {
            using (LCWContext lcw = new LCWContext())
            {
                CharacteristicComp CP;
                CP = new CharacteristicComp { ID_COMPONENT = Int32.Parse( textBox1.Text) };
                CP.ID_CHARACTERISTIC = Int32.Parse( textBox2.Text);
                CP.CC_VALUE =  textBox3.Text;

                lcw.CharacteristicsComps.Add(CP);
                lcw.SaveChanges();
            }
            MessageBox.Show("Success", "Add result");
        }

        public void delete()
        {
            using (LCWContext lcw = new LCWContext())
            {
                int deletechar = int.Parse( textBox4.Text);
                CharacteristicComp cg = lcw.CharacteristicsComps
                    .Where(o => o.ID_CHAR == deletechar)
                    .FirstOrDefault();



                lcw.CharacteristicsComps.Remove(cg);
                lcw.SaveChanges();

            }
            MessageBox.Show("Success", "Delete result");
        }
    }
}
