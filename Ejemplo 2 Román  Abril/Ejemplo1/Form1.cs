using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace Ejemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            //Thread.Sleep(5000);
            
            gif.Visible = true;
            //await Task.Delay(5000);
            await Esperar();
            MessageBox.Show("Terminó la suspensión de 5 segundos");
            gif.Visible = false;
        }
        private async Task Esperar()
        { 
            await Task.Delay(5000);
        }

    }
}
