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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
        }

       

       
        private void classbutton1_Click(object sender, EventArgs e)
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

        private void classbutton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. Натисніть кнопку грати на головній\n\n2. В меню налаштувань оберіть гравця(або додайте нового), оберіть тематику слова, яке будете відгадувати, та натисніть ГРАТИ.Також Ви можете повернутись на головну та переглянути рейтинг гравців.\n\n3. Керуючи за допомогою мишки обирайте букви, які на Вашу думку можуть бути в слові.За кожну неправильну букву домальовується частинка шибениці чи тулуба.Якщо гравець не встиг вгадати слово менше ніж за 10 спроб, шибениця зявляється повністю і він програє.Інакше - Ви виграли.Можете зіграти ще раз, або обрати новго гравця.", "ПРАВИЛА");
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
