using Microsoft.VisualBasic.ApplicationServices;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Telegram.Bot;

namespace IsRpoamo_Azarenko
{
    public partial class Form1 : Form
    {
        string API = "";
        string ChatID = "893708549";

        public List<string> users = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Профиль_MouseEnter(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            groupBox8.Visible = true;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            groupBox4.Visible = true;
        }

        private void button_1_MouseLeave(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            groupBox8.Visible = false;
        }

        private void groupBox4_Leave(object sender, EventArgs e)
        {
            groupBox4.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Snow;
            groupBox4.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Chocolate;
            groupBox4.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;
            groupBox4.Visible = false;
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            groupBox5.Visible = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                groupBox5.Visible = false;
                MessageBox.Show("████████████████████████████████████████\r\n████████████████████████████████████████\r\n██████▀░░░░░░░░▀████████▀▀░░░░░░░▀██████\r\n████▀░░░░░░░░░░░░▀████▀░░░░░░░░░░░░▀████\r\n██▀░░░░░░░░░░░░░░░░▀▀░░░░░░░░░░░░░░░░▀██\r\n██░░░░░░░░░░░░░░░░░░░▄▄░░░░░░░░░░░░░░░██\r\n██░░░░░░░░░░░░░░░░░░█░█░░░░░░░░░░░░░░░██\r\n██░░░░░░░░░░░░░░░░░▄▀░█░░░░░░░░░░░░░░░██\r\n██░░░░░░░░░░████▄▄▄▀░░▀▀▀▀▄░░░░░░░░░░░██\r\n██▄░░░░░░░░░████░░░░░░░░░░█░░░░░░░░░░▄██\r\n████▄░░░░░░░████░░░░░░░░░░█░░░░░░░░▄████\r\n██████▄░░░░░████▄▄▄░░░░░░░█░░░░░░▄██████\r\n████████▄░░░▀▀▀▀░░░▀▀▀▀▀▀▀░░░░░▄████████\r\n██████████▄░░░░░░░░░░░░░░░░░░▄██████████\r\n████████████▄░░░░░░░░░░░░░░▄████████████\r\n██████████████▄░░░░░░░░░░▄██████████████\r\n████████████████▄░░░░░░▄████████████████\r\n██████████████████▄▄▄▄██████████████████\r\n████████████████████████████████████████\r\n████████████████████████████████████████", "А ты хорош!", MessageBoxButtons.OK);
            }
        }



        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                groupBox5.Visible = false;
                MessageBox.Show("░░░░░░░░░░░║\r\n░░▄█▀▄░░░░░║░░░░░░▄▀▄▄\r\n░░░░░░▀▄░░░║░░░░▄▀\r\n░▄▄▄░░░░█▄▄▄▄▄▄█░░░░▄▄▄\r\n▀░░░▀█░█▀░░▐▌░░▀█░█▀░░░▀\r\n░░░░░░██░░▀▐▌▀░░██\r\n░▄█▀▀▀████████████▀▀▀█\r\n█░░░░░░██████████░░░░░▀▄\r\n█▄░░░█▀░░▀▀▀▀▀▀░░▀█░░░▄█\r\n░▀█░░░█░░░░░░░░░░█░░░█▀\r\n", "МегаПлох", MessageBoxButtons.OK);
            }
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            button10.Visible = false;
            button8.Visible=false;
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = false;
            groupBox8.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            button8.Visible = true;
            groupBox1.Visible = false;
            button10.Visible = false;
            
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = false;
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = false;
            button8.Visible = false;
            groupBox8.Visible = true;
            button10.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox4.Visible = true;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            button10.Visible = false;
            button8.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = false;
            groupBox8.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            groupBox5.Visible = true;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox4.Visible = false;
            button10.Visible = false;
            button8.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = false;
            groupBox8.Visible = false;
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            groupBox6.Visible = true;
            groupBox8.Visible = true;
            foreach (var name in users)
            {
                string[] s = name.Split(' ');
                listBox1.Items.Add(s[0]);
            }

        }

        async void button9_Click(object sender, EventArgs e)
        {
            var bot = new TelegramBotClient(API);
            string name =listBox1.SelectedItem.ToString();
            string quest = textBox5.Text;
            await bot.SendTextMessageAsync(ChatID,$"Ответственный:{name}\nЗадача:{quest}");
            button8.Visible = false;
            groupBox6.Visible = false;
            groupBox8.Visible= false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            groupBox7.Visible = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            groupBox7.Visible = false;
            button10.Visible = false;
            string name, surname, login, password, mail;
            name = textBox2.Text;
            surname = textBox3.Text;
            login = textBox6.Text;
            password = textBox7.Text;
            mail = textBox8.Text;
            Contacts cs = new Contacts();
            string full = name + " " + surname + " " + login + " " + password + " " + mail;
            users.Add(full);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int o = listBox1.SelectedIndex;
            int q = 0;
            foreach (var item in users)
            {
                string[] s = item.Split(' ');
                label14.Text = s[0];
                label13.Text = s[1];
                label12.Text = s[2];
                label11.Text = s[3];
                label10.Text = s[4];
                if (q == o) 
                    break;
                else
                    q++;
            }
        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }
    }
}
