using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recipe_Manager
{
    public partial class ShowRecipe : Form
    {
        public ShowRecipe(string name, string ingredient, string instruction) //Metod som skriver ut ingrediens och instruktioner
        {
            InitializeComponent();
            lblChosen.Text = name;
            txtIngred.Text = ingredient;  //Skriver ut det som användaren skrivit tidigare i txtIngred
            txtInstruct.Text = instruction; //Skriver ut det som användaren skrivit tidigare i txtInstruct
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
