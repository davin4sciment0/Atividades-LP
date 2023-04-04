
namespace Posto_linguagemC
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
            btncalcular = new System.Windows.Forms.Button();
            btnlimpar = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            txtcomb = new System.Windows.Forms.TextBox();
            txtvalor = new System.Windows.Forms.TextBox();
            txtlitro = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // btncalcular
            // 
            btncalcular.Location = new System.Drawing.Point(175, 310);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new System.Drawing.Size(140, 23);
            btncalcular.TabIndex = 0;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // btnlimpar
            // 
            btnlimpar.Location = new System.Drawing.Point(480, 310);
            btnlimpar.Name = "btnlimpar";
            btnlimpar.Size = new System.Drawing.Size(140, 23);
            btnlimpar.TabIndex = 1;
            btnlimpar.Text = "Limpar";
            btnlimpar.UseVisualStyleBackColor = true;
            btnlimpar.Click += btnlimpar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(175, 127);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(159, 15);
            label1.TabIndex = 3;
            label1.Text = "Digite o tipo de combustível:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(175, 174);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(158, 15);
            label2.TabIndex = 4;
            label2.Text = "DIgite a quantidade de litros:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(175, 223);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(93, 15);
            label3.TabIndex = 5;
            label3.Text = "Valor a ser pago:";
            // 
            // txtcomb
            // 
            txtcomb.Location = new System.Drawing.Point(385, 124);
            txtcomb.Name = "txtcomb";
            txtcomb.Size = new System.Drawing.Size(235, 23);
            txtcomb.TabIndex = 6;
            // 
            // txtvalor
            // 
            txtvalor.Location = new System.Drawing.Point(385, 220);
            txtvalor.Name = "txtvalor";
            txtvalor.Size = new System.Drawing.Size(235, 23);
            txtvalor.TabIndex = 7;
            // 
            // txtlitro
            // 
            txtlitro.Location = new System.Drawing.Point(385, 171);
            txtlitro.Name = "txtlitro";
            txtlitro.Size = new System.Drawing.Size(235, 23);
            txtlitro.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(297, 56);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(239, 24);
            label4.TabIndex = 9;
            label4.Text = "A = Ácool / G = Gasolina";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(label4);
            Controls.Add(txtlitro);
            Controls.Add(txtvalor);
            Controls.Add(txtcomb);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnlimpar);
            Controls.Add(btncalcular);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcomb;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.TextBox txtlitro;
        private System.Windows.Forms.Label label4;
    }
}

