using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meds {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            Console.WriteLine("Button 1 clicked");
        }

        private void button2_Click(object sender, EventArgs e) {
            Console.WriteLine("Ei ");
        }

        private void button_textPanel_Click(object sender, EventArgs e) {
            Console.WriteLine(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e) {
            for (int i = 0; true; i++) {
                Console.Write(i + " Ayayay ");
                if (i == 10000) {
                    break;
                }
            }
        }
    }
}
