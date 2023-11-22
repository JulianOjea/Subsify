namespace SubsifyFrontend
{
    partial class UserHomeControl
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
            this.flp_cards = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flp_cards
            // 
            this.flp_cards.AutoScroll = true;
            this.flp_cards.Location = new System.Drawing.Point(3, 3);
            this.flp_cards.Name = "flp_cards";
            this.flp_cards.Size = new System.Drawing.Size(746, 448);
            this.flp_cards.TabIndex = 0;
            this.flp_cards.Paint += new System.Windows.Forms.PaintEventHandler(this.flp_cards_Paint);
            // 
            // UserHomeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flp_cards);
            this.Name = "UserHomeControl";
            this.Size = new System.Drawing.Size(749, 451);
            this.Load += new System.EventHandler(this.UserHomeControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp_cards;
    }
}
