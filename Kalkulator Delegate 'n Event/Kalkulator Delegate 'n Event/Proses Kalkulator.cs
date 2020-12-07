using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator_Delegate__n_Event
{
    public partial class Proses_Kalkulator : Form
    {
        public delegate void CalculatorEventHandler(double index, double a, double b);
        public event CalculatorEventHandler OnHitung;

        public Proses_Kalkulator()
            
        {
            InitializeComponent();
            cmbOperasi.Items.Add("Penjumlahan");
            cmbOperasi.Items.Add("Pengurangan");
            cmbOperasi.Items.Add("Perkalian");
            cmbOperasi.Items.Add("Pembagian");
            cmbOperasi.SelectedIndex = 0;
            cmbOperasi.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Proses_Kalkulator_Load(object sender, EventArgs e)
        {
          

        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            double NilaiA = double.Parse(txtNilaiA.Text);
            double NilaiB = double.Parse(txtNilaiB.Text);

            if (cmbOperasi.SelectedIndex==0)
            {
                OnHitung(0, NilaiA, NilaiB);
            }
            else if (cmbOperasi.SelectedIndex==1)
            {
                OnHitung(1, NilaiA, NilaiB);
            }
            else if (cmbOperasi.SelectedIndex==2)
            {
                OnHitung(2, NilaiA, NilaiB);
            }
            else 
            {
                OnHitung(3, NilaiA, NilaiB);
            }
        }
    }
}
