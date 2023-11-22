namespace SubsifyFrontend
{
    partial class UserSubscriptionControl
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
            this.lv_subscriptions = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_total_price = new System.Windows.Forms.Label();
            this.bttn_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv_subscriptions
            // 
            this.lv_subscriptions.HideSelection = false;
            this.lv_subscriptions.Location = new System.Drawing.Point(119, 57);
            this.lv_subscriptions.Name = "lv_subscriptions";
            this.lv_subscriptions.Size = new System.Drawing.Size(462, 393);
            this.lv_subscriptions.TabIndex = 0;
            this.lv_subscriptions.UseCompatibleStateImageBehavior = false;
            this.lv_subscriptions.SelectedIndexChanged += new System.EventHandler(this.lv_subscriptions_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mis suscripciones";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_total_price
            // 
            this.lbl_total_price.AutoSize = true;
            this.lbl_total_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_price.Location = new System.Drawing.Point(409, 462);
            this.lbl_total_price.Name = "lbl_total_price";
            this.lbl_total_price.Size = new System.Drawing.Size(174, 13);
            this.lbl_total_price.TabIndex = 2;
            this.lbl_total_price.Text = "Gasto mensual total: XX.XX €";
            this.lbl_total_price.Click += new System.EventHandler(this.lbl_total_price_Click);
            // 
            // bttn_add
            // 
            this.bttn_add.Location = new System.Drawing.Point(476, 28);
            this.bttn_add.Name = "bttn_add";
            this.bttn_add.Size = new System.Drawing.Size(105, 23);
            this.bttn_add.TabIndex = 3;
            this.bttn_add.Text = "+ Nuevo";
            this.bttn_add.UseVisualStyleBackColor = true;
            this.bttn_add.UseWaitCursor = true;
            this.bttn_add.Click += new System.EventHandler(this.bttn_add_Click);
            // 
            // UserSubscriptionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bttn_add);
            this.Controls.Add(this.lbl_total_price);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lv_subscriptions);
            this.Name = "UserSubscriptionControl";
            this.Size = new System.Drawing.Size(586, 536);
            this.Load += new System.EventHandler(this.UserSubscriptionControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_subscriptions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_total_price;
        private System.Windows.Forms.Button bttn_add;
    }
}
