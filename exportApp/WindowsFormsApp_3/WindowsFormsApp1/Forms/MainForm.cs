using MySql.Data.MySqlClient;
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
using System.Data.SqlClient;
using System.Xml.Serialization;


namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        User user = new User();
        List<User> ListUsers = new List<User>();
        Query query = new Query();
        public string tbDate;
        public string tbFirstName;
        public string tbLastName;
        public string tbSurName;
        public string tbCity;
        public string tbCountry;
        public MainForm()
        {
            InitializeComponent();
            MessageBox.Show("Please enter the date in the format yyyy/mm/dd without spaces or punctuation marks;" +
                " all fields with a capital letter");
            textBox_Date.Text = "yyyy/mm/dd";
            textBox_Date.ForeColor = Color.Gray;

            //tbDate = textBox_Date.Text;
            //tbFirstName = textBox_FirstName.Text;
            //tbLastName = textBox_LastName.Text;
            //tbSurName = textBox_SurName.Text;
            //tbCity = textBox_City.Text;
            //tbCountry = textBox_Country.Text;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            using (UserContext db = new UserContext())
            {
                var data = (from d in db.Users select d);
                //dataGridView1.Columns[0].Visible = false;
                dataGridView1.DataSource = data.ToList();
            }
        }

        private void button_Excel_Click(object sender, EventArgs e)
        {
            query.QueryToList(ref ListUsers, user, textBox_Date, textBox_FirstName, textBox_LastName, textBox_SurName,
                                                                            textBox_City, textBox_Country);
            ExportToExcel E = new ExportToExcel();
            E.ExportToFile(user, ListUsers);
            MessageBox.Show("users added to the Excel file");


            //foreach (var t in textBoxes )
            //{
            //    t.text = string.Empty;
            //}
            TextBoxs.ClearTextBox(textBox_Date, textBox_FirstName, textBox_LastName, textBox_SurName,
                                                                            textBox_City, textBox_Country);
        }

        private void button_XML_Click(object sender, EventArgs e)
        {
            TextBoxs tb = new TextBoxs();
            //ParseDate tb =new ParseDate();
            bool t = tb.CheckTextBox(/*List<TextBox> textBoxes)*/textBox_Date, textBox_FirstName, textBox_LastName,
                                        textBox_SurName, textBox_City, textBox_Country);
            if (!t)
            {
                TextBoxs.ClearTextBox(textBox_Date, textBox_FirstName, textBox_LastName, textBox_SurName,
                                                                             textBox_City, textBox_Country);
            }
            else
            {
                query.QueryToList(ref ListUsers, user, textBox_Date, textBox_FirstName, textBox_LastName, textBox_SurName,
                                                                            textBox_City, textBox_Country);
                ExportToXML E = new ExportToXML();
                E.ExportToFile(user, ListUsers);
                MessageBox.Show("users added to the XML file");
                TextBoxs.ClearTextBox(textBox_Date, textBox_FirstName, textBox_LastName, textBox_SurName,
                                                                            textBox_City, textBox_Country);
            }
        }

        Point LastPoint;
        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void label_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_Date_Enter(object sender, EventArgs e)
        {
            if (textBox_Date.Text == "yyyy/mm/dd")
            {
                textBox_Date.Text = "";
                textBox_Date.ForeColor = Color.Black;
            }
        }
        private void textBox_Date_Leave(object sender, EventArgs e)
        {
            if (textBox_Date.Text == "")
            {
                textBox_Date.Text = "yyyy/mm/dd";
                textBox_Date.ForeColor = Color.Gray;
            }
        }
    }
}