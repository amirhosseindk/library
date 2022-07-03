
namespace Libary
{
    partial class Login
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
            this.Pass_txt = new System.Windows.Forms.TextBox();
            this.User_txt = new System.Windows.Forms.TextBox();
            this.Pass_Label = new System.Windows.Forms.Label();
            this.User_Label = new System.Windows.Forms.Label();
            this.Login_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Pass_txt
            // 
            this.Pass_txt.Location = new System.Drawing.Point(321, 186);
            this.Pass_txt.Name = "Pass_txt";
            this.Pass_txt.Size = new System.Drawing.Size(378, 38);
            this.Pass_txt.TabIndex = 9;
            // 
            // User_txt
            // 
            this.User_txt.Location = new System.Drawing.Point(321, 94);
            this.User_txt.Name = "User_txt";
            this.User_txt.Size = new System.Drawing.Size(378, 38);
            this.User_txt.TabIndex = 8;
            // 
            // Pass_Label
            // 
            this.Pass_Label.AutoSize = true;
            this.Pass_Label.Location = new System.Drawing.Point(101, 186);
            this.Pass_Label.Name = "Pass_Label";
            this.Pass_Label.Size = new System.Drawing.Size(154, 32);
            this.Pass_Label.TabIndex = 7;
            this.Pass_Label.Text = "Password :";
            // 
            // User_Label
            // 
            this.User_Label.AutoSize = true;
            this.User_Label.Location = new System.Drawing.Point(101, 94);
            this.User_Label.Name = "User_Label";
            this.User_Label.Size = new System.Drawing.Size(160, 32);
            this.User_Label.TabIndex = 6;
            this.User_Label.Text = "Username :";
            // 
            // Login_btn
            // 
            this.Login_btn.Location = new System.Drawing.Point(248, 288);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(262, 68);
            this.Login_btn.TabIndex = 5;
            this.Login_btn.Text = "Login";
            this.Login_btn.UseVisualStyleBackColor = true;
            this.Login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 440);
            this.Controls.Add(this.Pass_txt);
            this.Controls.Add(this.User_txt);
            this.Controls.Add(this.Pass_Label);
            this.Controls.Add(this.User_Label);
            this.Controls.Add(this.Login_btn);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Pass_txt;
        private System.Windows.Forms.TextBox User_txt;
        private System.Windows.Forms.Label Pass_Label;
        private System.Windows.Forms.Label User_Label;
        private System.Windows.Forms.Button Login_btn;
    }
}