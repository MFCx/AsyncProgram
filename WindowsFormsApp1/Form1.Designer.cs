
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TSayi1 = new System.Windows.Forms.TextBox();
            this.TSayi2 = new System.Windows.Forms.TextBox();
            this.CSayi2 = new System.Windows.Forms.TextBox();
            this.CSayi1 = new System.Windows.Forms.TextBox();
            this.Topla = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Toplam = new System.Windows.Forms.Label();
            this.CarpmaYap = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TSayi1
            // 
            this.TSayi1.Location = new System.Drawing.Point(165, 80);
            this.TSayi1.Name = "TSayi1";
            this.TSayi1.Size = new System.Drawing.Size(100, 20);
            this.TSayi1.TabIndex = 0;
            // 
            // TSayi2
            // 
            this.TSayi2.Location = new System.Drawing.Point(165, 106);
            this.TSayi2.Name = "TSayi2";
            this.TSayi2.Size = new System.Drawing.Size(100, 20);
            this.TSayi2.TabIndex = 1;
            // 
            // CSayi2
            // 
            this.CSayi2.Location = new System.Drawing.Point(456, 106);
            this.CSayi2.Name = "CSayi2";
            this.CSayi2.Size = new System.Drawing.Size(100, 20);
            this.CSayi2.TabIndex = 3;
            // 
            // CSayi1
            // 
            this.CSayi1.Location = new System.Drawing.Point(456, 80);
            this.CSayi1.Name = "CSayi1";
            this.CSayi1.Size = new System.Drawing.Size(100, 20);
            this.CSayi1.TabIndex = 2;
            // 
            // Topla
            // 
            this.Topla.Location = new System.Drawing.Point(165, 151);
            this.Topla.Name = "Topla";
            this.Topla.Size = new System.Drawing.Size(75, 23);
            this.Topla.TabIndex = 4;
            this.Topla.Text = "Topla";
            this.Topla.UseVisualStyleBackColor = true;
            this.Topla.Click += new System.EventHandler(this.Topla_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(456, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Carp";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Toplam
            // 
            this.Toplam.AutoSize = true;
            this.Toplam.Location = new System.Drawing.Point(185, 204);
            this.Toplam.Name = "Toplam";
            this.Toplam.Size = new System.Drawing.Size(35, 13);
            this.Toplam.TabIndex = 6;
            this.Toplam.Text = "label1";
            // 
            // CarpmaYap
            // 
            this.CarpmaYap.AutoSize = true;
            this.CarpmaYap.Location = new System.Drawing.Point(466, 204);
            this.CarpmaYap.Name = "CarpmaYap";
            this.CarpmaYap.Size = new System.Drawing.Size(39, 13);
            this.CarpmaYap.TabIndex = 7;
            this.CarpmaYap.Text = "Carpim";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CarpmaYap);
            this.Controls.Add(this.Toplam);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Topla);
            this.Controls.Add(this.CSayi2);
            this.Controls.Add(this.CSayi1);
            this.Controls.Add(this.TSayi2);
            this.Controls.Add(this.TSayi1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TSayi1;
        private System.Windows.Forms.TextBox TSayi2;
        private System.Windows.Forms.TextBox CSayi2;
        private System.Windows.Forms.TextBox CSayi1;
        private System.Windows.Forms.Button Topla;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Toplam;
        private System.Windows.Forms.Label CarpmaYap;
    }
}

