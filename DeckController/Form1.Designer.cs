
namespace DeckController
{
    partial class Form1
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEXCLUIR = new System.Windows.Forms.Button();
            this.btnCONSULTAR = new System.Windows.Forms.Button();
            this.btnNOVO = new System.Windows.Forms.Button();
            this.btnEDITAR = new System.Windows.Forms.Button();
            this.btnEXIBIR = new System.Windows.Forms.Button();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(133, 60);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 0;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(133, 148);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(100, 20);
            this.txtTipo.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(133, 103);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo:";
            // 
            // btnEXCLUIR
            // 
            this.btnEXCLUIR.Location = new System.Drawing.Point(282, 232);
            this.btnEXCLUIR.Name = "btnEXCLUIR";
            this.btnEXCLUIR.Size = new System.Drawing.Size(75, 23);
            this.btnEXCLUIR.TabIndex = 6;
            this.btnEXCLUIR.Text = "Excluir";
            this.btnEXCLUIR.UseVisualStyleBackColor = true;
            this.btnEXCLUIR.Click += new System.EventHandler(this.btnEXCLUIR_Click);
            // 
            // btnCONSULTAR
            // 
            this.btnCONSULTAR.Location = new System.Drawing.Point(375, 232);
            this.btnCONSULTAR.Name = "btnCONSULTAR";
            this.btnCONSULTAR.Size = new System.Drawing.Size(75, 23);
            this.btnCONSULTAR.TabIndex = 7;
            this.btnCONSULTAR.Text = "Consultar";
            this.btnCONSULTAR.UseVisualStyleBackColor = true;
            this.btnCONSULTAR.Click += new System.EventHandler(this.btnCONSULTAR_Click);
            // 
            // btnNOVO
            // 
            this.btnNOVO.Location = new System.Drawing.Point(79, 232);
            this.btnNOVO.Name = "btnNOVO";
            this.btnNOVO.Size = new System.Drawing.Size(75, 23);
            this.btnNOVO.TabIndex = 8;
            this.btnNOVO.Text = "Novo";
            this.btnNOVO.UseVisualStyleBackColor = true;
            this.btnNOVO.Click += new System.EventHandler(this.btnNOVO_Click);
            // 
            // btnEDITAR
            // 
            this.btnEDITAR.Location = new System.Drawing.Point(180, 232);
            this.btnEDITAR.Name = "btnEDITAR";
            this.btnEDITAR.Size = new System.Drawing.Size(75, 23);
            this.btnEDITAR.TabIndex = 9;
            this.btnEDITAR.Text = "Editar";
            this.btnEDITAR.UseVisualStyleBackColor = true;
            this.btnEDITAR.Click += new System.EventHandler(this.btnEDITAR_Click);
            // 
            // btnEXIBIR
            // 
            this.btnEXIBIR.Location = new System.Drawing.Point(470, 232);
            this.btnEXIBIR.Name = "btnEXIBIR";
            this.btnEXIBIR.Size = new System.Drawing.Size(75, 23);
            this.btnEXIBIR.TabIndex = 10;
            this.btnEXIBIR.Text = "Exibir";
            this.btnEXIBIR.UseVisualStyleBackColor = true;
            this.btnEXIBIR.Click += new System.EventHandler(this.btnEXIBIR_Click);
            // 
            // dgvDados
            // 
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(12, 261);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(776, 177);
            this.dgvDados.TabIndex = 11;
            this.dgvDados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.btnEXIBIR);
            this.Controls.Add(this.btnEDITAR);
            this.Controls.Add(this.btnNOVO);
            this.Controls.Add(this.btnCONSULTAR);
            this.Controls.Add(this.btnEXCLUIR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.txtID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEXCLUIR;
        private System.Windows.Forms.Button btnCONSULTAR;
        private System.Windows.Forms.Button btnNOVO;
        private System.Windows.Forms.Button btnEDITAR;
        private System.Windows.Forms.Button btnEXIBIR;
        private System.Windows.Forms.DataGridView dgvDados;
    }
}

