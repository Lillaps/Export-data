using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class  TextBoxs
    {
        public static void ClearTextBox(/*List<TextBox> textBoxes)*/TextBox txt1, TextBox txt2,
                                        TextBox txt3, TextBox txt4, TextBox txt5, TextBox txt6)
        {
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
            txt5.Text = "";
            txt6.Text = "";

        }

        public bool CheckTextBox(/*List<TextBox> textBoxes)*/TextBox tbDate, TextBox tbFirstName,
                                        TextBox tbLastName, TextBox tbSurName, TextBox tbCity, TextBox tbCountry)
        {
            UserContext db = new UserContext();
            var d = db.Users .OrderByDescending(p => p.Id).First();  
            MessageBox.Show(string.Format(d.Date));
            List<string> tbList = new List<string>();
            tbList.Add(tbFirstName.Text);
            tbList.Add(tbLastName.Text);
            tbList.Add(tbSurName.Text);
            tbList.Add(tbCity.Text);
            tbList.Add(tbCountry.Text);
            int k = 0;
            foreach (var tb in tbList)
            {
                if ((tb == ""))
                {
                    k++;
                }

                else if ((tb[0] == tb.ToUpper()[0]))
                {
                    k++;
                }
            }
            if (k < 5)
            {
                MessageBox.Show("!enter the text with a capital letter!");
                return false;
            }
            else return true;

        }
    }
}