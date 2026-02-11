using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Игра_в_слова
{
    public partial class Form6 : Form
    {
        int i = 0;
        List<Image> list = new List<Image> { Image.FromFile("1.jpg"), Image.FromFile("2.jpg") ,Image.FromFile("3.jpg"),
            Image.FromFile("4.jpg"),Image.FromFile("5.jpg"),Image.FromFile("6.jpg"), Image.FromFile("7.jpg"),
            Image.FromFile("8.jpg"), Image.FromFile("9.jpg"),Image.FromFile("10.jpg"),Image.FromFile("11.jpg"),
            Image.FromFile("12.jpg") };
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();
            fr1.Show();
            this.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form6_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = list[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (i < 11)
            {
                i++;
                pictureBox1.Image = list[i];
                if (i == 1)
                {
                    label1.Text = "Я хочу рассказать вам про мою группу ПИ-37";
                }
                if (i == 2)
                {
                    label1.Text = "Наши девчонки самые красивые и милые";
                }
                if (i == 3)
                {
                    label1.Text = "Мы очень друг друга любим";
                }
                if (i == 4)
                {
                    label1.Text = "Помогаем, если вдруг у кого-то что-то не получается";
                }
                if (i == 5)
                {
                    label1.Text = "Да, на парах мы любим фотографироваться";
                }
                if (i == 6)
                {
                    label1.Text = "Очень любим";
                }
                if (i == 7)
                {
                    label1.Text = "А наши любимые мальчики не только фотографироваться";
                }
                if (i == 9)
                {
                    label1.Text = "А вот здесь решили отвлечься и позаниматься балетом";
                }
                if (i == 10)
                {
                    label1.Text = "Любим гулять все вместе, хоть и не часто, но нам нравится";
                }
                if (i == 8)
                {
                    label1.Text = "Также любят носить одинаковые вещи";
                }
                if (i == 11)
                {
                    label1.Text = "Я люблю свою группу и рада, что попала сюда";
                }
            }
            else
            {
                i = 0;
                pictureBox1.Image = list[i];
                label1.Text = "Программу разработала Садыкова Р. М.";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (i != 0 )
            {
                i--;
                pictureBox1.Image = list[i];
                if (i == 0)
                {
                    label1.Text = "Программу разработала Садыкова Р. М.";
                }
                if (i == 1)
                {
                    label1.Text = "Я хочу рассказать вам про мою группу ПИ-37";
                }
                if (i == 2)
                {
                    label1.Text = "Наши девчонки самые красивые и милые";
                }
                if (i == 3)
                {
                    label1.Text = "Мы очень друг друга любим";
                }
                if (i == 4)
                {
                    label1.Text = "Помогаем, если вдруг у кого-то что-то не получается";
                }
                if (i == 5)
                {
                    label1.Text = "Да, на парах мы любим фотографироваться";
                }
                if (i == 6)
                {
                    label1.Text = "Очень любим";
                }
                if (i == 7)
                {
                    label1.Text = "А наши любимые мальчики не только фотографироваться";
                }
                if (i == 9)
                {
                    label1.Text = "А вот здесь решили отвлечься и позаниматься балетом";
                }
                if (i == 10)
                {
                    label1.Text = "Любим гулять все вместе, хоть и не часто, но нам нравится";
                }
                if (i == 8)
                {
                    label1.Text = "Также любят носить одинаковые вещи";
                }
            }
            else
            {
                i = 11;
                pictureBox1.Image = list[i];
                label1.Text = "Я люблю свою группу и рада, что попала сюда";
            }
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(192,0,192);
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.Purple;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(192, 0, 192);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Purple;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(192, 0, 192);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Purple;
        }
    }
}
