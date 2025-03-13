namespace ListBox_
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSIndex1 = new System.Windows.Forms.TextBox();
            this.txtSItem1 = new System.Windows.Forms.TextBox();
            this.txtSItem2 = new System.Windows.Forms.TextBox();
            this.txtSIndex2 = new System.Windows.Forms.TextBox();
            this.txtSItem3 = new System.Windows.Forms.TextBox();
            this.txtSIndex3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "GDP 순위";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "살기 좋은 도시";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(420, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "행복한 나라";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "미국",
            "러시아",
            "중국",
            "영국",
            "독일",
            "프랑스",
            "일본",
            "이스라엘",
            "사우디아라비아",
            "UAE",
            "한국"});
            this.listBox1.Location = new System.Drawing.Point(145, 131);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(283, 131);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 95);
            this.listBox2.TabIndex = 4;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(423, 131);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(120, 95);
            this.listBox3.TabIndex = 5;
            this.listBox3.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "SelectredItem :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "SelectedIndex :";
            // 
            // txtSIndex1
            // 
            this.txtSIndex1.Location = new System.Drawing.Point(145, 261);
            this.txtSIndex1.Name = "txtSIndex1";
            this.txtSIndex1.Size = new System.Drawing.Size(120, 20);
            this.txtSIndex1.TabIndex = 8;
            // 
            // txtSItem1
            // 
            this.txtSItem1.Location = new System.Drawing.Point(145, 298);
            this.txtSItem1.Name = "txtSItem1";
            this.txtSItem1.Size = new System.Drawing.Size(120, 20);
            this.txtSItem1.TabIndex = 9;
            // 
            // txtSItem2
            // 
            this.txtSItem2.Location = new System.Drawing.Point(283, 301);
            this.txtSItem2.Name = "txtSItem2";
            this.txtSItem2.Size = new System.Drawing.Size(120, 20);
            this.txtSItem2.TabIndex = 11;
            // 
            // txtSIndex2
            // 
            this.txtSIndex2.Location = new System.Drawing.Point(283, 264);
            this.txtSIndex2.Name = "txtSIndex2";
            this.txtSIndex2.Size = new System.Drawing.Size(120, 20);
            this.txtSIndex2.TabIndex = 10;
            // 
            // txtSItem3
            // 
            this.txtSItem3.Location = new System.Drawing.Point(423, 301);
            this.txtSItem3.Name = "txtSItem3";
            this.txtSItem3.Size = new System.Drawing.Size(120, 20);
            this.txtSItem3.TabIndex = 13;
            // 
            // txtSIndex3
            // 
            this.txtSIndex3.Location = new System.Drawing.Point(423, 264);
            this.txtSIndex3.Name = "txtSIndex3";
            this.txtSIndex3.Size = new System.Drawing.Size(120, 20);
            this.txtSIndex3.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 450);
            this.Controls.Add(this.txtSItem3);
            this.Controls.Add(this.txtSIndex3);
            this.Controls.Add(this.txtSItem2);
            this.Controls.Add(this.txtSIndex2);
            this.Controls.Add(this.txtSItem1);
            this.Controls.Add(this.txtSIndex1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSIndex1;
        private System.Windows.Forms.TextBox txtSItem1;
        private System.Windows.Forms.TextBox txtSItem2;
        private System.Windows.Forms.TextBox txtSIndex2;
        private System.Windows.Forms.TextBox txtSItem3;
        private System.Windows.Forms.TextBox txtSIndex3;
    }
}

