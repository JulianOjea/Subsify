namespace SubsifyFrontend
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.userSubscriptionControl1 = new SubsifyFrontend.UserSubscriptionControl();
            this.userHomeControl1 = new SubsifyFrontend.UserHomeControl();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "bttn_home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 164);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "bttn_subscription";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // userSubscriptionControl1
            // 
            this.userSubscriptionControl1.Location = new System.Drawing.Point(136, 23);
            this.userSubscriptionControl1.Name = "userSubscriptionControl1";
            this.userSubscriptionControl1.Size = new System.Drawing.Size(652, 395);
            this.userSubscriptionControl1.TabIndex = 3;
            // 
            // userHomeControl1
            // 
            this.userHomeControl1.Location = new System.Drawing.Point(154, 34);
            this.userHomeControl1.Name = "userHomeControl1";
            this.userHomeControl1.Size = new System.Drawing.Size(634, 384);
            this.userHomeControl1.TabIndex = 4;
            this.userHomeControl1.Load += new System.EventHandler(this.userHomeControl1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userHomeControl1);
            this.Controls.Add(this.userSubscriptionControl1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_LoadAsync);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private UserSubscriptionControl userSubscriptionControl1;
        private UserHomeControl userHomeControl1;
    }
}

