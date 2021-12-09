using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyUtilities_project
{
    public partial class MainForm : Form
    {
        int count = 0;
        Random random = new Random();
        public MainForm()
        {
            InitializeComponent();
        }

        private void ToolStripMenuItem_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToolStripMenuItem_About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Програмульки. \n  Автор: Я!", "О программе.");
        }

        private void button_Plus_Click(object sender, EventArgs e)
        {
            count++;
            label_Counter.Text = count.ToString();
        }

        private void button_Minus_Click(object sender, EventArgs e)
        {
            count--;
            label_Counter.Text = count.ToString();
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            count = 0;
            label_Counter.Text = count.ToString();
        }

        private void button_Random_Click(object sender, EventArgs e)
        {
            int n;
            n = random.Next(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value) + 1);
            label_Random.Text = n.ToString();

            if (checkBox_Random.Checked)
            {
                if (textBox_Random.Text.IndexOf(label_Random.Text) < 0) {
                    textBox_Random.AppendText(label_Random.Text + "\r\n");
                }
            }
            else
            {
                textBox_Random.AppendText(label_Random.Text + "\r\n");
            }
        }

        private void button_Random_clear_Click(object sender, EventArgs e)
        {
            textBox_Random.Clear();
        }

        private void button_Random_copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox_Random.Text);
        }

        private void ToolStripMenuItem_Add_date_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText(DateTime.Now.ToShortDateString() + " ");
        }

        private void ToolStripMenuItem_Add_time_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText(DateTime.Now.ToShortTimeString() + " ");
        }
        void saveNote()
        {
            try
            {
                richTextBox1.SaveFile("note1.txt");
            }
            catch
            {
                MessageBox.Show("Ошибка при записи.");
            }
        }
        private void ToolStripMenuItem_Save_Click(object sender, EventArgs e)
        {
            saveNote();
        }
        void loadNote()
        {
            {
                try
                {
                    richTextBox1.LoadFile("note1.txt");
                }
                catch
                {
                    MessageBox.Show("Ошибка загрузки");
                }
            }
        }
        private void ToolStripMenuItem_Load_Click(object sender, EventArgs e)
        {
            loadNote();
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            loadNote();
        }

        private void tabControl1_Deselected(object sender, TabControlEventArgs e)
        {
            saveNote();
        }

        private void button_Pass_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count == 0) return;

            string pass = "";


            while (pass.Length <= numeric_Lenght_pass.Value)
            {
                int check = random.Next(0, checkedListBox1.CheckedItems.Count);
                switch (Convert.ToString(checkedListBox1.CheckedItems[check]))
                {
                    case "Цифры": pass += random.Next(10).ToString(); break;
                    case "Прописные буквы": pass += Convert.ToChar(random.Next(65, 88)); break;
                    case "Строчные буквы": pass += Convert.ToChar(random.Next(97, 122)); break;
                    case "Символы":
                        if (textBox_Spec_char.Text.Length > 0)
                        {
                            int char_rnd = random.Next(0, textBox_Spec_char.Text.Length);
                            pass += textBox_Spec_char.Text[char_rnd];
                        }
                        break;
                }
            }
            textBox_Pass.Text = pass;
            Clipboard.SetText(pass);
        }
    }
}
