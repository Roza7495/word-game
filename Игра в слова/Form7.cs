using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Игра_в_слова
{
    public partial class Form7 : Form
    {
        string f = @"RecordFile.txt";
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            FileStream recordTabl = new FileStream(f, FileMode.Open, FileAccess.Read);
            StreamReader readerRecordTabl = new StreamReader(recordTabl);
            textBox1.Text = readerRecordTabl.ReadToEnd();
            readerRecordTabl.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();
            fr1.Show();
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены что хотите очистить таблицу рекордов?", "Очстить таблицу", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                textBox1.Text = "";
                FileStream recordTabl1 = new FileStream(f, FileMode.Create, FileAccess.Write);
                StreamWriter writeRecordTabl = new StreamWriter(recordTabl1);
                writeRecordTabl.Write("");
                writeRecordTabl.Close();
            }
        }

        private void Form7_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(192,0,192);
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
