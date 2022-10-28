using System;

public class TextBoxs
{
        public bool CheckTextBox(TextBox tbDate, TextBox tbFirstName,
                                        TextBox tbLastName, TextBox tbSurName, TextBox tbCity, TextBox tbCountry)
        {       
            UserContext db = new UserContext();
            var a = db.Users.OrderByDescending(p => p.Id).First();
            MessageBox.Show(string.Format(a.Date));

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

            //DateTime d = DateTime.ParseExact(tbDate.Text, "yyyyMdd", null);
            //MessageBox.Show(d.ToString());


            /////////////////////////////////////////////////////////

            //if (tbFirstName.Text[0] == tbFirstName.Text.ToUpper()[0] || tbFirstName.Text == "")// && (tbLastName.Text[0] == tbLastName.Text.ToUpper()[0] ^ tbLastName.Text == ""))// ||
            //                     //tbSurName.Text[0] == tbSurName.Text.ToUpper()[0] || tbCity.Text[0] == tbCity.Text.ToUpper()[0] ||
            //                     //tbCountry.Text[0] == tbCountry.Text.ToUpper()[0])
            //        {
            //            //tbDate = tbDate;
            //            return true;
            //        }
            //        //MessageBox.Show("enter the text with a capital letter");&
            //        else
            //        {
            //            // tbDate = tbDate;
            //            return false;
            //        }
        }
    //}
}
