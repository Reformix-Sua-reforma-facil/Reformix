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
    
    
        public partial class Form1 : Form
        {
            private bool notificacoesAtivadas = true;

            public Form1()
            {
            InitializeComponent();           
            InicializarComponentes();        
            CarregarConfiguracoes();         
        }

        private void InicializarComponentes()
        {
            cmbTema.Items.Clear();
            cmbTema.Items.Add("Claro");
            cmbTema.Items.Add("Escuro");

            cmbNotificacoes.Items.Clear();
            cmbNotificacoes.Items.Add("Ativado");
            cmbNotificacoes.Items.Add("Desativado");

            btnPerfil.Text = "Perfil";
            btnHistorico.Text = "Histórico";
            btnVoltar.Text = "Voltar";
            btnExcluirConta.Text = "Excluir Conta";
            btnSalvarTudo.Text = "Salvar Tudo";

            btnPerfil.Click += BtnPerfil_Click;
            btnHistorico.Click += BtnHistorico_Click;
            btnVoltar.Click += BtnVoltar_Click;
            btnExcluirConta.Click += BtnExcluirConta_Click;
            btnSalvarTudo.Click += BtnSalvarTudo_Click;
        }

        private void CarregarConfiguracoes()
        {
            string temaSalvo = Properties.Settings.Default.Tema;
            string notificacaoSalva = Properties.Settings.Default.Notificações;

            if (cmbTema.Items.Contains(temaSalvo))
            {
                cmbTema.SelectedItem = temaSalvo;
            }

            if (cmbNotificacoes.Items.Contains(notificacaoSalva))
            {
                cmbNotificacoes.SelectedItem = notificacaoSalva;
            }

            AplicarTemaVisual(temaSalvo);
        }

        private void BtnSalvarTudo_Click(object sender, EventArgs e)
        {
            string temaSelecionado = cmbTema.SelectedItem.ToString();
            string notificacoesSelecionadas = cmbNotificacoes.SelectedItem.ToString();

            Properties.Settings.Default.Tema = temaSelecionado;
            Properties.Settings.Default.Notificações = notificacoesSelecionadas;
            Properties.Settings.Default.Save();

            AplicarTemaVisual(temaSelecionado);

            MessageBox.Show($"Configurações salvas:\nTema: {temaSelecionado}\nNotificações: {notificacoesSelecionadas}");
        }

        private void AplicarTemaVisual(string tema)
        {
            if (tema == "Escuro")
            {
                this.BackColor = Color.FromArgb(30, 30, 30);
                AplicarTemaNosControles(this.Controls, Color.White, Color.FromArgb(45, 45, 45));
            }
            else // Tema Claro
            {
                this.BackColor = SystemColors.Control;
                AplicarTemaNosControles(this.Controls, SystemColors.ControlText, SystemColors.Control);
            }
        }

        private void AplicarTemaNosControles(Control.ControlCollection controles, Color foreColor, Color backColor)
        {
            foreach (Control ctrl in controles)
            {
                ctrl.ForeColor = foreColor;
                ctrl.BackColor = backColor;

                // Aplica recursivamente nos controles filhos
                if (ctrl.HasChildren)
                {
                    AplicarTemaNosControles(ctrl.Controls, foreColor, backColor);
                }
            }
        }

        private void BtnPerfil_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Abrir a seção de perfil");
        }

        private void BtnHistorico_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Abrir o histórico");
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnExcluirConta_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir sua conta?", "Excluir Conta", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show("Conta excluída com sucesso.");
            }
        }
    }
}




