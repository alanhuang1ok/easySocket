namespace Test
{
    partial class UserWin
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
            this.txt_id = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "id";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(79, 30);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(164, 21);
            this.txt_id.TabIndex = 1;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(34, 85);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(29, 12);
            this.name.TabIndex = 2;
            this.name.Text = "name";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(79, 85);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(164, 21);
            this.txt_name.TabIndex = 3;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(182, 150);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 4;
            this.btn_send.Text = "发送";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // UserWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 224);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.name);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label1);
            this.Name = "UserWin";
            this.Text = "UserWin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button btn_send;
    }
}