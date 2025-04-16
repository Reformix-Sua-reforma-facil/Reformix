using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reformix
{
    public partial class Telahistorico : Form
    {
        private readonly ListView listView1;

        public Telahistorico()
        {
            InitializeComponent();
            listView1 = new ListView();
        }

        public void CarregarHistorico(List<HistoricoItem> lista)
        {
            listView1.Items.Clear();

            foreach (var item in lista)
            {
                var linha = new ListViewItem(item.DataHora.ToString("dd/MM/yyyy HH:mm"));
                linha.SubItems.Add(item.Usuario);
                linha.SubItems.Add(item.Acao);

                listView1.Items.Add(linha);
            }

        }
        private void Telahistorico_Load(object sender, EventArgs e)
        {
            List<Historico> lista = new List<Historico>
    {
        new Historico { Data = DateTime.Now.AddMinutes(-10), Usuario = "Renata", Acao = "Entrou no sistema" },
        new Historico { Data = DateTime.Now.AddMinutes(-5), Usuario = "Renata", Acao = "Consultou relatório" },
        new Historico { Data = DateTime.Now, Usuario = "Renata", Acao = "Fechou o sistema" }
    };

            dataGridView1.DataSource = lista;

            // Configurações visuais
            dataGridView1.ReadOnly = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        // Classe auxiliar representando cada item do histórico
        public class Historico
        {
            public DateTime Data { get; set; }
            public string Usuario { get; set; }
            public string Acao
            {
                get; set;

            }
        }

        private void btnVerHistorico_Click(object sender, EventArgs e)
        {
            var historico = new List<HistoricoItem>
    {
        new HistoricoItem { DataHora = DateTime.Now.AddMinutes(-10), Usuario = "Admin", Acao = "Login realizado" },
        new HistoricoItem { DataHora = DateTime.Now.AddMinutes(-5), Usuario = "Admin", Acao = "Cadastro de produto" },
        new HistoricoItem { DataHora = DateTime.Now, Usuario = "Admin", Acao = "Logout" }
    };

            var telaHistorico = new HistoricoForm();
            telaHistorico.CarregarHistorico(historico);
            telaHistorico.ShowDialog();
        }



    }
}
