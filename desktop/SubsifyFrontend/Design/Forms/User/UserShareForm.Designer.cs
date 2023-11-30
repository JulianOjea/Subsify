namespace SubsifyFrontend.Design.Forms.User
{
    partial class UserShareForm
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
            this.cb_users = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bttn_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_users
            // 
            this.cb_users.FormattingEnabled = true;
            this.cb_users.Location = new System.Drawing.Point(41, 49);
            this.cb_users.Name = "cb_users";
            this.cb_users.Size = new System.Drawing.Size(164, 21);
            this.cb_users.TabIndex = 0;
            this.cb_users.SelectedIndexChanged += new System.EventHandler(this.cb_users_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecciona usuario para compartir:";
            // 
            // bttn_ok
            // 
            this.bttn_ok.Location = new System.Drawing.Point(41, 96);
            this.bttn_ok.Name = "bttn_ok";
            this.bttn_ok.Size = new System.Drawing.Size(164, 23);
            this.bttn_ok.TabIndex = 2;
            this.bttn_ok.Text = "Confirmar";
            this.bttn_ok.UseVisualStyleBackColor = true;
            this.bttn_ok.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserShareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 203);
            this.Controls.Add(this.bttn_ok);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_users);
            this.Name = "UserShareForm";
            this.Text = "UserShareForm";
            this.Load += new System.EventHandler(this.UserShareForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_users;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttn_ok;
    }
}