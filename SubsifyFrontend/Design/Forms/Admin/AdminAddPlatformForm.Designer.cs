namespace SubsifyFrontend.Design.Forms.Admin
{
    partial class AdminAddPlatformForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_category = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_link = new System.Windows.Forms.TextBox();
            this.bttn_ok = new System.Windows.Forms.Button();
            this.tb_platf_name = new System.Windows.Forms.TextBox();
            this.imgDialog = new System.Windows.Forms.OpenFileDialog();
            this.bttn_image_select = new System.Windows.Forms.Button();
            this.pb_image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Plataforma:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Categoria";
            // 
            // cb_category
            // 
            this.cb_category.FormattingEnabled = true;
            this.cb_category.Location = new System.Drawing.Point(12, 65);
            this.cb_category.Name = "cb_category";
            this.cb_category.Size = new System.Drawing.Size(213, 21);
            this.cb_category.TabIndex = 5;
            this.cb_category.SelectedIndexChanged += new System.EventHandler(this.cb_category_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Enlace";
            // 
            // tb_link
            // 
            this.tb_link.Location = new System.Drawing.Point(12, 105);
            this.tb_link.Name = "tb_link";
            this.tb_link.Size = new System.Drawing.Size(213, 20);
            this.tb_link.TabIndex = 8;
            // 
            // bttn_ok
            // 
            this.bttn_ok.Location = new System.Drawing.Point(74, 276);
            this.bttn_ok.Name = "bttn_ok";
            this.bttn_ok.Size = new System.Drawing.Size(75, 23);
            this.bttn_ok.TabIndex = 9;
            this.bttn_ok.Text = "Confirmar";
            this.bttn_ok.UseVisualStyleBackColor = true;
            this.bttn_ok.Click += new System.EventHandler(this.bttn_ok_Click);
            // 
            // tb_platf_name
            // 
            this.tb_platf_name.Location = new System.Drawing.Point(15, 26);
            this.tb_platf_name.Name = "tb_platf_name";
            this.tb_platf_name.Size = new System.Drawing.Size(213, 20);
            this.tb_platf_name.TabIndex = 10;
            // 
            // imgDialog
            // 
            this.imgDialog.FileName = "openFileDialog1";
            this.imgDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // bttn_image_select
            // 
            this.bttn_image_select.Location = new System.Drawing.Point(12, 141);
            this.bttn_image_select.Name = "bttn_image_select";
            this.bttn_image_select.Size = new System.Drawing.Size(115, 23);
            this.bttn_image_select.TabIndex = 11;
            this.bttn_image_select.Text = "Seleccionar imagen";
            this.bttn_image_select.UseVisualStyleBackColor = true;
            this.bttn_image_select.Click += new System.EventHandler(this.bttn_image_select_Click);
            // 
            // pb_image
            // 
            this.pb_image.Location = new System.Drawing.Point(63, 170);
            this.pb_image.Name = "pb_image";
            this.pb_image.Size = new System.Drawing.Size(100, 100);
            this.pb_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_image.TabIndex = 12;
            this.pb_image.TabStop = false;
            // 
            // AdminAddPlatformForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 303);
            this.Controls.Add(this.pb_image);
            this.Controls.Add(this.bttn_image_select);
            this.Controls.Add(this.tb_platf_name);
            this.Controls.Add(this.bttn_ok);
            this.Controls.Add(this.tb_link);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_category);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdminAddPlatformForm";
            this.Text = "AdminAddPlatformForm";
            this.Load += new System.EventHandler(this.AdminAddPlatformForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_category;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_link;
        private System.Windows.Forms.Button bttn_ok;
        private System.Windows.Forms.TextBox tb_platf_name;
        private System.Windows.Forms.OpenFileDialog imgDialog;
        private System.Windows.Forms.Button bttn_image_select;
        private System.Windows.Forms.PictureBox pb_image;
    }
}