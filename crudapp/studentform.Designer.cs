namespace crudapp
{
    partial class studentform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(studentform));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.create_student_btn = new System.Windows.Forms.Button();
            this.Iage = new System.Windows.Forms.TextBox();
            this.Igender = new System.Windows.Forms.TextBox();
            this.Iname = new System.Windows.Forms.TextBox();
            this.Ibirthdate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(101, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "CREATE STUDENT RECORD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Gender :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Age :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Name :";
            // 
            // create_student_btn
            // 
            this.create_student_btn.BackColor = System.Drawing.SystemColors.Desktop;
            this.create_student_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.create_student_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.create_student_btn.Location = new System.Drawing.Point(184, 314);
            this.create_student_btn.Name = "create_student_btn";
            this.create_student_btn.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.create_student_btn.Size = new System.Drawing.Size(109, 49);
            this.create_student_btn.TabIndex = 8;
            this.create_student_btn.Text = "Add";
            this.create_student_btn.UseVisualStyleBackColor = false;
            this.create_student_btn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Iage
            // 
            this.Iage.Location = new System.Drawing.Point(157, 213);
            this.Iage.Multiline = true;
            this.Iage.Name = "Iage";
            this.Iage.PlaceholderText = "age...";
            this.Iage.Size = new System.Drawing.Size(200, 25);
            this.Iage.TabIndex = 5;
            // 
            // Igender
            // 
            this.Igender.Location = new System.Drawing.Point(157, 159);
            this.Igender.Name = "Igender";
            this.Igender.PlaceholderText = "gender...";
            this.Igender.Size = new System.Drawing.Size(200, 23);
            this.Igender.TabIndex = 6;
            // 
            // Iname
            // 
            this.Iname.Location = new System.Drawing.Point(157, 103);
            this.Iname.Multiline = true;
            this.Iname.Name = "Iname";
            this.Iname.PlaceholderText = "full name...";
            this.Iname.Size = new System.Drawing.Size(200, 23);
            this.Iname.TabIndex = 7;
            // 
            // Ibirthdate
            // 
            this.Ibirthdate.Location = new System.Drawing.Point(157, 262);
            this.Ibirthdate.Name = "Ibirthdate";
            this.Ibirthdate.Size = new System.Drawing.Size(200, 23);
            this.Ibirthdate.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Birthdate :";
            // 
            // studentform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.Ibirthdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.create_student_btn);
            this.Controls.Add(this.Iage);
            this.Controls.Add(this.Igender);
            this.Controls.Add(this.Iname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "studentform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "studentform";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button create_student_btn;
        private TextBox Iage;
        private TextBox Igender;
        private TextBox Iname;
        private DateTimePicker Ibirthdate;
        private Label label5;
    }
}