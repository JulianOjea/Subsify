namespace SubsifyFrontend.Design.UserControls.Admin
{
    partial class AdminPlatformControl
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
            this.lv_platf = new System.Windows.Forms.ListView();
            this.bttn_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv_platf
            // 
            this.lv_platf.HideSelection = false;
            this.lv_platf.Location = new System.Drawing.Point(3, 34);
            this.lv_platf.Name = "lv_platf";
            this.lv_platf.Size = new System.Drawing.Size(658, 450);
            this.lv_platf.TabIndex = 1;
            this.lv_platf.UseCompatibleStateImageBehavior = false;
            // 
            // bttn_add
            // 
            this.bttn_add.Location = new System.Drawing.Point(556, 5);
            this.bttn_add.Name = "bttn_add";
            this.bttn_add.Size = new System.Drawing.Size(105, 23);
            this.bttn_add.TabIndex = 4;
            this.bttn_add.Text = "+ Nuevo";
            this.bttn_add.UseVisualStyleBackColor = true;
            this.bttn_add.UseWaitCursor = true;
            this.bttn_add.Click += new System.EventHandler(this.bttn_add_Click);
            // 
            // AdminPlatformControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bttn_add);
            this.Controls.Add(this.lv_platf);
            this.Name = "AdminPlatformControl";
            this.Size = new System.Drawing.Size(664, 487);
            this.Load += new System.EventHandler(this.AdminPlatformControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv_platf;
        private System.Windows.Forms.Button bttn_add;
    }
}
