
namespace Projeto3Camadas
{
    partial class Faculdade
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.dgv_tabela = new System.Windows.Forms.DataGridView();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_nota = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabela)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(199, 153);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(38, 13);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "FACULDADE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nota:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "CADASTRAR NOTAS";
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(221, 237);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(97, 26);
            this.btn_cadastrar.TabIndex = 5;
            this.btn_cadastrar.Text = "CADASTRAR";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(324, 237);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(97, 26);
            this.btn_editar.TabIndex = 6;
            this.btn_editar.Text = "EDITAR";
            this.btn_editar.UseVisualStyleBackColor = true;
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(427, 237);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(97, 26);
            this.btn_excluir.TabIndex = 7;
            this.btn_excluir.Text = "EXCLUIR";
            this.btn_excluir.UseVisualStyleBackColor = true;
            // 
            // dgv_tabela
            // 
            this.dgv_tabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tabela.Location = new System.Drawing.Point(216, 272);
            this.dgv_tabela.Name = "dgv_tabela";
            this.dgv_tabela.Size = new System.Drawing.Size(308, 166);
            this.dgv_tabela.TabIndex = 8;
            this.dgv_tabela.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tabela_CellContentClick);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(278, 110);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(207, 20);
            this.txt_id.TabIndex = 9;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(278, 150);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(207, 20);
            this.txt_nome.TabIndex = 10;
            // 
            // txt_nota
            // 
            this.txt_nota.Location = new System.Drawing.Point(278, 195);
            this.txt_nota.Name = "txt_nota";
            this.txt_nota.Size = new System.Drawing.Size(207, 20);
            this.txt_nota.TabIndex = 11;
            // 
            // Faculdade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_nota);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.dgv_tabela);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_name);
            this.Name = "Faculdade";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Faculdade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.DataGridView dgv_tabela;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_nota;
    }
}

