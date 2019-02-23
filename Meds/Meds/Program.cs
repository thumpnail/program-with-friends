using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Ini.Net;
using Meds;
using System.Windows.Forms;

namespace Meds {
    class Program {
        static void Main(string[] args) {
            Console.Title = "Medicine";
            Application.EnableVisualStyles();
            Application.Run(new MainForm());
        }
    }
    
    class Medicine {
        private string name; //name der medezin... eine zeichenfolge immer mit ""
        private bool used; //true / false
        private double strenght; //bis 100 quasi prozent
        private string[] translation = {"", "", "", ""};

        public Medicine() {
            Console.WriteLine("Objekt ohne parameter");
        }

        public Medicine(string name, bool used, double strenght) {
            this.name = name;
            this.used = used;
            this.strenght = strenght;
            Console.WriteLine("Name: " + name);
            if (!used) {
                Console.WriteLine("Benutz: " + "nein");
            } else {
                Console.WriteLine("Benutz: " + "ja");
            }
            Console.WriteLine("Straerke: " + strenght + "%");
            Console.WriteLine();
        }

        public void UseMedicine() {
            int tmp = 6;
            int tmp2 = 6;
            //--------------------------------------------------------------------------------------------------------
            if (tmp <= tmp2 && tmp > 3 || tmp == 12) {
                Console.WriteLine();
            } else {
                Console.WriteLine();
            }
            //--------------------------------------------------------------------------------------------------------
            if (used) {
                Console.WriteLine(name + " already used!");
            } else {
                Console.WriteLine("Iam using " + name + " now");
                used = true;
            }
            //---------------------------------------------------------------------------------------------------------
            for (int i = 0; i < translation.Length; i++) {
                translation[i] = "test " + (i + 1);
            }
        }
    }
}
