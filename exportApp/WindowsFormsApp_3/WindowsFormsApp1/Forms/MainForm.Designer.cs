
namespace WindowsFormsApp1
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            this.label_Date = new System.Windows.Forms.Label();
            this.label_FirstName = new System.Windows.Forms.Label();
            this.label_LastName = new System.Windows.Forms.Label();
            this.label_Country = new System.Windows.Forms.Label();
            this.label_City = new System.Windows.Forms.Label();
            this.label_SurName = new System.Windows.Forms.Label();
            this.textBox_Date = new System.Windows.Forms.TextBox();
            this.textBox_FirstName = new System.Windows.Forms.TextBox();
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.textBox_SurName = new System.Windows.Forms.TextBox();
            this.textBox_City = new System.Windows.Forms.TextBox();
            this.textBox_Country = new System.Windows.Forms.TextBox();
            this.button_Excel = new System.Windows.Forms.Button();
            this.button_XML = new System.Windows.Forms.Button();
            this.label_Close = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Date.Location = new System.Drawing.Point(444, 51);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(44, 21);
            this.label_Date.TabIndex = 0;
            this.label_Date.Text = "Date";
            // 
            // label_FirstName
            // 
            this.label_FirstName.AutoSize = true;
            this.label_FirstName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_FirstName.Location = new System.Drawing.Point(444, 97);
            this.label_FirstName.Name = "label_FirstName";
            this.label_FirstName.Size = new System.Drawing.Size(88, 21);
            this.label_FirstName.TabIndex = 1;
            this.label_FirstName.Text = "First Name";
            // 
            // label_LastName
            // 
            this.label_LastName.AutoSize = true;
            this.label_LastName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_LastName.Location = new System.Drawing.Point(444, 149);
            this.label_LastName.Name = "label_LastName";
            this.label_LastName.Size = new System.Drawing.Size(86, 21);
            this.label_LastName.TabIndex = 2;
            this.label_LastName.Text = "Last Name";
            // 
            // label_Country
            // 
            this.label_Country.AutoSize = true;
            this.label_Country.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Country.Location = new System.Drawing.Point(444, 311);
            this.label_Country.Name = "label_Country";
            this.label_Country.Size = new System.Drawing.Size(69, 21);
            this.label_Country.TabIndex = 3;
            this.label_Country.Text = "Country";
            // 
            // label_City
            // 
            this.label_City.AutoSize = true;
            this.label_City.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_City.Location = new System.Drawing.Point(444, 256);
            this.label_City.Name = "label_City";
            this.label_City.Size = new System.Drawing.Size(38, 21);
            this.label_City.TabIndex = 4;
            this.label_City.Text = "City";
            // 
            // label_SurName
            // 
            this.label_SurName.AutoSize = true;
            this.label_SurName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_SurName.Location = new System.Drawing.Point(444, 204);
            this.label_SurName.Name = "label_SurName";
            this.label_SurName.Size = new System.Drawing.Size(77, 21);
            this.label_SurName.TabIndex = 5;
            this.label_SurName.Text = "SurName";
            // 
            // textBox_Date
            // 
            this.textBox_Date.Location = new System.Drawing.Point(538, 50);
            this.textBox_Date.Name = "textBox_Date";
            this.textBox_Date.Size = new System.Drawing.Size(192, 22);
            this.textBox_Date.TabIndex = 6;
            this.textBox_Date.Enter += new System.EventHandler(this.textBox_Date_Enter);
            this.textBox_Date.Leave += new System.EventHandler(this.textBox_Date_Leave);
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.Location = new System.Drawing.Point(538, 96);
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.Size = new System.Drawing.Size(192, 22);
            this.textBox_FirstName.TabIndex = 7;
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.Location = new System.Drawing.Point(538, 148);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.Size = new System.Drawing.Size(192, 22);
            this.textBox_LastName.TabIndex = 8;
            // 
            // textBox_SurName
            // 
            this.textBox_SurName.Location = new System.Drawing.Point(538, 203);
            this.textBox_SurName.Name = "textBox_SurName";
            this.textBox_SurName.Size = new System.Drawing.Size(192, 22);
            this.textBox_SurName.TabIndex = 9;
            // 
            // textBox_City
            // 
            this.textBox_City.Location = new System.Drawing.Point(538, 255);
            this.textBox_City.Name = "textBox_City";
            this.textBox_City.Size = new System.Drawing.Size(192, 22);
            this.textBox_City.TabIndex = 10;
            // 
            // textBox_Country
            // 
            this.textBox_Country.Location = new System.Drawing.Point(538, 310);
            this.textBox_Country.Name = "textBox_Country";
            this.textBox_Country.Size = new System.Drawing.Size(192, 22);
            this.textBox_Country.TabIndex = 11;
            // 
            // button_Excel
            // 
            this.button_Excel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Excel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Excel.Location = new System.Drawing.Point(672, 378);
            this.button_Excel.Name = "button_Excel";
            this.button_Excel.Size = new System.Drawing.Size(87, 38);
            this.button_Excel.TabIndex = 12;
            this.button_Excel.Text = "Excel";
            this.button_Excel.UseVisualStyleBackColor = true;
            this.button_Excel.Click += new System.EventHandler(this.button_Excel_Click);
            // 
            // button_XML
            // 
            this.button_XML.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_XML.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_XML.Location = new System.Drawing.Point(497, 378);
            this.button_XML.Name = "button_XML";
            this.button_XML.Size = new System.Drawing.Size(87, 38);
            this.button_XML.TabIndex = 13;
            this.button_XML.Text = "XML";
            this.button_XML.UseVisualStyleBackColor = true;
            this.button_XML.Click += new System.EventHandler(this.button_XML_Click);
            // 
            // label_Close
            // 
            this.label_Close.AutoSize = true;
            this.label_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_Close.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Close.Location = new System.Drawing.Point(759, 19);
            this.label_Close.Name = "label_Close";
            this.label_Close.Size = new System.Drawing.Size(20, 21);
            this.label_Close.TabIndex = 14;
            this.label_Close.Text = "X";
            this.label_Close.Click += new System.EventHandler(this.label_Close_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(401, 377);
            this.dataGridView1.TabIndex = 15;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label_Close);
            this.Controls.Add(this.button_XML);
            this.Controls.Add(this.button_Excel);
            this.Controls.Add(this.textBox_Country);
            this.Controls.Add(this.textBox_City);
            this.Controls.Add(this.textBox_SurName);
            this.Controls.Add(this.textBox_LastName);
            this.Controls.Add(this.textBox_FirstName);
            this.Controls.Add(this.textBox_Date);
            this.Controls.Add(this.label_SurName);
            this.Controls.Add(this.label_City);
            this.Controls.Add(this.label_Country);
            this.Controls.Add(this.label_LastName);
            this.Controls.Add(this.label_FirstName);
            this.Controls.Add(this.label_Date);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.Label label_FirstName;
        private System.Windows.Forms.Label label_LastName;
        private System.Windows.Forms.Label label_Country;
        private System.Windows.Forms.Label label_City;
        private System.Windows.Forms.Label label_SurName;
        private System.Windows.Forms.TextBox textBox_Date;
        private System.Windows.Forms.TextBox textBox_FirstName;
        private System.Windows.Forms.TextBox textBox_LastName;
        private System.Windows.Forms.TextBox textBox_SurName;
        private System.Windows.Forms.TextBox textBox_City;
        private System.Windows.Forms.TextBox textBox_Country;
        private System.Windows.Forms.Button button_Excel;
        private System.Windows.Forms.Button button_XML;

        #endregion

        private System.Windows.Forms.Label label_Close;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}