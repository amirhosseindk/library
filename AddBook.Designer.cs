
namespace Libary
{
    partial class AddBook
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnok = new System.Windows.Forms.Button();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.txtwriter = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtcat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(152, 371);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 32);
            this.label6.TabIndex = 27;
            this.label6.Text = "Category :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(201, 292);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 32);
            this.label5.TabIndex = 25;
            this.label5.Text = "Num :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 209);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 32);
            this.label2.TabIndex = 22;
            this.label2.Text = "Writer :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 130);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 32);
            this.label1.TabIndex = 21;
            this.label1.Text = "Name :";
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(523, 466);
            this.btnok.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(200, 55);
            this.btnok.TabIndex = 19;
            this.btnok.Text = "Add";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(353, 286);
            this.txtnum.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(671, 38);
            this.txtnum.TabIndex = 18;
            // 
            // txtwriter
            // 
            this.txtwriter.Location = new System.Drawing.Point(353, 209);
            this.txtwriter.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtwriter.Name = "txtwriter";
            this.txtwriter.Size = new System.Drawing.Size(671, 38);
            this.txtwriter.TabIndex = 16;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(353, 130);
            this.txtname.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(671, 38);
            this.txtname.TabIndex = 15;
            // 
            // txtcat
            // 
            this.txtcat.Location = new System.Drawing.Point(353, 365);
            this.txtcat.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtcat.Name = "txtcat";
            this.txtcat.Size = new System.Drawing.Size(671, 38);
            this.txtcat.TabIndex = 28;
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 600);
            this.Controls.Add(this.txtcat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.txtwriter);
            this.Controls.Add(this.txtname);
            this.Name = "AddBook";
            this.Text = "AddBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.TextBox txtwriter;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtcat;
    }
}