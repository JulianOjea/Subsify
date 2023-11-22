namespace SubsifyFrontend
{
    partial class UserSubscriptionDetailsControl
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
            this.components = new System.ComponentModel.Container();
            this.tb_freq_name = new System.Windows.Forms.TextBox();
            this.tb_start = new System.Windows.Forms.TextBox();
            this.tb_end = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_renew = new System.Windows.Forms.CheckBox();
            this.bttn_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_freq_name
            // 
            this.tb_freq_name.Location = new System.Drawing.Point(17, 36);
            this.tb_freq_name.Name = "tb_freq_name";
            this.tb_freq_name.Size = new System.Drawing.Size(153, 20);
            this.tb_freq_name.TabIndex = 0;
            this.tb_freq_name.TextChanged += new System.EventHandler(this.tb_freq_name_TextChanged);
            // 
            // tb_start
            // 
            this.tb_start.Location = new System.Drawing.Point(17, 75);
            this.tb_start.Name = "tb_start";
            this.tb_start.Size = new System.Drawing.Size(153, 20);
            this.tb_start.TabIndex = 1;
            this.tb_start.TextChanged += new System.EventHandler(this.tb_start_TextChanged);
            // 
            // tb_end
            // 
            this.tb_end.Location = new System.Drawing.Point(17, 114);
            this.tb_end.Name = "tb_end";
            this.tb_end.Size = new System.Drawing.Size(153, 20);
            this.tb_end.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Frecuencia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Próxima renovación";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Inicio";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cb_renew
            // 
            this.cb_renew.AutoSize = true;
            this.cb_renew.Location = new System.Drawing.Point(17, 140);
            this.cb_renew.Name = "cb_renew";
            this.cb_renew.Size = new System.Drawing.Size(67, 17);
            this.cb_renew.TabIndex = 14;
            this.cb_renew.Text = "Renovar";
            this.cb_renew.UseVisualStyleBackColor = true;
            this.cb_renew.Click += new System.EventHandler(this.cb_renew_Click);
            // 
            // bttn_save
            // 
            this.bttn_save.Location = new System.Drawing.Point(17, 163);
            this.bttn_save.Name = "bttn_save";
            this.bttn_save.Size = new System.Drawing.Size(153, 23);
            this.bttn_save.TabIndex = 15;
            this.bttn_save.Text = "Guardar";
            this.bttn_save.UseVisualStyleBackColor = true;
            this.bttn_save.Click += new System.EventHandler(this.bttn_save_Click);
            // 
            // UserSubscriptionDetailsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bttn_save);
            this.Controls.Add(this.cb_renew);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_end);
            this.Controls.Add(this.tb_start);
            this.Controls.Add(this.tb_freq_name);
            this.Name = "UserSubscriptionDetailsControl";
            this.Size = new System.Drawing.Size(185, 203);
            this.Load += new System.EventHandler(this.UserSubscriptionDetailsControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_freq_name;
        private System.Windows.Forms.TextBox tb_start;
        private System.Windows.Forms.TextBox tb_end;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cb_renew;
        private System.Windows.Forms.Button bttn_save;
    }
}
