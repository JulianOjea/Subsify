namespace SubsifyFrontend
{
    partial class UserHomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserHomeForm));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.userSubscriptionDetailsControl1 = new SubsifyFrontend.UserSubscriptionDetailsControl();
            this.userSubscriptionControl1 = new SubsifyFrontend.UserSubscriptionControl();
            this.userHomeControl1 = new SubsifyFrontend.UserHomeControl();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "bttn_home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 42);
            this.button2.TabIndex = 2;
            this.button2.Text = "bttn_subscription";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // userSubscriptionDetailsControl1
            // 
            this.userSubscriptionDetailsControl1.Location = new System.Drawing.Point(625, 23);
            this.userSubscriptionDetailsControl1.Name = "userSubscriptionDetailsControl1";
            this.userSubscriptionDetailsControl1.Size = new System.Drawing.Size(200, 429);
            this.userSubscriptionDetailsControl1.TabIndex = 5;
            this.userSubscriptionDetailsControl1.Load += new System.EventHandler(this.userSubscriptionDetailsControl1_Load);
            // 
            // userSubscriptionControl1
            // 
            this.userSubscriptionControl1.detailsControl = null;
            this.userSubscriptionControl1.Location = new System.Drawing.Point(38, 3);
            this.userSubscriptionControl1.Name = "userSubscriptionControl1";
            this.userSubscriptionControl1.request = null;
            this.userSubscriptionControl1.Size = new System.Drawing.Size(591, 510);
            this.userSubscriptionControl1.TabIndex = 3;
            this.userSubscriptionControl1.total_price = 0D;
            this.userSubscriptionControl1.Load += new System.EventHandler(this.userSubscriptionControl1_Load);
            // 
            // userHomeControl1
            // 
            this.userHomeControl1.Location = new System.Drawing.Point(154, 12);
            this.userHomeControl1.Name = "userHomeControl1";
            this.userHomeControl1.Size = new System.Drawing.Size(671, 501);
            this.userHomeControl1.TabIndex = 4;
            this.userHomeControl1.Load += new System.EventHandler(this.userHomeControl1_Load);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(4, 479);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(28, 29);
            this.button3.TabIndex = 6;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 511);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.userSubscriptionControl1);
            this.Controls.Add(this.userSubscriptionDetailsControl1);
            this.Controls.Add(this.userHomeControl1);
            this.Name = "MainForm";
            this.Text = "Subsify";
            this.Load += new System.EventHandler(this.Form1_LoadAsync);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private UserSubscriptionControl userSubscriptionControl1;
        private UserHomeControl userHomeControl1;
        private UserSubscriptionDetailsControl userSubscriptionDetailsControl1;
        private System.Windows.Forms.Button button3;
    }
}

