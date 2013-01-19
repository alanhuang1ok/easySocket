namespace Test
{
    partial class gameMessage
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_len1 = new System.Windows.Forms.TextBox();
            this.txt_leng2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_msg1 = new System.Windows.Forms.TextBox();
            this.txt_msg2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_subid1 = new System.Windows.Forms.TextBox();
            this.txt_subid2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_subid2);
            this.groupBox1.Controls.Add(this.txt_subid1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_msg2);
            this.groupBox1.Controls.Add(this.txt_msg1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_leng2);
            this.groupBox1.Controls.Add(this.txt_len1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(48, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "信息头";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "msgLen";
            // 
            // txt_len1
            // 
            this.txt_len1.Location = new System.Drawing.Point(91, 18);
            this.txt_len1.Name = "txt_len1";
            this.txt_len1.Size = new System.Drawing.Size(52, 21);
            this.txt_len1.TabIndex = 1;
            // 
            // txt_leng2
            // 
            this.txt_leng2.Location = new System.Drawing.Point(171, 18);
            this.txt_leng2.Name = "txt_leng2";
            this.txt_leng2.Size = new System.Drawing.Size(52, 21);
            this.txt_leng2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "msgId";
            // 
            // txt_msg1
            // 
            this.txt_msg1.Location = new System.Drawing.Point(91, 50);
            this.txt_msg1.Name = "txt_msg1";
            this.txt_msg1.Size = new System.Drawing.Size(52, 21);
            this.txt_msg1.TabIndex = 4;
            // 
            // txt_msg2
            // 
            this.txt_msg2.Location = new System.Drawing.Point(171, 49);
            this.txt_msg2.Name = "txt_msg2";
            this.txt_msg2.Size = new System.Drawing.Size(52, 21);
            this.txt_msg2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "msgSubId";
            // 
            // txt_subid1
            // 
            this.txt_subid1.Location = new System.Drawing.Point(91, 82);
            this.txt_subid1.Name = "txt_subid1";
            this.txt_subid1.Size = new System.Drawing.Size(65, 21);
            this.txt_subid1.TabIndex = 7;
            // 
            // txt_subid2
            // 
            this.txt_subid2.Location = new System.Drawing.Point(171, 82);
            this.txt_subid2.Name = "txt_subid2";
            this.txt_subid2.Size = new System.Drawing.Size(65, 21);
            this.txt_subid2.TabIndex = 8;
            // 
            // gameMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 490);
            this.Controls.Add(this.groupBox1);
            this.Name = "gameMessage";
            this.Text = "gameMessage";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_len1;
        private System.Windows.Forms.TextBox txt_leng2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_msg2;
        private System.Windows.Forms.TextBox txt_msg1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_subid1;
        private System.Windows.Forms.TextBox txt_subid2;
    }
}