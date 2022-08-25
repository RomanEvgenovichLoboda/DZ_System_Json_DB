namespace DZ_System_Json_DB
{
    partial class FormRegistr
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
            this.button_Autorisation = new System.Windows.Forms.Button();
            this.button_Registration = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Login = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_Autorisation
            // 
            this.button_Autorisation.Location = new System.Drawing.Point(18, 146);
            this.button_Autorisation.Name = "button_Autorisation";
            this.button_Autorisation.Size = new System.Drawing.Size(127, 29);
            this.button_Autorisation.TabIndex = 0;
            this.button_Autorisation.Text = "Autorisation";
            this.button_Autorisation.UseVisualStyleBackColor = true;
            this.button_Autorisation.Click += new System.EventHandler(this.button_Autorisation_Click);
            // 
            // button_Registration
            // 
            this.button_Registration.Location = new System.Drawing.Point(180, 146);
            this.button_Registration.Name = "button_Registration";
            this.button_Registration.Size = new System.Drawing.Size(122, 29);
            this.button_Registration.TabIndex = 1;
            this.button_Registration.Text = "Registration";
            this.button_Registration.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // textBox_Login
            // 
            this.textBox_Login.Location = new System.Drawing.Point(115, 30);
            this.textBox_Login.Name = "textBox_Login";
            this.textBox_Login.Size = new System.Drawing.Size(187, 27);
            this.textBox_Login.TabIndex = 4;
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(115, 78);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(187, 27);
            this.textBox_Password.TabIndex = 5;
            // 
            // FormRegistr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 198);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_Login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Registration);
            this.Controls.Add(this.button_Autorisation);
            this.Name = "FormRegistr";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormRegistr_FormClosed);
            this.Load += new System.EventHandler(this.FormRegistr_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_Autorisation;
        private Button button_Registration;
        private Label label1;
        private Label label2;
        private TextBox textBox_Login;
        private TextBox textBox_Password;
    }
}