namespace TradutorLista
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
            this.lbl2 = new System.Windows.Forms.Label();
            this.btnTraduzir = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtMostrar = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(31, 79);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(55, 13);
            this.lbl2.TabIndex = 0;
            this.lbl2.Text = "Portugues";
            // 
            // btnTraduzir
            // 
            this.btnTraduzir.Location = new System.Drawing.Point(34, 216);
            this.btnTraduzir.Name = "btnTraduzir";
            this.btnTraduzir.Size = new System.Drawing.Size(100, 38);
            this.btnTraduzir.TabIndex = 2;
            this.btnTraduzir.Text = "Traduzir";
            this.btnTraduzir.UseVisualStyleBackColor = true;
            this.btnTraduzir.Click += new System.EventHandler(this.btnTraduzir_Click);
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(34, 156);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 29);
            this.txtValor.TabIndex = 3;
            // 
            // txtMostrar
            // 
            this.txtMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMostrar.Location = new System.Drawing.Point(164, 156);
            this.txtMostrar.Name = "txtMostrar";
            this.txtMostrar.ReadOnly = true;
            this.txtMostrar.Size = new System.Drawing.Size(100, 29);
            this.txtMostrar.TabIndex = 4;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(31, 107);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(35, 13);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Ingles";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.txtMostrar);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.btnTraduzir);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lbl2);
            this.Name = "Form1";
            this.Text = "Tradutor Usando Lista";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Button btnTraduzir;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtMostrar;
        private System.Windows.Forms.Label lbl1;
    }
}

