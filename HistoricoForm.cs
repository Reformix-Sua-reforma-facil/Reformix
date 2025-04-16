using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Reformix
{
    internal class HistoricoForm : Form
    {
        private ListBox listBoxHistorico;

        public HistoricoForm()
        {
            
        }

        private void InitializeComponent()
        {
            this.listBoxHistorico = new ListBox();
            this.SuspendLayout();
            // 
            // listBoxHistorico
            // 
            this.listBoxHistorico.FormattingEnabled = true;
            this.listBoxHistorico.Location = new System.Drawing.Point(12, 12);
            this.listBoxHistorico.Name = "listBoxHistorico";
            this.listBoxHistorico.Size = new System.Drawing.Size(360, 238);
            this.listBoxHistorico.TabIndex = 0;
            // 
            // HistoricoForm
            // 
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.listBoxHistorico);
            this.Name = "HistoricoForm";
            this.Text = "Histórico";
            this.ResumeLayout(false);
        }

        internal void CarregarHistorico(List<HistoricoItem> historico)
        {
            listBoxHistorico.Items.Clear();
            foreach (var item in historico)
            {
                listBoxHistorico.Items.Add($"{item.DataHora}: {item.Usuario} - {item.Acao}");
            }
        }

#pragma warning disable CS0108 // O membro oculta o membro herdado; nova palavra-chave ausente
        internal void ShowDialog()
#pragma warning restore CS0108 // O membro oculta o membro herdado; nova palavra-chave ausente
        {
            base.ShowDialog();
        }
    }
}
