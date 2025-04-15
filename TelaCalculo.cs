using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reformix
{
    public partial class TelaCalculo : Form
    {
        public TelaCalculo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double paredeAltura = double.Parse(txtParedeAltura.Text.Replace(",", "."), CultureInfo.InvariantCulture);
                double paredeLargura = double.Parse(txtParedeLargura.Text.Replace(",", "."), CultureInfo.InvariantCulture);
                double azulejoAltura = double.Parse(txtAzulejoAltura.Text.Replace(",", "."), CultureInfo.InvariantCulture);
                double azulejoLargura = double.Parse(txtAzulejoLargura.Text.Replace(",", "."), CultureInfo.InvariantCulture);


                // Calcular área da parede
                double areaParede = paredeLargura * paredeAltura;


                // Calcular área de um azulejo
                double areaAzulejo = azulejoLargura * azulejoAltura;

                if (areaAzulejo <= 0)
                {
                    MessageBox.Show("As dimensões do azulejo devem ser maiores que zero.");
                    return;
                }

                // Calcular quantidade necessária (com 10% de folga)
                double quantidade = areaParede / areaAzulejo;
                int quantidadeFinal = (int)Math.Ceiling(quantidade * 1.1);

                // Exibir resultado
                lblResult.Text = $"Área da parede: {areaParede:F2} m²\n" +
                                 $"Azulejos necessários (com 10% extra): {quantidadeFinal}";

            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira apenas números válidos.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
    }
}
        
    

