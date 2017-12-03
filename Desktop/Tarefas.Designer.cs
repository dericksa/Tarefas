namespace Desktop
{
    partial class Tarefas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.control_tarefas = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_ExcluirPendente = new MaterialSkin.Controls.MaterialFlatButton();
            this.btn_Marcar = new MaterialSkin.Controls.MaterialFlatButton();
            this.txt_Fazer = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.data_Pendentes = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_ExcluirFinalizada = new MaterialSkin.Controls.MaterialFlatButton();
            this.data_Finalizadas = new System.Windows.Forms.DataGridView();
            this.tarefaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaTarefasDataSet = new Desktop.ListaTarefasDataSet();
            this.tab_Tarefas = new MaterialSkin.Controls.MaterialTabSelector();
            this.tarefaTableAdapter = new Desktop.ListaTarefasDataSetTableAdapters.TarefaTableAdapter();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarefa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IdFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TarefaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckFin = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.control_tarefas.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_Pendentes)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_Finalizadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarefaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaTarefasDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // control_tarefas
            // 
            this.control_tarefas.Controls.Add(this.tabPage1);
            this.control_tarefas.Controls.Add(this.tabPage2);
            this.control_tarefas.Depth = 0;
            this.control_tarefas.Location = new System.Drawing.Point(-3, 83);
            this.control_tarefas.MouseState = MaterialSkin.MouseState.HOVER;
            this.control_tarefas.Name = "control_tarefas";
            this.control_tarefas.SelectedIndex = 0;
            this.control_tarefas.Size = new System.Drawing.Size(291, 424);
            this.control_tarefas.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.btn_ExcluirPendente);
            this.tabPage1.Controls.Add(this.btn_Marcar);
            this.tabPage1.Controls.Add(this.txt_Fazer);
            this.tabPage1.Controls.Add(this.data_Pendentes);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(283, 398);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pendentes";
            // 
            // btn_ExcluirPendente
            // 
            this.btn_ExcluirPendente.AutoSize = true;
            this.btn_ExcluirPendente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_ExcluirPendente.Depth = 0;
            this.btn_ExcluirPendente.Location = new System.Drawing.Point(195, 302);
            this.btn_ExcluirPendente.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_ExcluirPendente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_ExcluirPendente.Name = "btn_ExcluirPendente";
            this.btn_ExcluirPendente.Primary = false;
            this.btn_ExcluirPendente.Size = new System.Drawing.Size(66, 36);
            this.btn_ExcluirPendente.TabIndex = 3;
            this.btn_ExcluirPendente.Text = "Excluir";
            this.btn_ExcluirPendente.UseVisualStyleBackColor = true;
            this.btn_ExcluirPendente.Click += new System.EventHandler(this.btn_ExcluirPendente_Click);
            // 
            // btn_Marcar
            // 
            this.btn_Marcar.AutoSize = true;
            this.btn_Marcar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Marcar.Depth = 0;
            this.btn_Marcar.Location = new System.Drawing.Point(195, 350);
            this.btn_Marcar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Marcar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Marcar.Name = "btn_Marcar";
            this.btn_Marcar.Primary = false;
            this.btn_Marcar.Size = new System.Drawing.Size(68, 36);
            this.btn_Marcar.TabIndex = 2;
            this.btn_Marcar.Text = "Marcar";
            this.btn_Marcar.UseVisualStyleBackColor = true;
            this.btn_Marcar.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // txt_Fazer
            // 
            this.txt_Fazer.Depth = 0;
            this.txt_Fazer.Hint = "Eu tenho que ...";
            this.txt_Fazer.Location = new System.Drawing.Point(11, 350);
            this.txt_Fazer.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_Fazer.Name = "txt_Fazer";
            this.txt_Fazer.PasswordChar = '\0';
            this.txt_Fazer.SelectedText = "";
            this.txt_Fazer.SelectionLength = 0;
            this.txt_Fazer.SelectionStart = 0;
            this.txt_Fazer.Size = new System.Drawing.Size(166, 23);
            this.txt_Fazer.TabIndex = 1;
            this.txt_Fazer.UseSystemPasswordChar = false;
            // 
            // data_Pendentes
            // 
            this.data_Pendentes.AllowUserToAddRows = false;
            this.data_Pendentes.AllowUserToDeleteRows = false;
            this.data_Pendentes.AllowUserToResizeColumns = false;
            this.data_Pendentes.AllowUserToResizeRows = false;
            this.data_Pendentes.AutoGenerateColumns = false;
            this.data_Pendentes.BackgroundColor = System.Drawing.SystemColors.Window;
            this.data_Pendentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Pendentes.ColumnHeadersVisible = false;
            this.data_Pendentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Tarefa,
            this.Check});
            this.data_Pendentes.DataSource = this.tarefaBindingSource;
            this.data_Pendentes.Location = new System.Drawing.Point(12, 15);
            this.data_Pendentes.Name = "data_Pendentes";
            this.data_Pendentes.ReadOnly = true;
            this.data_Pendentes.RowHeadersVisible = false;
            this.data_Pendentes.Size = new System.Drawing.Size(254, 278);
            this.data_Pendentes.TabIndex = 0;
            this.data_Pendentes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.btn_ExcluirFinalizada);
            this.tabPage2.Controls.Add(this.data_Finalizadas);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(283, 398);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Finalizadas";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btn_ExcluirFinalizada
            // 
            this.btn_ExcluirFinalizada.AutoSize = true;
            this.btn_ExcluirFinalizada.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_ExcluirFinalizada.Depth = 0;
            this.btn_ExcluirFinalizada.Location = new System.Drawing.Point(195, 302);
            this.btn_ExcluirFinalizada.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_ExcluirFinalizada.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_ExcluirFinalizada.Name = "btn_ExcluirFinalizada";
            this.btn_ExcluirFinalizada.Primary = false;
            this.btn_ExcluirFinalizada.Size = new System.Drawing.Size(66, 36);
            this.btn_ExcluirFinalizada.TabIndex = 4;
            this.btn_ExcluirFinalizada.Text = "Excluir";
            this.btn_ExcluirFinalizada.UseVisualStyleBackColor = true;
            this.btn_ExcluirFinalizada.Click += new System.EventHandler(this.btn_ExcluirFinalizada_Click);
            // 
            // data_Finalizadas
            // 
            this.data_Finalizadas.AllowUserToAddRows = false;
            this.data_Finalizadas.AllowUserToDeleteRows = false;
            this.data_Finalizadas.AllowUserToResizeColumns = false;
            this.data_Finalizadas.AllowUserToResizeRows = false;
            this.data_Finalizadas.AutoGenerateColumns = false;
            this.data_Finalizadas.BackgroundColor = System.Drawing.SystemColors.Window;
            this.data_Finalizadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Finalizadas.ColumnHeadersVisible = false;
            this.data_Finalizadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdFin,
            this.TarefaFin,
            this.CheckFin});
            this.data_Finalizadas.DataSource = this.tarefaBindingSource;
            this.data_Finalizadas.Location = new System.Drawing.Point(12, 15);
            this.data_Finalizadas.MultiSelect = false;
            this.data_Finalizadas.Name = "data_Finalizadas";
            this.data_Finalizadas.ReadOnly = true;
            this.data_Finalizadas.RowHeadersVisible = false;
            this.data_Finalizadas.Size = new System.Drawing.Size(254, 278);
            this.data_Finalizadas.TabIndex = 1;
            this.data_Finalizadas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // tarefaBindingSource
            // 
            this.tarefaBindingSource.DataMember = "Tarefa";
            this.tarefaBindingSource.DataSource = this.listaTarefasDataSet;
            // 
            // listaTarefasDataSet
            // 
            this.listaTarefasDataSet.DataSetName = "ListaTarefasDataSet";
            this.listaTarefasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tab_Tarefas
            // 
            this.tab_Tarefas.BaseTabControl = this.control_tarefas;
            this.tab_Tarefas.Depth = 0;
            this.tab_Tarefas.Location = new System.Drawing.Point(-3, 63);
            this.tab_Tarefas.MouseState = MaterialSkin.MouseState.HOVER;
            this.tab_Tarefas.Name = "tab_Tarefas";
            this.tab_Tarefas.Size = new System.Drawing.Size(291, 23);
            this.tab_Tarefas.TabIndex = 1;
            this.tab_Tarefas.Text = "materialTabSelector1";
            this.tab_Tarefas.Click += new System.EventHandler(this.tab_Tarefas_Click);
            // 
            // tarefaTableAdapter
            // 
            this.tarefaTableAdapter.ClearBeforeFill = true;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Tarefa
            // 
            this.Tarefa.DataPropertyName = "Titulo";
            this.Tarefa.HeaderText = "Tarefa";
            this.Tarefa.Name = "Tarefa";
            this.Tarefa.ReadOnly = true;
            this.Tarefa.Width = 200;
            // 
            // Check
            // 
            this.Check.DataPropertyName = "Finalizada";
            this.Check.HeaderText = "Check";
            this.Check.Name = "Check";
            this.Check.ReadOnly = true;
            this.Check.Width = 50;
            // 
            // IdFin
            // 
            this.IdFin.DataPropertyName = "Id";
            this.IdFin.HeaderText = "Id";
            this.IdFin.Name = "IdFin";
            this.IdFin.ReadOnly = true;
            this.IdFin.Visible = false;
            // 
            // TarefaFin
            // 
            this.TarefaFin.DataPropertyName = "Titulo";
            this.TarefaFin.HeaderText = "Tarefa";
            this.TarefaFin.Name = "TarefaFin";
            this.TarefaFin.ReadOnly = true;
            this.TarefaFin.Width = 200;
            // 
            // CheckFin
            // 
            this.CheckFin.DataPropertyName = "Finalizada";
            this.CheckFin.HeaderText = "Check";
            this.CheckFin.Name = "CheckFin";
            this.CheckFin.ReadOnly = true;
            this.CheckFin.Width = 50;
            // 
            // Tarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 505);
            this.Controls.Add(this.tab_Tarefas);
            this.Controls.Add(this.control_tarefas);
            this.Name = "Tarefas";
            this.Text = "Tarefas";
            this.Load += new System.EventHandler(this.Tarefas_Load);
            this.control_tarefas.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_Pendentes)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_Finalizadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarefaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaTarefasDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl control_tarefas;
        private System.Windows.Forms.TabPage tabPage1;
        private MaterialSkin.Controls.MaterialTabSelector tab_Tarefas;
        private System.Windows.Forms.DataGridView data_Pendentes;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialFlatButton btn_Marcar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_Fazer;
        private System.Windows.Forms.DataGridView data_Finalizadas;
        private MaterialSkin.Controls.MaterialFlatButton btn_ExcluirPendente;
        private MaterialSkin.Controls.MaterialFlatButton btn_ExcluirFinalizada;
        private ListaTarefasDataSet listaTarefasDataSet;
        private System.Windows.Forms.BindingSource tarefaBindingSource;
        private ListaTarefasDataSetTableAdapters.TarefaTableAdapter tarefaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarefa;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Check;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn TarefaFin;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckFin;
    }
}