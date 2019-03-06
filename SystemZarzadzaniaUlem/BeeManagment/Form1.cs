using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeeManagment
{
    public partial class Form1 : Form
    {
        private Queen queen;
        public Form1()
        {

            InitializeComponent();

            CreateClass();
        }

        public void CreateClass()
        {
            
            workerBeeJob.SelectedIndex = 0;
            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new string[] { "Zbieranie nektaru", "Wytwarzanie miodu" }, .175);
            workers[1] = new Worker(new string[] { "Pielęgnacja jaj", "Nauczanie pszczółek" }, .114);
            workers[2] = new Worker(new string[] { "Utrzymanie ula", "Patrol z żądłami" }, .149);
            workers[3] = new Worker(new string[] { "Zbieranie nektaru", "Wytwarzanie miodu", "Pielęgnacja jaj", "Nauczanie pszczółek", "Utrzymanie ula", "Patrol z żądłami" }, 155);
            queen = new Queen(workers,275);
        }

        private void setJob_Click(object sender, EventArgs e)
        {
            if (queen.AssignWork(workerBeeJob.Text, (int)numericUpDown1.Value) == true)
            {
                MessageBox.Show("Pszczoła bedzie zajmowac sie " + workerBeeJob.Text + " przez " + numericUpDown1.Value + "zmiany");
            }
            else
                MessageBox.Show("Pszczola nie moze sie tym zajac");
        }

        private void button1_Click(object sender, EventArgs e)
        {
           textBox1.Text = queen.WorkTheNextShift();
        }
    }
}
