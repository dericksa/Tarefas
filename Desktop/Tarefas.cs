using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin.Animations;
using MaterialSkin;
using Desktop.Controllers;

namespace Desktop
{
    public partial class Tarefas : MaterialForm
    {
        public Tarefas()
        {
            InitializeComponent();
            handle_Pendentes();
            handle_Finalizadas();
        }

        private void Tarefas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'listaTarefasDataSet.Tarefa'. Você pode movê-la ou removê-la conforme necessário.
            this.tarefaTableAdapter.Fill(this.listaTarefasDataSet.Tarefa);
            MaterialSkinManager skin = MaterialSkinManager.Instance;
            skin.AddFormToManage(this);
            skin.Theme = MaterialSkinManager.Themes.LIGHT;
            SkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Cyan800, MaterialSkin.Primary.Cyan800, MaterialSkin.Primary.Amber300, MaterialSkin.Accent.Amber700, MaterialSkin.TextShade.BLACK);
        }

        private void handle_Pendentes()
        {
            BindingSource bind = new BindingSource();

            bind.DataSource = TarefaController.Listar_Pendentes().ToList();
            data_Pendentes.DataSource = bind;
            data_Pendentes.Refresh();
        }

        private void handle_Finalizadas()
        {
            BindingSource bind = new BindingSource();

            bind.DataSource = TarefaController.Listar_Finalizadas().ToList();
            data_Finalizadas.DataSource = bind;
            data_Finalizadas.Refresh();
        }

        private void Pendentes_Box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_ExcluirPendente.Visible = true;

            if (data_Pendentes.Columns[e.ColumnIndex].Name == "Check")
            {
                int id_tarefa = int.Parse(data_Pendentes.CurrentRow.Cells[0].Value.ToString());
                if(id_tarefa > 0)
                    TarefaController.Finalizar_Tarefa(id_tarefa);
                handle_Pendentes();
                handle_Finalizadas();
            }
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            TarefaController.Criar_Tarefa(txt_Fazer.Text);
            handle_Pendentes();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
 

            if (data_Finalizadas.Columns[e.ColumnIndex].Name == "CheckFin")
            {
                int id_tarefa = int.Parse(data_Finalizadas.CurrentRow.Cells[0].Value.ToString());
                TarefaController.Desfazer_Finalizar(id_tarefa);
                handle_Pendentes();
                handle_Finalizadas();
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tab_Tarefas_Click(object sender, EventArgs e)
        {

        }

        private void btn_ExcluirPendente_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Você tem certeza que deseja excluir?", "Confirmar", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes && data_Pendentes.Rows.Count > 0)
            {
                int id_tarefa = int.Parse(data_Pendentes.CurrentRow.Cells[0].Value.ToString());
                if (id_tarefa > 0)
                    TarefaController.Remover_Tarefa(id_tarefa);
                handle_Pendentes();
            }
        }

        private void btn_ExcluirFinalizada_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Você tem certeza que deseja excluir?", "Confirmar", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes && data_Finalizadas.Rows.Count > 0)
            {
                int id_tarefa = int.Parse(data_Finalizadas.CurrentRow.Cells[0].Value.ToString());
                if (id_tarefa > 0)
                    TarefaController.Remover_Tarefa(id_tarefa);
                handle_Finalizadas();
            }
        }
    }
}
