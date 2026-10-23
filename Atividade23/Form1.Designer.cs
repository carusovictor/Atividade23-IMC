namespace Atividade23
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtPeso = new TextBox();
            txtAltura = new TextBox();
            btnCalcular = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(377, 9);
            label1.Name = "label1";
            label1.Size = new Size(341, 70);
            label1.TabIndex = 0;
            label1.Text = "SISTEMA IMC";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(176, 118);
            label2.Name = "label2";
            label2.Size = new Size(112, 48);
            label2.TabIndex = 1;
            label2.Text = "PESO:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(161, 211);
            label3.Name = "label3";
            label3.Size = new Size(155, 48);
            label3.TabIndex = 2;
            label3.Text = "ALTURA:";
            
            // 
            // txtPeso
            // 
            txtPeso.Font = new Font("Segoe UI", 14F);
            txtPeso.Location = new Point(339, 118);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(162, 45);
            txtPeso.TabIndex = 3;
            // 
            // txtAltura
            // 
            txtAltura.Font = new Font("Segoe UI", 14F);
            txtAltura.Location = new Point(339, 216);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(162, 45);
            txtAltura.TabIndex = 4;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(235, 323);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(223, 76);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(588, 156);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(219, 48);
            lblResultado.TabIndex = 6;
            lblResultado.Text = "RESULTADO:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1127, 453);
            Controls.Add(lblResultado);
            Controls.Add(btnCalcular);
            Controls.Add(txtAltura);
            Controls.Add(txtPeso);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtPeso;
        private TextBox txtAltura;
        private Button btnCalcular;
        private Label lblResultado;
    }
}
