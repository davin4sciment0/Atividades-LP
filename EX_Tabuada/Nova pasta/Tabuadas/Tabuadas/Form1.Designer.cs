
namespace Tabuadas
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
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            txttab1 = new System.Windows.Forms.TextBox();
            txttab2 = new System.Windows.Forms.TextBox();
            txttab3 = new System.Windows.Forms.TextBox();
            txtresult1 = new System.Windows.Forms.TextBox();
            txtresult2 = new System.Windows.Forms.TextBox();
            txtresult3 = new System.Windows.Forms.TextBox();
            button4 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(241, 317);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(362, 317);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Calcular";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(485, 317);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "Calcular";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(228, 51);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(338, 17);
            label1.TabIndex = 3;
            label1.Text = "Digite um núemro para cada uma das tabuadas a baixo:";
            // 
            // txttab1
            // 
            txttab1.Location = new System.Drawing.Point(228, 103);
            txttab1.Name = "txttab1";
            txttab1.Size = new System.Drawing.Size(100, 23);
            txttab1.TabIndex = 4;
            // 
            // txttab2
            // 
            txttab2.Location = new System.Drawing.Point(350, 103);
            txttab2.Name = "txttab2";
            txttab2.Size = new System.Drawing.Size(100, 23);
            txttab2.TabIndex = 5;
            // 
            // txttab3
            // 
            txttab3.Location = new System.Drawing.Point(472, 103);
            txttab3.Name = "txttab3";
            txttab3.Size = new System.Drawing.Size(100, 23);
            txttab3.TabIndex = 6;
            // 
            // txtresult1
            // 
            txtresult1.Location = new System.Drawing.Point(228, 145);
            txtresult1.Multiline = true;
            txtresult1.Name = "txtresult1";
            txtresult1.Size = new System.Drawing.Size(100, 146);
            txtresult1.TabIndex = 7;
            // 
            // txtresult2
            // 
            txtresult2.Location = new System.Drawing.Point(350, 145);
            txtresult2.Multiline = true;
            txtresult2.Name = "txtresult2";
            txtresult2.Size = new System.Drawing.Size(100, 146);
            txtresult2.TabIndex = 8;
            // 
            // txtresult3
            // 
            txtresult3.Location = new System.Drawing.Point(472, 145);
            txtresult3.Multiline = true;
            txtresult3.Name = "txtresult3";
            txtresult3.Size = new System.Drawing.Size(100, 146);
            txtresult3.TabIndex = 9;
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(229, 368);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(344, 23);
            button4.TabIndex = 10;
            button4.Text = "Limpar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(button4);
            Controls.Add(txtresult3);
            Controls.Add(txtresult2);
            Controls.Add(txtresult1);
            Controls.Add(txttab3);
            Controls.Add(txttab2);
            Controls.Add(txttab1);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttab1;
        private System.Windows.Forms.TextBox txttab2;
        private System.Windows.Forms.TextBox txttab3;
        private System.Windows.Forms.TextBox txtresult1;
        private System.Windows.Forms.TextBox txtresult2;
        private System.Windows.Forms.TextBox txtresult3;
        private System.Windows.Forms.Button button4;
    }
}

