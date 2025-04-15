using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reformix
{
    public partial class TelaTinta : Form
    {
        public TelaTinta()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double area = double.Parse(txtAreaParede.Text);
                int demaos = int.Parse(txtDemao.Text);
                double cobertura = double.Parse(txtCoberturaTinta.Text);

                double quantidadeTinta = (area * demaos) / cobertura;

                lblResultado.Text = $"Quantidade estimada de tinta: {quantidadeTinta:F2} litros";
            }

            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira valores numéricos válidos.", "Erro de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro Inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}




