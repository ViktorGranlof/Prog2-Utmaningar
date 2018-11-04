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
    public partial class Form1 : Form
    {
        private List<Recept> receptList = new List<Recept>(); //Instansierar recept listan

        public Form1() 
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddRecipe add = new AddRecipe();         //Anropar AddRecipe
            DialogResult result = add.ShowDialog();  //Om dialogenrutan har fyllts i på rätt sätt (om den inte stängts ned)

            if (result == DialogResult.OK) //OK returneras när användaren skrivits in, är result = OK körs detta 
            {
                receptList.Add(add.recept); //Lägger till personen
            }
            updateRecipeList();
        }

        private void updateRecipeList() //Uppdaterar listan med recepten i
        {
            lbxMain.Items.Clear(); //Rensar så att listan endast skriver ut det man vill 1 gång
 
            foreach (Recept r in receptList) //För varje Recept i recetList
            {
                lbxMain.Items.Add(r.Name); //Lägger till recepten i receptList listan
            }

            lbxMain.Refresh();
        }

        private void btnRem_Click(object sender, EventArgs e)
        {
            int index = lbxMain.SelectedIndex; //Sätter indexet till det användarvalda indexet
            if (index < 0) //Om indexet är mindre än noll vilket betyder att inget valts körs detta
            {
                return; //Returnerar, vilket förhindrar programmet från att krascha
            }
            receptList.RemoveAt(index); //Tar bort receptet i det index som valts
            updateRecipeList();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            int index = lbxMain.SelectedIndex; //Sätter int index till det användarvalda indexet i listBox

            if (index < 0) //Om indexet är mindre än noll så returnera if satsen,
            {              //detta görs för att programmet inte ska krascha när inget ligger i listbox
                return;
            }
            Recept r = receptList[index]; //Recepet

            ShowRecipe show = new ShowRecipe(r.Name, r.Ingredients, r.Instructions); //Anropar Showrecipe och skickar in namn, ingrediener och instruktioner
            show.ShowDialog(); //Visar fönstret
        }
    }
}
