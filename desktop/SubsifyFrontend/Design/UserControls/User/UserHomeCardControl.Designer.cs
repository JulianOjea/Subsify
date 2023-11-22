namespace SubsifyFrontend.Design.UserControls.User
{
    partial class UserHomeCardControl
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pb_PLATF_IMAGE = new System.Windows.Forms.PictureBox();
            this.lbl_platf_name = new System.Windows.Forms.Label();
            this.lbl_end = new System.Windows.Forms.Label();
            this.lbl_renew = new System.Windows.Forms.Label();
            this.bttn_cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_PLATF_IMAGE)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_PLATF_IMAGE
            // 
            this.pb_PLATF_IMAGE.Location = new System.Drawing.Point(25, 12);
            this.pb_PLATF_IMAGE.Name = "pb_PLATF_IMAGE";
            this.pb_PLATF_IMAGE.Size = new System.Drawing.Size(100, 100);
            this.pb_PLATF_IMAGE.TabIndex = 0;
            this.pb_PLATF_IMAGE.TabStop = false;
            // 
            // lbl_platf_name
            // 
            this.lbl_platf_name.Location = new System.Drawing.Point(35, 115);
            this.lbl_platf_name.Name = "lbl_platf_name";
            this.lbl_platf_name.Size = new System.Drawing.Size(75, 13);
            this.lbl_platf_name.TabIndex = 1;
            this.lbl_platf_name.Text = "lbl_platf_name";
            this.lbl_platf_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_end
            // 
            this.lbl_end.AutoSize = true;
            this.lbl_end.Location = new System.Drawing.Point(11, 138);
            this.lbl_end.Name = "lbl_end";
            this.lbl_end.Size = new System.Drawing.Size(128, 13);
            this.lbl_end.TabIndex = 2;
            this.lbl_end.Text = "Termina el D MMM YYYY";
            this.lbl_end.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_renew
            // 
            this.lbl_renew.Location = new System.Drawing.Point(14, 162);
            this.lbl_renew.Name = "lbl_renew";
            this.lbl_renew.Size = new System.Drawing.Size(118, 13);
            this.lbl_renew.TabIndex = 3;
            this.lbl_renew.Text = "Se renueva en XX días";
            this.lbl_renew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bttn_cancelar
            // 
            this.bttn_cancelar.BackColor = System.Drawing.Color.IndianRed;
            this.bttn_cancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bttn_cancelar.Location = new System.Drawing.Point(28, 183);
            this.bttn_cancelar.Name = "bttn_cancelar";
            this.bttn_cancelar.Size = new System.Drawing.Size(90, 29);
            this.bttn_cancelar.TabIndex = 4;
            this.bttn_cancelar.Text = "Cancelar";
            this.bttn_cancelar.UseVisualStyleBackColor = false;
            this.bttn_cancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserHomeCardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bttn_cancelar);
            this.Controls.Add(this.lbl_renew);
            this.Controls.Add(this.lbl_end);
            this.Controls.Add(this.lbl_platf_name);
            this.Controls.Add(this.pb_PLATF_IMAGE);
            this.Name = "UserHomeCardControl";
            this.Size = new System.Drawing.Size(145, 226);
            this.Load += new System.EventHandler(this.UserHomeCardControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_PLATF_IMAGE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_PLATF_IMAGE;
        private System.Windows.Forms.Label lbl_platf_name;
        private System.Windows.Forms.Label lbl_end;
        private System.Windows.Forms.Label lbl_renew;
        private System.Windows.Forms.Button bttn_cancelar;
    }
}
