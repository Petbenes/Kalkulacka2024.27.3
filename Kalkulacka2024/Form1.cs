using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulacka2024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // -----------------------------------------
        // Vypisuje stisknutá tlačítka na display
        // -----------------------------------------
        private void btTlacitko0_Click(object sender, EventArgs e)
        {
            Button lbtMojeTlacitko;

            lbtMojeTlacitko = (Button)sender;

            // test zda tam není samotná nula
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "";
            }

            // vypsat číslo na display
            txtDisplay.Text = txtDisplay.Text + lbtMojeTlacitko.Text;
        }

        // -----------------------------------------
        // Vymazat vše na kalkulačce
        // -----------------------------------------
        private void btSmazat_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }
    }
}
