using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaStead_V2._0_.Commands
{
    public class Restriction
    {
        public static ArrayList checkControls(UserControl userControl)
        {
            ArrayList arrayList = new ArrayList();
            foreach (Control c in userControl.Controls)
            {
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    if (tb.Text == "")
                    {
                        arrayList.Add(tb);
                    }
                    else
                    {
                        if (arrayList.Contains(tb))
                        {
                            arrayList.Remove(tb);
                        }
                    }
                    tb.BackColor = tb.Text == "" ? tb.BackColor = Color.DodgerBlue : tb.BackColor = Color.White;
                }
                if (c is ComboBox)
                {
                    ComboBox combo = (ComboBox)c;
                    if (combo.SelectedIndex == -1)
                    {
                        arrayList.Add(combo);
                    }
                    else
                    {
                        if (arrayList.Contains(combo))
                        {
                            arrayList.Remove(combo);
                        }
                    }
                    combo.BackColor = combo.SelectedIndex == -1 ? combo.BackColor = Color.DodgerBlue : combo.BackColor = Color.White;
                }
                if (c is RadioButton)
                {
                    RadioButton radio = (RadioButton)c;
                    if (!radio.Checked)
                    {
                        arrayList.Add(radio);
                    }
                    else
                    {
                        if (arrayList.Contains(radio))
                        {
                            arrayList.Remove(radio);
                        }
                    }
                    radio.BackColor = !radio.Checked ? radio.BackColor = Color.DodgerBlue : radio.BackColor = Color.White;
                }
                //if (c is CheckBox)
                //{
                //    CheckBox check = (CheckBox)c;
                //    if (!check.Checked)
                //    {
                //        arrayList.Add(check);
                //    }
                //    else
                //    {
                //        if (arrayList.Contains(check))
                //        {
                //            arrayList.Remove(check);
                //        }
                //    }
                //    check.BackColor = !check.Checked ? check.BackColor = Color.DodgerBlue : check.BackColor = Color.White;
                //}
            }
            return arrayList;
        }
    }
}
