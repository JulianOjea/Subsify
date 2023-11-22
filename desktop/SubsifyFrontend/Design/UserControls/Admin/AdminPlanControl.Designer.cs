namespace SubsifyFrontend.Design.UserControls.Admin
{
    partial class AdminPlanControl
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
            this.lv_plan = new System.Windows.Forms.ListView();
            this.bttn_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv_plan
            // 
            this.lv_plan.HideSelection = false;
            this.lv_plan.Location = new System.Drawing.Point(3, 32);
            this.lv_plan.Name = "lv_plan";
            this.lv_plan.Size = new System.Drawing.Size(658, 452);
            this.lv_plan.TabIndex = 0;
            this.lv_plan.UseCompatibleStateImageBehavior = false;
            // 
            // bttn_add
            // 
            this.bttn_add.Location = new System.Drawing.Point(556, 3);
            this.bttn_add.Name = "bttn_add";
            this.bttn_add.Size = new System.Drawing.Size(105, 23);
            this.bttn_add.TabIndex = 5;
            this.bttn_add.Text = "+ Nuevo";
            this.bttn_add.UseVisualStyleBackColor = true;
            this.bttn_add.UseWaitCursor = true;
            this.bttn_add.Click += new System.EventHandler(this.bttn_add_Click);
            // 
            // AdminPlanControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bttn_add);
            this.Controls.Add(this.lv_plan);
            this.Name = "AdminPlanControl";
            this.Size = new System.Drawing.Size(664, 487);
            this.Load += new System.EventHandler(this.AdminPlanControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv_plan;
        private System.Windows.Forms.Button bttn_add;
    }
}
