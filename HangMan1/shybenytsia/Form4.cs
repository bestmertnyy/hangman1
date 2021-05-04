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
    public partial class Form4 : Form
    {
        List<string> animals = new List<string>(new string[] { "ВОВК", "ЛИСИЦЯ", "ЗАЄЦЬ", "МИША", "ЖАБА", "ЗМІЯ", "СОБАКА", "КІТ", "ЛЕВ", "КРОКОДИЛ", "ВОСЬМИНІГ", "АКУЛА", "ПАПУГА", "ВЕДМІДЬ", "ЇЖАК", "ЛЕОПАРД", "АНТИЛОПА" });
        List<string> countries = new List<string>(new string[] { "АЛБАНІЯ", "АФГАНІСТАН", "БРАЗИЛІЯ", "ВЕНЕСУЕЛА", "ГАЇТІ", "ГРУЗІЯ", "ЕКВАДОР", "ЕФІОПІЯ", "ЄГИПЕТ", "ІНДОНЕЗІЯ", "КОЛУМБІЯ", "ЛЮКСЕМБУРГ", "МАВРИКІЙ", "НІМЕЧЧИНА", "ПОРТУГАЛІЯ", "СІНГАПУР", "ХОРВАТІЯ", "ШВЕЙЦАРІЯ", "ЧОРНОГОРІЯ" });
        List<string> plants = new List<string>(new string[] { "ОБЛІПИХА", "АКАЦІЯ", "АВОКАДО", "ВІЛЬХА", "ВЕРБА", "КАЛИНА", "ЯЛИНКА", "ЧЕРЕШНЯ", "ПОЛУНИЦЯ", "СМОРОДИНА", "ПАЛЬМА", "ЗВІРОБІЙ", "ЯЛІВЕЦЬ", "КАРТОПЛЯ", "МОРКВА", "ІНЖИР" });
        List<string> programming = new List<string>(new string[] { "ЗМІННА", "КОНСТАНТА", "ФУНКЦІЯ", "ІНКАПСУЛЯЦІЯ", "ПОЛІМОРФІЗМ", "НАСЛІДУВАННЯ", "РЕКУРСІЯ", "КЛАС", "БІБЛІОТЕКА" });
        Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();


        string current_word, current_text;
        List<int> foundIndexes;
        List<Bitmap> bitmaps;
        int count_of_errors;
        public Form4()
        {
            InitializeComponent();

            dict.Add("ТВАРИНИ", animals);
            dict.Add("РОСЛИНИ", plants);
            dict.Add("КРАЇНИ", countries);
            dict.Add("ПРОГРАМУВАННЯ", programming);

            bitmaps = new List<Bitmap>();
            for (int i = 1; i <= 10; i++)
            {
                bitmaps.Add(new Bitmap(".\\" + i.ToString() + ".png"));
            }
            foundIndexes = new List<int>();
            var random = new Random();
            string theme = dict.Keys.ElementAt(random.Next(dict.Count));
            int index_word = new Random().Next(dict[theme].Count);
            current_word = dict[theme][index_word];
            label2.Text = theme;
            label1.Text = "";
            for (int i = 0; i < current_word.Length; i++)
            {
                label1.Text += "*";
            }
            count_of_errors = 0;


        }
        private void Find_Indexes(string letter)
        {
            foundIndexes.Clear();

            for (int i = current_word.IndexOf(letter); i > -1; i = current_word.IndexOf(letter, i + 1))
            {
                // for loop end when i=-1 (letter not found)
                foundIndexes.Add(i);

            }
        }

       
        void PlayAgain()
        {
            var result = MessageBox.Show("Грати ще раз?", "Грати ще раз?",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);

            // If the no button was pressed ...
            if (result == DialogResult.No)
            {
                Form2 form2 = new Form2();
                if (this.WindowState == FormWindowState.Maximized)
                {
                    form2.WindowState = FormWindowState.Maximized;
                }
                form2.Tag = this;
                form2.StartPosition = FormStartPosition.Manual;
                form2.Location = this.Location;
                this.Hide();
               // Form2 form2 = new Form2();
                form2.Show();
            }
            else
            {
                Form2.Users[Form2.selectedIndex].Count += 1;
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
        }
        void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Enabled == true)
            {
                if (current_word.Contains(button.Text))
                {
                    button.BackColor = Color.Green;
                    button.Enabled = false;
                    Change_Label(button.Text);
                    if (label1.Text == current_word)
                    {
                        label1.BackColor = Color.LightGreen;
                        Form2.Users[Form2.selectedIndex].Win += 1;
                        Form2.Users[Form2.selectedIndex].Rate = Math.Round(Convert.ToDouble(Form2.Users[Form2.selectedIndex].Win) / Convert.ToDouble(Form2.Users[Form2.selectedIndex].Count), 2);
                        PlayAgain();
                    }
                }
                else
                {
                    button.BackColor = Color.Red;
                    button.Enabled = false;
                    count_of_errors++;
                    pictureBox1.Image = bitmaps[count_of_errors - 1];
                    if (count_of_errors == 10)
                    {
                        label1.Text = current_word;
                        label1.BackColor = Color.DarkRed;
                        Form2.Users[Form2.selectedIndex].Rate = Math.Round(Convert.ToDouble(Form2.Users[Form2.selectedIndex].Win) / Convert.ToDouble(Form2.Users[Form2.selectedIndex].Count), 2);
                        PlayAgain();
                    }
                }

            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void Change_Label(string letter)
        {
            Find_Indexes(letter);
            current_text = label1.Text;

            var aStringBuilder = new StringBuilder(current_text);

            foreach (int ind in foundIndexes)
            {
                aStringBuilder.Remove(ind, 1);
                aStringBuilder.Insert(ind, letter);
                current_text = aStringBuilder.ToString();
            }
            label1.Text = current_text;


        }


    }
}
