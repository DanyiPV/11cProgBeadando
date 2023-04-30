using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adatátvitel
{
    public partial class Form1 : Form
    {
        static string[] headeradatok = new string[9] {"Törzsszám", "Név", "Születési idő", "Részleg", "Beosztás", "Alapbér", "Nyelv Pótlék", "Gyermek Pótlék", "Kezdő Pótlék"};
        static List<List<string>> TablaAdatok= new List<List<string>>();
        public Form1()
        {
            InitializeComponent();
            TablaElrendezes();
        }

        private void TablaElrendezes()
        {
            DG.ColumnHeadersVisible = true;
            DG.ColumnCount = 9;
            for(int i = 0; i < headeradatok.Length; i++)
            {
                DG.Columns[i].Width = 100;
                DG.Columns[i].HeaderText = headeradatok[i];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" || textBox2.Text != "" || textBox3.Text != "" || numericUpDown2.Value != 1 ||
                numericUpDown1.Value != 200000 || NyelvPotlek.Checked || GyermekPotlek.Checked || KezdoPotlek.Checked){
                textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = "";  numericUpDown2.Value = 1;
                numericUpDown1.Value = 200000;
                NyelvPotlek.Checked = false; GyermekPotlek.Checked = false; KezdoPotlek.Checked = false;
            }
            else
            {
                MessageBox.Show("Egyetlen értéken se módosított.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //DG.Rows[DG.RowCount-1].Cells[0].Value 
            List<string> lista = new List<string>();
            if(textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                lista.Add(Convert.ToString(numericUpDown2.Value));
                lista.Add(textBox1.Text);
                lista.Add(Convert.ToString(Convert.ToString(DatePick.Value).Split()[0]+ Convert.ToString(DatePick.Value).Split()[1]+ Convert.ToString(DatePick.Value).Split()[2]));
                lista.Add( textBox2.Text);
                lista.Add( textBox3.Text);
                lista.Add(Convert.ToString(numericUpDown1.Value)+"Ft");
                lista.Add( NyelvPotlek.Checked ? "Igen" : "Nem");
                lista.Add( GyermekPotlek.Checked ? "Igen" : "Nem");
                lista.Add( KezdoPotlek.Checked ? "Igen" : "Nem");
                TablaAdatok.Add(lista);
                TablaKiirat();
                textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = ""; numericUpDown2.Value = numericUpDown2.Value++;
                numericUpDown2.Minimum = numericUpDown2.Value;
                numericUpDown1.Value = 200000;
                NyelvPotlek.Checked = false; GyermekPotlek.Checked = false; KezdoPotlek.Checked = false;
            }
            else
            {
                MessageBox.Show("Nem adott meg minden értéket!");
            }
        }
        private void TablaKiirat()
        {
            DG.RowCount = TablaAdatok.Count;
            for(int i = 0; i < TablaAdatok.Count; i++)
            {
                for(int j = 0; j < TablaAdatok[i].Count; j++)
                {
                    DG.Rows[i].Cells[j].Value = TablaAdatok[i][j];
                }
            }
        }
    }
}
