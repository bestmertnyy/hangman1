using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shybenytsia
{
    public partial class Form2 : Form
    {
        public static List<User> Users = new List<User>();
        public static int selectedIndex;
        public class User
        {
            public string Name { get; set; }

            public int Count { get; set; }

            public int Win { get; set; }

            public double Rate { get; set; }

            public User()
            {
                this.Name = "";
                this.Count = 0;
                this.Win = 0;
                this.Rate = 0;
            }
            public User(string name, int count, int win, double rate)
            {
                this.Name = name;
                this.Count = count;
                this.Win = win;
                this.Rate = rate;
            }

        }
        public Form2()
        {
            SortRate();

            InitializeComponent();

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = Users;

            if (dataGridView1.Rows.Count == 0)
                classbutton2.Enabled = false;
            else
                classbutton2.Enabled = true;


        }

        void SortRate()
        {
            Users = Users.OrderByDescending(o => o.Rate).ToList();

        }

 


       

     

        private void classbutton1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            if (this.WindowState == FormWindowState.Maximized)
            {
                form1.WindowState = FormWindowState.Maximized;
            }
            form1.Tag = this;
            form1.StartPosition = FormStartPosition.Manual;
            form1.Location = this.Location;
            this.Hide();
          //  Form1 form1 = new Form1();
            form1.Show();
        }

        private void classbutton2_Click(object sender, EventArgs e)
        {
            selectedIndex = dataGridView1.CurrentCell.RowIndex;
            Users[selectedIndex].Count += 1;
            Form4 form4 = new Form4();
            if (this.WindowState == FormWindowState.Maximized)
            {
                form4.WindowState = FormWindowState.Maximized;
            }
            form4.Tag = this;
            form4.StartPosition = FormStartPosition.Manual;
            form4.Location = this.Location;
            this.Hide();
            //Form4 form4 = new Form4();
            form4.Show();
        }

        private void classbutton3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                if (!(Users.Select(o => o.Name).ToList()).Contains(textBox1.Text))
                {
                    dataGridView1.DataSource = null;
                    Users.Add(new User(textBox1.Text, 0, 0, 0));
                    SortRate();
                    dataGridView1.DataSource = Users;
                    classbutton2.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Такий користувач вже існує");
                    textBox1.Text = "";
                }
            }
        }
    
    }
}
