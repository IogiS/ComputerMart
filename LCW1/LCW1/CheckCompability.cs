using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LCW1
{
    class CheckCompability
    {
        public void check(string ressplit, ComboBox cbname, string componentname)
        {
            try
            {
                //comboBox1.Items.Clear();
                bool flagP = true;

                string result = "", resultProc = "";
                string reason = "";
                int idmother = 0, idproc = 0;
                int resCountP = 0;
                using (LCWContext lcw = new LCWContext())
                {
                    foreach (Component charka2 in lcw.Components)
                    {
                        if (charka2.MODEL == ressplit)
                        {
                            idmother = charka2.ID_COMPONENT;
                        }
                    }
                    for (int i = 0; i < lcw.Components.Where(c => c.TYPE_COMPONENTS.Contains(componentname)).Count(); i++)
                    {
                        result = ""; resultProc = ""; reason = ""; flagP = true;
                        foreach (Component component in
              lcw.Components.Where(c => c.TYPE_COMPONENTS.Contains(componentname)))
                        {
                            if (idproc < component.ID_COMPONENT)
                            {
                                idproc = component.ID_COMPONENT;
                                break;
                            }
                            else
                            {
                                continue;
                            }
                        }
                        foreach (CharacteristicComp charka1 in lcw.CharacteristicsComps)
                        {
                            if (charka1.ID_COMPONENT == idmother)
                            {
                                result += charka1.CC_VALUE + ';' + charka1.ID_CHARACTERISTIC + ' ';
                            }
                            else if (charka1.ID_COMPONENT == idproc)
                            {
                                resultProc += charka1.CC_VALUE + ";" + charka1.ID_CHARACTERISTIC + " ";
                            }
                        }
                        result = result.TrimEnd(' ');
                        resultProc = resultProc.TrimEnd(' ');
                        for (int g = 0; g < result.Split(' ').Count(); g++)
                        {
                            for (int j = 0; j < resultProc.Split(' ').Count(); j++)
                            {
                                if (flagP == true)
                                {
                                    if (result.Split(' ')[g].Split(';')[1] == resultProc.Split(' ')[j].Split(';')[1])
                                    {
                                        if (result.Split(' ')[g] == resultProc.Split(' ')[j])
                                        {

                                            resCountP++;
                                            continue;
                                        }
                                        else
                                        {
                                            reason += resultProc.Split(' ')[j].ToString();
                                            flagP = false;
                                            break;
                                            //reason = reason[0];
                                        }

                                    }

                                }
                            }
                        }

                        if (reason == "")
                        {
                            foreach (Component charka2 in lcw.Components)
                            {
                                if (charka2.ID_COMPONENT == idproc)
                                {
                                    cbname.Items.Add(charka2.COMPANY + " " + charka2.MODEL);
                                    break;
                                }
                            }
                        }
                        else
                            continue;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
