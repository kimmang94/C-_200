namespace RGBScrollBar
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtR = new System.Windows.Forms.TextBox();
            this.txtG = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.srcR = new System.Windows.Forms.HScrollBar();
            this.srcG = new System.Windows.Forms.HScrollBar();
            this.srcB = new System.Windows.Forms.HScrollBar();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 184);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Red";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Green";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Blue";
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(688, 229);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(100, 20);
            this.txtR.TabIndex = 4;
            this.txtR.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txtG
            // 
            this.txtG.Location = new System.Drawing.Point(688, 298);
            this.txtG.Name = "txtG";
            this.txtG.Size = new System.Drawing.Size(100, 20);
            this.txtG.TabIndex = 5;
            this.txtG.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(688, 372);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 20);
            this.txtB.TabIndex = 6;
            this.txtB.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // srcR
            // 
            this.srcR.Location = new System.Drawing.Point(58, 229);
            this.srcR.Name = "srcR";
            this.srcR.Size = new System.Drawing.Size(577, 20);
            this.srcR.TabIndex = 7;
            this.srcR.Scroll += new System.Windows.Forms.ScrollEventHandler(this.src_Scroll);
            // 
            // srcG
            // 
            this.srcG.Location = new System.Drawing.Point(58, 298);
            this.srcG.Name = "srcG";
            this.srcG.Size = new System.Drawing.Size(577, 20);
            this.srcG.TabIndex = 8;
            this.srcG.Scroll += new System.Windows.Forms.ScrollEventHandler(this.src_Scroll);
            // 
            // srcB
            // 
            this.srcB.Location = new System.Drawing.Point(58, 372);
            this.srcB.Name = "srcB";
            this.srcB.Size = new System.Drawing.Size(577, 20);
            this.srcB.TabIndex = 9;
            this.srcB.Scroll += new System.Windows.Forms.ScrollEventHandler(this.src_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.srcB);
            this.Controls.Add(this.srcG);
            this.Controls.Add(this.srcR);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtG);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Red";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.TextBox txtG;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.HScrollBar srcR;
        private System.Windows.Forms.HScrollBar srcG;
        private System.Windows.Forms.HScrollBar srcB;
    }
}

