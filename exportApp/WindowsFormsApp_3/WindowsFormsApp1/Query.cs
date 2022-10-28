using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Query
    {
        public static TextBox txt = new TextBox();
        public void QueryToList(ref List<User> ListUsers, User user, TextBox textBox_Date, TextBox textBox_FirstName, TextBox textBox_LastName,
                                                TextBox textBox_SurName, TextBox textBox_City, TextBox textBox_Country)
        {
            UserContext db = new UserContext();

            IQueryable<User> query = db.Users;
            if (textBox_Date.Text.Length != 0) query = query.Where(p => p.Date == textBox_Date.Text);
            if (textBox_FirstName.Text.Length != 0) query = query.Where(p => p.FirstName == textBox_FirstName.Text);
            if (textBox_LastName.Text.Length != 0) query = query.Where(p => p.LastName == textBox_LastName.Text);
            if (textBox_SurName.Text.Length != 0) query = query.Where(p => p.SurName == textBox_SurName.Text);
            if (textBox_City.Text.Length != 0) query = query.Where(p => p.City == textBox_City.Text);
            if (textBox_Country.Text.Length != 0) query = query.Where(p => p.Country == textBox_Country.Text);
            ListUsers = query.ToList();
        }
    }
}
