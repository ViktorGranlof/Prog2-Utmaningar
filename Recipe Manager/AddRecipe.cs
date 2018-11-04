/*
 *Created by Viktor Granlöf
 */

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
    public partial class AddRecipe : Form
    {
        public Recept recept; //Deklarerar klassen

        public AddRecipe()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            recept = new Recept();  //Anropar klassen Recept
            recept.Name = txtRecipe.Text; //Sätter recept.name till det som skriv in i textrutan txtRecipe
            recept.Ingredients = txtIngred.Text; //Sätter recept.ingredients till det som skriv in i textutan txtIngred 
            recept.Instructions = txtInstruct.Text; //Sätter recept.instructions till det som skrivs in i textrutan txtInstruct
        }

        private void txtRecipe_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIngred_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtInstruct_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCan_Click(object sender, EventArgs e)
        {
        }
    }
}
