using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KowalskiApp.StdLibrary.Models;

namespace KowalskiApp.DesktopApp
{
    public partial class FormApp : Form
    {
        public FormApp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person person = new Person()
            {
                FirstName = "Kowalski",
                SecondName = "Jan"
            };
            this.textBox1.Text = person.ToString();
        }
    }
}
