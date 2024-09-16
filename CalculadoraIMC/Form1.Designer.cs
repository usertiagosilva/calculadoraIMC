namespace CalculadoraIMC
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtPeso = new TextBox();
            txtAltura = new TextBox();
            btnCalcular = new Button();
            lblResultado = new Label();
            btnLimpar = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(244, 67);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(125, 27);
            txtPeso.TabIndex = 0;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(244, 138);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(125, 27);
            txtAltura.TabIndex = 1;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(199, 284);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(170, 29);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular IMC";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(77, 221);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(21, 20);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "\"\"";
            lblResultado.Click += lblResultado_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(250, 352);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(94, 29);
            btnLimpar.TabIndex = 4;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 70);
            label1.Name = "label1";
            label1.Size = new Size(139, 20);
            label1.TabIndex = 5;
            label1.Text = "Insira seu peso (kg):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 141);
            label2.Name = "label2";
            label2.Size = new Size(142, 20);
            label2.TabIndex = 6;
            label2.Text = "Insira sua altura (m):";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 438);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLimpar);
            Controls.Add(lblResultado);
            Controls.Add(btnCalcular);
            Controls.Add(txtAltura);
            Controls.Add(txtPeso);
            Name = "Form1";
            Text = "Calculadora IMC";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPeso;
        private TextBox txtAltura;
        private Button btnCalcular;
        private Label lblResultado;
        private Button btnLimpar;
        private Label label1;
        private Label label2;
    }
}
