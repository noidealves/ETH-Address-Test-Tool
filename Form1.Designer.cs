namespace ETH_Address_Test_Tool
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
            this.bt_iniciar = new System.Windows.Forms.Button();
            this.lb_address = new System.Windows.Forms.Label();
            this.lb_balance = new System.Windows.Forms.Label();
            this.lb_arquivo = new System.Windows.Forms.Label();
            this.lb_linha = new System.Windows.Forms.Label();
            this.bt_pasta = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // bt_iniciar
            // 
            this.bt_iniciar.Location = new System.Drawing.Point(14, 143);
            this.bt_iniciar.Name = "bt_iniciar";
            this.bt_iniciar.Size = new System.Drawing.Size(397, 45);
            this.bt_iniciar.TabIndex = 0;
            this.bt_iniciar.Text = "Iniciar";
            this.bt_iniciar.UseVisualStyleBackColor = true;
            this.bt_iniciar.Click += new System.EventHandler(this.bt_iniciar_Click);
            // 
            // lb_address
            // 
            this.lb_address.AutoSize = true;
            this.lb_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_address.Location = new System.Drawing.Point(14, 24);
            this.lb_address.Name = "lb_address";
            this.lb_address.Size = new System.Drawing.Size(52, 13);
            this.lb_address.TabIndex = 1;
            this.lb_address.Text = "Address";
            // 
            // lb_balance
            // 
            this.lb_balance.AutoSize = true;
            this.lb_balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_balance.Location = new System.Drawing.Point(14, 54);
            this.lb_balance.Name = "lb_balance";
            this.lb_balance.Size = new System.Drawing.Size(53, 13);
            this.lb_balance.TabIndex = 2;
            this.lb_balance.Text = "Balance";
            // 
            // lb_arquivo
            // 
            this.lb_arquivo.AutoSize = true;
            this.lb_arquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_arquivo.Location = new System.Drawing.Point(14, 82);
            this.lb_arquivo.Name = "lb_arquivo";
            this.lb_arquivo.Size = new System.Drawing.Size(50, 13);
            this.lb_arquivo.TabIndex = 3;
            this.lb_arquivo.Text = "Arquivo";
            // 
            // lb_linha
            // 
            this.lb_linha.AutoSize = true;
            this.lb_linha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_linha.Location = new System.Drawing.Point(14, 110);
            this.lb_linha.Name = "lb_linha";
            this.lb_linha.Size = new System.Drawing.Size(38, 13);
            this.lb_linha.TabIndex = 4;
            this.lb_linha.Text = "Linha";
            // 
            // bt_pasta
            // 
            this.bt_pasta.Location = new System.Drawing.Point(14, 194);
            this.bt_pasta.Name = "bt_pasta";
            this.bt_pasta.Size = new System.Drawing.Size(397, 45);
            this.bt_pasta.TabIndex = 5;
            this.bt_pasta.Text = "Selecionar Pasta";
            this.bt_pasta.UseVisualStyleBackColor = true;
            this.bt_pasta.Click += new System.EventHandler(this.bt_pasta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 250);
            this.Controls.Add(this.bt_pasta);
            this.Controls.Add(this.lb_linha);
            this.Controls.Add(this.lb_arquivo);
            this.Controls.Add(this.lb_balance);
            this.Controls.Add(this.lb_address);
            this.Controls.Add(this.bt_iniciar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ETH Address Test Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_iniciar;
        private System.Windows.Forms.Label lb_address;
        private System.Windows.Forms.Label lb_balance;
        private System.Windows.Forms.Label lb_arquivo;
        private System.Windows.Forms.Label lb_linha;
        private System.Windows.Forms.Button bt_pasta;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

