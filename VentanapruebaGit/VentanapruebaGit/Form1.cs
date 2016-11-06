using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VentanasFintech;

namespace VentanapruebaGit
{
    /*Probando el Commit *__*
     * 
     *  */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ACEPTAR *__*");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("NUEVO FORM *~*");
            Form2 obj = new Form2();
            obj.ShowDialog();
        }
    }
}
