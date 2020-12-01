using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace BogdanaKursach
{
 
    public  partial class Form1 : Form
    {
   
        public  string[] array = new string[] { 
        "1 27 271 20",
        "2 27 272 18",
        "3 20 203 30",
        "4 20 204 28",
        "5 25 201 15",
        };
        public Form1()
        {
            InitializeComponent();
            GenerateList();
        }
       
        public  void GenerateList() {
            GenerateTable(array);
        }
        public  void GenerateTable (string [] array)
        {
            foreach (var item in array)
            {
                dataGridView1.Rows.Add(item.Split(' ')[0], item.Split(' ')[1], item.Split(' ')[2], item.Split(' ')[3]);
            }
        }
        private void serdPunktToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int count_kadet = 0;
            foreach (var item in array)
            {
                count_kadet += int.Parse(item.Split(' ')[3]);
            }
            MessageBox.Show($"Загальна кількість груп{array.Length.ToString()} Загальна кількість курсантів {count_kadet}");
        }
        private void label1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show(label1.Text);

        }
        private void fourthPunktToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int counter = 0;
            string content = Interaction.InputBox("Оберіть курс","Курс","",200,300);
            foreach (var item in array)
            {
                if(content.Trim().Equals(item.Split(' ')[1]))
                {
                    counter++;
                }
            }
            if (counter != 0)
            {
                MessageBox.Show($"{counter.ToString()} кількість груп на курсі");
            }
            else
            {
                MessageBox.Show("Не вірний формат даних");
            }
        }
        private void secondPunktToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int counter = 0;
            string content = Interaction.InputBox("Вибері курс", "Курс", "", 200, 300);
            foreach (var item in array)
            {
                if(content.Trim().Equals(item.Split(' ')[1]))
                {
                    counter+=int.Parse(item.Split(' ')[3]);
                }
            }
            if (counter != 0)
            {
                MessageBox.Show($"{counter.ToString()} Кількість курсантів на курсі");
            }
            else
            {
                MessageBox.Show("Не вірний формат даних");
            }
        }

        private void firstPunktToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Table.array = array;
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string content = Interaction.InputBox("Виберіть id", "Видалення", "", 200, 300);
            for(int i = 0; i < array.Length; i++)
            {
                if (content.Equals(array[i].Split(' ')[0]))
                {
                    Remove(array[i],i);
                }
            }
            RefreshTable();
        }
        public  void RefreshTable() {
            this.dataGridView1.Rows.Clear();
            Sort();
            GenerateTable(array);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = Interaction.InputBox("Новий id", "Додавання id", "", 200, 300);
            string kurs = Interaction.InputBox("Новий курсу", "Додавання курсу", "", 200, 300);
            string group = Interaction.InputBox("Нова група", "Додавання групу", "", 200, 300);
            string count = Interaction.InputBox("Кількість", "Кількість", "", 200, 300);
            string result = $"{id.Trim()} {kurs.Trim()} {group.Trim()} {count.Trim()}";
            AddInArray(result);
        }
        public void AddInArray(string input) {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = input;
            RefreshTable();
        }
        public void Remove(string input,int index)
        {
            string last = array[array.Length - 1];
            array[array.Length - 1] = input;
            array[index] = last;
            Array.Resize(ref array, array.Length - 1);
            RefreshTable();
        }
        public void Sort() {

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (int.Parse(array[i].Split(' ')[0]) > int.Parse(array[j].Split(' ')[0]))
                    {
                        string temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;

                    }
                }
            }        
        }
    }
}
