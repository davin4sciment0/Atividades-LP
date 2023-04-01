
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txttab1 = new System.Windows.Forms.TextBox();
            this.txttab2 = new System.Windows.Forms.TextBox();
            this.txttab3 = new System.Windows.Forms.TextBox();
            this.txtresult1 = new System.Windows.Forms.TextBox();
            this.txtresult2 = new System.Windows.Forms.TextBox();
            this.txtresult3 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(240, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(361, 264);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Calcular";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(484, 264);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Calcular";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(228, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Digite um núemro para cada uma das tabuadas a baixo:";
            // 
            // txttab1
            // 
            this.txttab1.Location = new System.Drawing.Point(228, 103);
            this.txttab1.Name = "txttab1";
            this.txttab1.Size = new System.Drawing.Size(100, 23);
            this.txttab1.TabIndex = 4;
            // 
            // txttab2
            // 
            this.txttab2.Location = new System.Drawing.Point(350, 103);
            this.txttab2.Name = "txttab2";
            this.txttab2.Size = new System.Drawing.Size(100, 23);
            this.txttab2.TabIndex = 5;
            // 
            // txttab3
            // 
            this.txttab3.Location = new System.Drawing.Point(472, 103);
            this.txttab3.Name = "txttab3";
            this.txttab3.Size = new System.Drawing.Size(100, 23);
            this.txttab3.TabIndex = 6;
            // 
            // txtresult1
            // 
            this.txtresult1.Location = new System.Drawing.Point(228, 145);
            this.txtresult1.Name = "txtresult1";
            this.txtresult1.Size = new System.Drawing.Size(100, 23);
            this.txtresult1.TabIndex = 7;
            // 
            // txtresult2
            // 
            this.txtresult2.Location = new System.Drawing.Point(350, 145);
            this.txtresult2.Name = "txtresult2";
            this.txtresult2.Size = new System.Drawing.Size(100, 23);
            this.txtresult2.TabIndex = 8;
            // 
            // txtresult3
            // 
            this.txtresult3.Location = new System.Drawing.Point(472, 145);
            this.txtresult3.Name = "txtresult3";
            this.txtresult3.Size = new System.Drawing.Size(100, 23);
            this.txtresult3.TabIndex = 9;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(228, 315);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(344, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Limpar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtresult3);
            this.Controls.Add(this.txtresult2);
            this.Controls.Add(this.txtresult1);
            this.Controls.Add(this.txttab3);
            this.Controls.Add(this.txttab2);
            this.Controls.Add(this.txttab1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

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

