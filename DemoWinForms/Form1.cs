using Oefening01;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoWinForms
{
    public partial class Form1 : Form
    {
        Greeter greeter = new Greeter();

        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            string who = textBox1.Text;
            string greeting = greeter.Greet(who);
            label2.Text = greeting;
        }
    }
}
