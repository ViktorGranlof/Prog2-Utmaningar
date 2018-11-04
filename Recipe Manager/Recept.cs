/*
 *Created by Viktor Granlöf
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe_Manager
{
    public class Recept
    {
        private string name;
        private string ingredients;    //Gör variabler av typerna string som ska ta in namn, ingrediens och instruktioner
        private string instructions;

        public string Name { get => name; set => name = value; }
        public string Ingredients { get => ingredients; set => ingredients = value; }     // Man får mer kontroll över hur variablerna kan användas, tex kan man 
        public string Instructions { get => instructions; set => instructions = value; }  // ta bort set metoden för att göra dem "read-only".
    }


}
