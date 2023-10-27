namespace DesktopApp
{
    partial class Form1
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
            dataGridView1 = new DataGridView();
            Funcionario = new DataGridViewTextBoxColumn();
            Periodo = new DataGridViewTextBoxColumn();
            DataLimite = new DataGridViewTextBoxColumn();
            DataAdmissao = new DataGridViewTextBoxColumn();
            Situacao = new DataGridViewTextBoxColumn();
            label1 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Funcionario, Periodo, DataLimite, DataAdmissao, Situacao });
            dataGridView1.Location = new Point(78, 116);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(644, 261);
            dataGridView1.TabIndex = 0;
            // 
            // Funcionario
            // 
            Funcionario.HeaderText = "Funcionário";
            Funcionario.Name = "Funcionario";
            Funcionario.ReadOnly = true;
            Funcionario.Width = 200;
            // 
            // Periodo
            // 
            Periodo.HeaderText = "Período";
            Periodo.Name = "Periodo";
            Periodo.ReadOnly = true;
            Periodo.Width = 80;
            // 
            // DataLimite
            // 
            DataLimite.HeaderText = "Data Limite";
            DataLimite.Name = "DataLimite";
            DataLimite.ReadOnly = true;
            DataLimite.Width = 120;
            // 
            // DataAdmissao
            // 
            DataAdmissao.HeaderText = "Data de Admissão";
            DataAdmissao.Name = "DataAdmissao";
            DataAdmissao.ReadOnly = true;
            DataAdmissao.Width = 120;
            // 
            // Situacao
            // 
            Situacao.HeaderText = "Situação";
            Situacao.Name = "Situacao";
            Situacao.ReadOnly = true;
            Situacao.Width = 80;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(254, 24);
            label1.Name = "label1";
            label1.Size = new Size(290, 37);
            label1.TabIndex = 1;
            label1.Text = "Solicitações de Férias";
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(690, 397);
            button2.Name = "button2";
            button2.Size = new Size(98, 41);
            button2.TabIndex = 25;
            button2.Text = "VOLTAR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Solicitações";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button button2;
        private DataGridViewTextBoxColumn Funcionario;
        private DataGridViewTextBoxColumn Periodo;
        private DataGridViewTextBoxColumn DataLimite;
        private DataGridViewTextBoxColumn DataAdmissao;
        private DataGridViewTextBoxColumn Situacao;
    }
}