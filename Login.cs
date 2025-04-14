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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (textUsuario.Text.Equals("Aline") && textSenha.Text.Equals("123"))
                {
                    // Seguir login para área restrita do app.
                }
                else
                {
                    MessageBox.Show("Error - HTTP 401",
                        "Usuário e senha incorretos",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Desculpe",
                        ex.Message,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

            }
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            // funcionalidade tela cadastrar
        }
    }
}
