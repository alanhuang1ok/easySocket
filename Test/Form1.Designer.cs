namespace Test
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
            this.txt_int = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_string = new System.Windows.Forms.TextBox();
            this.bool类型 = new System.Windows.Forms.Label();
            this.txt_bool = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "int类型";
            // 
            // txt_int
            // 
            this.txt_int.Location = new System.Drawing.Point(93, 23);
            this.txt_int.Name = "txt_int";
            this.txt_int.Size = new System.Drawing.Size(232, 21);
            this.txt_int.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(354, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "btn_test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_result
            // 
            this.txt_result.Location = new System.Drawing.Point(36, 274);
            this.txt_result.Multiline = true;
            this.txt_result.Name = "txt_result";
            this.txt_result.Size = new System.Drawing.Size(426, 298);
            this.txt_result.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "转换后的字节：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "string类型:";
            // 
            // txt_string
            // 
            this.txt_string.Location = new System.Drawing.Point(108, 67);
            this.txt_string.Name = "txt_string";
            this.txt_string.Size = new System.Drawing.Size(321, 21);
            this.txt_string.TabIndex = 6;
            // 
            // bool类型
            // 
            this.bool类型.AutoSize = true;
            this.bool类型.Location = new System.Drawing.Point(29, 111);
            this.bool类型.Name = "bool类型";
            this.bool类型.Size = new System.Drawing.Size(59, 12);
            this.bool类型.TabIndex = 7;
            this.bool类型.Text = "bool类型:";
            // 
            // txt_bool
            // 
            this.txt_bool.Location = new System.Drawing.Point(108, 111);
            this.txt_bool.Name = "txt_bool";
            this.txt_bool.Size = new System.Drawing.Size(321, 21);
            this.txt_bool.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 597);
            this.Controls.Add(this.txt_bool);
            this.Controls.Add(this.bool类型);
            this.Controls.Add(this.txt_string);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_int);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_int;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_result;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_string;
        private System.Windows.Forms.Label bool类型;
        private System.Windows.Forms.TextBox txt_bool;
    }
}

