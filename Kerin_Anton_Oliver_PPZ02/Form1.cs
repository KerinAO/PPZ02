using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kerin_Anton_Oliver_PPZ02
{
    public partial class Form1 : Form
    {
        List<Gazirano> listaGaziranihPica = new List<Gazirano>();
        List<Negazirano> listaNegaziranihPica = new List<Negazirano>();
        List<Alkoholno> listaAlkoholnihPica = new List<Alkoholno>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            if (rdbGazirano.Checked)
            {
                Gazirano gazirano = new Gazirano(txtNaziv.Text, cmbKolicina.Text, cmbPakiranje.Text, Convert.ToInt32(txtCijena.Text));
                
                listaGaziranihPica.Add(gazirano);
                txtNaziv.Clear();
                txtCijena.Clear();

                MessageBox.Show("Unos je uspiješan!", "Uspijeh!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }

            if (rdbNegazirano.Checked)
            {
                Negazirano negazirano = new Negazirano(txtNaziv.Text, cmbKolicina.Text, cmbPakiranje.Text, Convert.ToInt32(txtCijena.Text));

                listaNegaziranihPica.Add(negazirano);
                txtNaziv.Clear();
                txtCijena.Clear();

                MessageBox.Show("Unos je uspiješan!", "Uspijeh!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }

            if (rdbAlkoholno.Checked)
            {
                Alkoholno alkoholno = new Alkoholno(txtNaziv.Text, cmbKolicina.Text, cmbPakiranje.Text, trckPostotak.Value, Convert.ToInt32(txtCijena.Text));

                listaAlkoholnihPica.Add(alkoholno);
                txtNaziv.Clear();
                txtCijena.Clear();

                MessageBox.Show("Unos je uspiješan!", "Uspijeh!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void rdbGazirano_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbGazirano.Checked)
            {
                trckPostotak.Visible = false;
            }
        }

        private void rdbNegazirano_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbNegazirano.Checked)
            {
                trckPostotak.Visible = false;
            }
        }

        private void rdbAlkoholno_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAlkoholno.Checked)
            {
                trckPostotak.Visible = true;
            }
        }

        private void btnIspis_Click(object sender, EventArgs e)
        {
            rtbIspis.Clear();
            rtbIspis.AppendText("Gazirano piće:\n");
            foreach(Gazirano gazirano in listaGaziranihPica)
            {
                rtbIspis.AppendText(gazirano.ToString());
                rtbIspis.AppendText("\n");
            }
            rtbIspis.AppendText("Negazirano piće:\n");
            foreach (Negazirano negazirano in listaNegaziranihPica)
            {
                rtbIspis.AppendText(negazirano.ToString());
                rtbIspis.AppendText("\n");
            }
            rtbIspis.AppendText("Alkoholno piće:\n");
            foreach (Alkoholno alkoholno in listaAlkoholnihPica)
            {
                rtbIspis.AppendText(alkoholno.ToString());
                rtbIspis.AppendText("\n");
            }
        }

        private void trckPostotak_Scroll(object sender, EventArgs e)
        {
            lblPostotak.Text = Convert.ToString(trckPostotak.Value);
        }
    }
}
