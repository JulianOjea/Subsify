namespace SubsifyFrontend.Design.Forms
{
    partial class SignUpForm
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
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.tb_pass_confirm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bttn_sign_up = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(26, 51);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(151, 20);
            this.tb_username.TabIndex = 0;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(26, 90);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(151, 20);
            this.tb_email.TabIndex = 1;
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(26, 129);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(151, 20);
            this.tb_pass.TabIndex = 2;
            // 
            // tb_pass_confirm
            // 
            this.tb_pass_confirm.Location = new System.Drawing.Point(26, 168);
            this.tb_pass_confirm.Name = "tb_pass_confirm";
            this.tb_pass_confirm.PasswordChar = '*';
            this.tb_pass_confirm.Size = new System.Drawing.Size(151, 20);
            this.tb_pass_confirm.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Confirmar Contraseña";
            // 
            // bttn_sign_up
            // 
            this.bttn_sign_up.BackColor = System.Drawing.Color.White;
            this.bttn_sign_up.ForeColor = System.Drawing.SystemColors.Window;
            this.bttn_sign_up.Location = new System.Drawing.Point(26, 203);
            this.bttn_sign_up.Name = "bttn_sign_up";
            this.bttn_sign_up.Size = new System.Drawing.Size(151, 42);
            this.bttn_sign_up.TabIndex = 8;
            this.bttn_sign_up.Text = "Registrarse";
            this.bttn_sign_up.UseVisualStyleBackColor = false;
            this.bttn_sign_up.Click += new System.EventHandler(this.bttn_sign_up_Click);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 270);
            this.Controls.Add(this.bttn_sign_up);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_pass_confirm);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_username);
            this.Name = "SignUpForm";
            this.Text = "Registrarse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.TextBox tb_pass_confirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bttn_sign_up;
    }
}