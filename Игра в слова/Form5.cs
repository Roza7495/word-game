using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Игра_в_слова
{
    public partial class Form5 : Form
    {
        string f = @"RecordFile.txt";
        DateTime date;
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();
            fr1.Show();
            Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();
            fr1.Show();
            this.Visible = false;
        }
        //кнопка очистить
        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            button15.Enabled = true;
            button7.Enabled = true;
            button6.Enabled = true;
            button5.Enabled = true;
            button4.Enabled = true;
            button3.Enabled = true;
            button13.Enabled = true;
            button11.Enabled = true;
            button14.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button2.Enabled = true;
            button12.Enabled = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            string recordTime = label3.Text;
            if (Equals(textBox1.Text, label4.Text)&&(textBox1.Text!=""))
            {
                DialogResult result = MessageBox.Show("Хотите сохранить результат в таблицу рекордов?", "Победа", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    FileStream recordTabl1 = new FileStream(f, FileMode.Append, FileAccess.Write);
                    StreamWriter writeRecordTabl = new StreamWriter(recordTabl1);
                    writeRecordTabl.WriteLine(label1.Text + "--------------3 уровень------------- " + recordTime);
                    label1.Text = "";
                    writeRecordTabl.Close();
                    Form1 fr1 = new Form1();
                    fr1.Show();
                    this.Visible = false;

                }
                else
                {
                    if (result == DialogResult.No)
                    {
                        Form1 fr1 = new Form1();
                        fr1.Show();
                        this.Visible = false;
                    }
                    else
                    {
                        if (result == DialogResult.No)
                        {
                            Application.Exit();
                        }
                    }
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Хотите сыграть еще раз?", "Провал", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    label4.Text = "";
                    textBox1.Text = "";
                    button15.Enabled = true;
                    button7.Enabled = true;
                    button6.Enabled = true;
                    button5.Enabled = true;
                    button4.Enabled = true;
                    button3.Enabled = true;
                    button13.Enabled = true;
                    button11.Enabled = true;
                    button14.Enabled = true;
                    button8.Enabled = true;
                    button9.Enabled = true;
                    button10.Enabled = true;
                    button2.Enabled = true;
                    button12.Enabled = true;
                    //массив для перемешивания слова
                    int[] mas = new int[14];
                    mas[0] = 0;
                    mas[1] = 1;
                    mas[2] = 2;
                    mas[3] = 3;
                    mas[4] = 4;
                    mas[5] = 5;
                    mas[6] = 6;
                    mas[7] = 7;
                    mas[8] = 8;
                    mas[9] = 9;
                    mas[10] = 10;
                    mas[11] = 11;
                    mas[12] = 12;
                    mas[13] = 13;
                    var random = new Random(DateTime.Now.Millisecond);
                    mas = mas.OrderBy(x => random.Next()).ToArray();
                    button18.Visible = false;
                    textBox2.Visible = false;
                    label1.Text = textBox2.Text;
                    date = DateTime.Now;
                    timer1.Interval = 10;
                    timer1.Tick += new EventHandler(timer1_Tick);
                    timer1.Start();
                    char[] Alphabet = new char[] { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н',
 'о', 'п','р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я'};
                    string[] svyshe8 = new string[] { "кордебалет", "корреспондент", "фотография", "крематорий", "автомобиль",
"география", "картография", "водопровод", "драматург", "притеснение", "тренировка", "пентаграмма", "авторство",
"амфитеатр", "бриллиант", "гимнастика", "жестокость", "кульминация", "материалист", "тотализатор", "физкультура",
"хореография", "цивилизатор", "червоточина", "шестнадцать", "экипировка", "экзаменатор", "языкознание", "зажигалка","избранник" };
                    Random rand = new Random();
                    int i = rand.Next(30);
                    string slovo = svyshe8[i];
                    Random rand1 = new Random();
                    label2.Text = "Слово состоит из " + slovo.Length + " букв ";
                    //показ слова
                    for (int i7 = 0; i7 < slovo.Length; i7++)
                    {
                        char a14 = slovo[i7];
                        label4.Text = label4.Text + a14.ToString();
                        label4.Visible = false;
                    }
                    //прибавка букв к слову
                    int i1;
                    for (i1 = slovo.Length; i1 < 14; i1++)
                    {
                        int ii = rand1.Next(33);
                        slovo = slovo.Insert(i1, Alphabet[ii].ToString());
                    }
                    //первая кнопка
                    char a = slovo[mas[0]];
                    button4.Text = a.ToString();
                    //вторая кнопка
                    char a1 = slovo[mas[1]];
                    button8.Text = a1.ToString(); ;
                    //третья кнопка
                    char a2 = slovo[mas[2]];
                    button7.Text = a2.ToString();
                    //четвертая кнопка
                    char a3 = slovo[mas[3]];
                    button6.Text = a3.ToString();
                    //пятая кнопка
                    char a4 = slovo[mas[4]];
                    button10.Text = a4.ToString();
                    //шестая кнопка
                    char a5 = slovo[mas[5]];
                    button14.Text = a5.ToString();
                    //седьмая кнопка
                    char a6 = slovo[mas[6]];
                    button5.Text = a6.ToString();
                    //восьмая кнопка
                    char a7 = slovo[mas[7]];
                    button9.Text = a7.ToString();
                    //девятая кнопка
                    char a8 = slovo[mas[8]];
                    button3.Text = a8.ToString();
                    //десятая кнопка
                    char a9 = slovo[mas[9]];
                    button2.Text = a9.ToString();
                    //десятая кнопка
                    char a10 = slovo[mas[10]];
                    button15.Text = a10.ToString();
                    //десятая кнопка
                    char a11 = slovo[mas[11]];
                    button13.Text = a11.ToString();
                    //десятая кнопка
                    char a12 = slovo[mas[12]];
                    button11.Text = a12.ToString();
                    //десятая кнопка
                    char a13 = slovo[mas[13]];
                    button12.Text = a13.ToString();
                }
                else
                {
                    if (result == DialogResult.No)
                    {
                        Application.Exit();
                    }
                }

            }
        }
        //ввод ника //вставка слова и букв в кнопки уровень свыше 8
        private void button18_Click(object sender, EventArgs e)
        { //массив для перемешивания слова
            int[] mas = new int[14];
            mas[0] = 0;
            mas[1] = 1;
            mas[2] = 2;
            mas[3] = 3;
            mas[4] = 4;
            mas[5] = 5;
            mas[6] = 6;
            mas[7] = 7;
            mas[8] = 8;
            mas[9] = 9;
            mas[10] = 10;
            mas[11] = 11;
            mas[12] = 12;
            mas[13] = 13;
            var random = new Random(DateTime.Now.Millisecond);
            mas = mas.OrderBy(x => random.Next()).ToArray();
            button18.Visible = false;
            textBox2.Visible = false;
            label1.Text = textBox2.Text;
            date = DateTime.Now;
            timer1.Interval = 10;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
            char[] Alphabet = new char[] { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н',
 'о', 'п','р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я'};
            string[] svyshe8 = new string[] { "кордебалет", "корреспондент", "фотография", "крематорий", "автомобиль",
"география", "картография", "водопровод", "драматург", "притеснение", "тренировка", "пентаграмма", "авторство",
"амфитеатр", "бриллиант", "гимнастика", "жестокость", "кульминация", "материалист", "тотализатор", "физкультура",
"хореография", "цивилизатор", "червоточина", "шестнадцать", "экипировка", "экзаменатор", "языкознание", "зажигалка","избранник" };
            Random rand = new Random();
            int i = rand.Next(30);
            string slovo = svyshe8[i];
            Random rand1 = new Random();
            label2.Text = "Слово состоит из " + slovo.Length + " букв ";
            //показ слова
            for (int i7 = 0; i7 < slovo.Length; i7++)
            {
                char a14 = slovo[i7];
                label4.Text = label4.Text + a14.ToString();
                label4.Visible = false;
            }
            //прибавка букв к слову
            int i1;
            for (i1 = slovo.Length; i1 < 14; i1++)
            {
                int ii = rand1.Next(33);
                slovo = slovo.Insert(i1, Alphabet[ii].ToString());
            }
            //первая кнопка
            char a = slovo[mas[0]];
            button4.Text = a.ToString();
            //вторая кнопка
            char a1 = slovo[mas[1]];
            button8.Text = a1.ToString(); ;
            //третья кнопка
            char a2 = slovo[mas[2]];
            button7.Text = a2.ToString();
            //четвертая кнопка
            char a3 = slovo[mas[3]];
            button6.Text = a3.ToString();
            //пятая кнопка
            char a4 = slovo[mas[4]];
            button10.Text = a4.ToString();
            //шестая кнопка
            char a5 = slovo[mas[5]];
            button14.Text = a5.ToString();
            //седьмая кнопка
            char a6 = slovo[mas[6]];
            button5.Text = a6.ToString();
            //восьмая кнопка
            char a7 = slovo[mas[7]];
            button9.Text = a7.ToString();
            //девятая кнопка
            char a8 = slovo[mas[8]];
            button3.Text = a8.ToString();
            //десятая кнопка
            char a9 = slovo[mas[9]];
            button2.Text = a9.ToString();
            //десятая кнопка
            char a10 = slovo[mas[10]];
            button15.Text = a10.ToString();
            //десятая кнопка
            char a11 = slovo[mas[11]];
            button13.Text = a11.ToString();
            //десятая кнопка
            char a12 = slovo[mas[12]];
            button11.Text = a12.ToString();
            //десятая кнопка
            char a13 = slovo[mas[13]];
            button12.Text = a13.ToString();
        }
       
        private void Form5_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Перед началом игры введите ник");
        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            long tick = DateTime.Now.Ticks - date.Ticks;
            DateTime stopWatch = new DateTime();
            stopWatch = stopWatch.AddTicks(tick);
            label3.Text = String.Format("{0:HH:mm:ss:ff}", stopWatch);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button15.Text;
            button15.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button7.Text;
            button7.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button6.Text;
            button6.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button5.Text;
            button5.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button4.Text;
            button4.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button3.Text;
            button3.Enabled = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button13.Text;
            button13.Enabled = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button11.Text;
            button11.Enabled = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button14.Text;
            button14.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button8.Text;
            button8.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button9.Text;
            button9.Enabled = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button10.Text;
            button10.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button2.Text;
            button2.Enabled = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button12.Text;
            button12.Enabled = false;
        }

        private void button18_MouseEnter(object sender, EventArgs e)
        {
            button18.BackColor = Color.FromArgb(192,0,192);
        }

        private void button18_MouseLeave(object sender, EventArgs e)
        {
            button18.BackColor = Color.Purple;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(192, 0, 192);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Purple;
        }

        private void button17_MouseEnter(object sender, EventArgs e)
        {
            button17.BackColor = Color.FromArgb(192, 0, 192);
        }

        private void button17_MouseLeave(object sender, EventArgs e)
        {
            button17.BackColor = Color.Purple;
        }

        private void button16_MouseEnter(object sender, EventArgs e)
        {
            button16.BackColor = Color.FromArgb(192, 0, 192);
        }

        private void button16_MouseLeave(object sender, EventArgs e)
        {
            button16.BackColor = Color.Purple;
        }
    }
}
