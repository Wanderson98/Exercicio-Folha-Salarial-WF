namespace Aula52Exercicio
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtColaborador = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSalarioBruto = new System.Windows.Forms.TextBox();
            this.rbtnCLT = new System.Windows.Forms.RadioButton();
            this.rbtnPJ = new System.Windows.Forms.RadioButton();
            this.rbtnFreeLancer = new System.Windows.Forms.RadioButton();
            this.lblValorProjeto = new System.Windows.Forms.Label();
            this.txtValorProjeto = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSalarioLiquido = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Colaborador";
            // 
            // txtColaborador
            // 
            this.txtColaborador.Location = new System.Drawing.Point(27, 57);
            this.txtColaborador.Name = "txtColaborador";
            this.txtColaborador.Size = new System.Drawing.Size(273, 26);
            this.txtColaborador.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Salário Bruto";
            // 
            // txtSalarioBruto
            // 
            this.txtSalarioBruto.Location = new System.Drawing.Point(27, 130);
            this.txtSalarioBruto.Name = "txtSalarioBruto";
            this.txtSalarioBruto.Size = new System.Drawing.Size(273, 26);
            this.txtSalarioBruto.TabIndex = 1;
            // 
            // rbtnCLT
            // 
            this.rbtnCLT.AutoSize = true;
            this.rbtnCLT.Location = new System.Drawing.Point(380, 57);
            this.rbtnCLT.Name = "rbtnCLT";
            this.rbtnCLT.Size = new System.Drawing.Size(56, 24);
            this.rbtnCLT.TabIndex = 2;
            this.rbtnCLT.TabStop = true;
            this.rbtnCLT.Text = "CLT";
            this.rbtnCLT.UseVisualStyleBackColor = true;
            // 
            // rbtnPJ
            // 
            this.rbtnPJ.AutoSize = true;
            this.rbtnPJ.Location = new System.Drawing.Point(380, 94);
            this.rbtnPJ.Name = "rbtnPJ";
            this.rbtnPJ.Size = new System.Drawing.Size(111, 24);
            this.rbtnPJ.TabIndex = 2;
            this.rbtnPJ.TabStop = true;
            this.rbtnPJ.Text = "Contrato PJ";
            this.rbtnPJ.UseVisualStyleBackColor = true;
            // 
            // rbtnFreeLancer
            // 
            this.rbtnFreeLancer.AutoSize = true;
            this.rbtnFreeLancer.Location = new System.Drawing.Point(380, 130);
            this.rbtnFreeLancer.Name = "rbtnFreeLancer";
            this.rbtnFreeLancer.Size = new System.Drawing.Size(109, 24);
            this.rbtnFreeLancer.TabIndex = 2;
            this.rbtnFreeLancer.TabStop = true;
            this.rbtnFreeLancer.Text = "FreeLancer";
            this.rbtnFreeLancer.UseVisualStyleBackColor = true;
            this.rbtnFreeLancer.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // lblValorProjeto
            // 
            this.lblValorProjeto.AutoSize = true;
            this.lblValorProjeto.Location = new System.Drawing.Point(23, 178);
            this.lblValorProjeto.Name = "lblValorProjeto";
            this.lblValorProjeto.Size = new System.Drawing.Size(100, 20);
            this.lblValorProjeto.TabIndex = 0;
            this.lblValorProjeto.Text = "Valor Projeto";
            this.lblValorProjeto.Visible = false;
            // 
            // txtValorProjeto
            // 
            this.txtValorProjeto.Location = new System.Drawing.Point(27, 210);
            this.txtValorProjeto.Name = "txtValorProjeto";
            this.txtValorProjeto.Size = new System.Drawing.Size(273, 26);
            this.txtValorProjeto.TabIndex = 1;
            this.txtValorProjeto.Visible = false;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(380, 200);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(109, 36);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = " Salário Líquido: ";
            // 
            // lblSalarioLiquido
            // 
            this.lblSalarioLiquido.AutoSize = true;
            this.lblSalarioLiquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioLiquido.Location = new System.Drawing.Point(33, 352);
            this.lblSalarioLiquido.Name = "lblSalarioLiquido";
            this.lblSalarioLiquido.Size = new System.Drawing.Size(0, 24);
            this.lblSalarioLiquido.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 627);
            this.Controls.Add(this.lblSalarioLiquido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.rbtnFreeLancer);
            this.Controls.Add(this.rbtnPJ);
            this.Controls.Add(this.rbtnCLT);
            this.Controls.Add(this.txtValorProjeto);
            this.Controls.Add(this.txtSalarioBruto);
            this.Controls.Add(this.txtColaborador);
            this.Controls.Add(this.lblValorProjeto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtColaborador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSalarioBruto;
        private System.Windows.Forms.RadioButton rbtnCLT;
        private System.Windows.Forms.RadioButton rbtnPJ;
        private System.Windows.Forms.RadioButton rbtnFreeLancer;
        private System.Windows.Forms.Label lblValorProjeto;
        private System.Windows.Forms.TextBox txtValorProjeto;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSalarioLiquido;
    }
}

