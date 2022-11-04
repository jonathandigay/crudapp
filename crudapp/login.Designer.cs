namespace crudapp
{
    partial class login
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
            this.label1 = new System.Windows.Forms.Label();
            this.LUsername = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Iusername = new System.Windows.Forms.TextBox();
            this.Ipassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(138, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "CRUD APPLICATION";
            // 
            // LUsername
            // 
            this.LUsername.AutoSize = true;
            this.LUsername.Location = new System.Drawing.Point(64, 119);
            this.LUsername.Name = "LUsername";
            this.LUsername.Size = new System.Drawing.Size(74, 15);
            this.LUsername.TabIndex = 1;
            this.LUsername.Text = "USERNAME :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "PASSWORD :";
            // 
            // Iusername
            // 
            this.Iusername.Location = new System.Drawing.Point(138, 111);
            this.Iusername.Name = "Iusername";
            this.Iusername.Size = new System.Drawing.Size(210, 23);
            this.Iusername.TabIndex = 2;
            this.Iusername.TextChanged += new System.EventHandler(this.Iusername_TextChanged);
            this.Iusername.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Iusername_KeyUp);
            // 
            // Ipassword
            // 
            this.Ipassword.Location = new System.Drawing.Point(138, 164);
            this.Ipassword.Name = "Ipassword";
            this.Ipassword.Size = new System.Drawing.Size(210, 23);
            this.Ipassword.TabIndex = 2;
            this.Ipassword.TextChanged += new System.EventHandler(this.Ipassword_TextChanged);
            this.Ipassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Ipassword_KeyUp);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Ipassword);
            this.Controls.Add(this.Iusername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LUsername);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Enter += new System.EventHandler(this.Form1_Enter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label LUsername;
        private Label label2;
        private TextBox Iusername;
        private TextBox Ipassword;
        private Button button1;
    }
}