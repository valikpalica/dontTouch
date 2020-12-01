using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BogdanaKursach
{
    public partial class Form2 : Form
    {
        string[] array;
        public Form2()
        {
            InitializeComponent();
            SortArray();
        }
        public void SortArray() {
            array = Table.array.ToArray();
            string index = "";
            for(int i = 0; i < array.Length - 1; i++)
            {
                for(int j = i + 1; j < array.Length; j++)
                {
                    if (int.Parse(array[i].Split(' ')[2]) > int.Parse(array[j].Split(' ')[2]))
                    {
                        index = array[i];
                        array[i] = array[j];
                        array[j] = index;   
                    }
                }
            }
            GenerateTable();
        }
        public void GenerateTable() {
            foreach (var item in array)
            {
                dataGridView1.Rows.Add(item.Split(' ')[2], item.Split(' ')[3]);
            }
        }
    }
}
