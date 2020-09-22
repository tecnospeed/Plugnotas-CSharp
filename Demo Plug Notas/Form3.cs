using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_Plug_Notas
{
    public partial class Form3 : Form
    {
        public Form3(string parametro)
        {

            InitializeComponent();
            webBrowser1.Navigate(string.Format(parametro, Application.StartupPath));
         
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void clickButtonPrint_Click(object sender, EventArgs e)
        {

        

        }

     
    }
}
