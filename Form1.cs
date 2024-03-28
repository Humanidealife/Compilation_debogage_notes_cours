using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compilation_debogage_notes_cours
{
    public partial class Form1 : Form
    {
        int x = 0;
        int y = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Test du bouton 2");
            //Methode1();
            /*y = x + 1;
            x++;*/
            for (int i = 0; i <10; i++)
            {
                x++;
                y = x * i;
            }
        }

        /*void Methode1()
        {
            Methode2();
        }

        void Methode2()
        {
            Methode3();
        }

        void Methode3()
        {
            //lever une exception
            throw new Exception("Une erreur");
        }*/
    }
}
