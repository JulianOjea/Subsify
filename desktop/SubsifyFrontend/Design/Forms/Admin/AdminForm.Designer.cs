﻿namespace SubsifyFrontend.Design.Forms
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.bttn_planes = new System.Windows.Forms.Button();
            this.bttn_plataformas = new System.Windows.Forms.Button();
            this.uc_plans = new SubsifyFrontend.Design.UserControls.Admin.AdminPlanControl();
            this.uc_platf = new SubsifyFrontend.Design.UserControls.Admin.AdminPlatformControl();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bttn_planes
            // 
            this.bttn_planes.Image = ((System.Drawing.Image)(resources.GetObject("bttn_planes.Image")));
            this.bttn_planes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttn_planes.Location = new System.Drawing.Point(12, 63);
            this.bttn_planes.Name = "bttn_planes";
            this.bttn_planes.Size = new System.Drawing.Size(136, 41);
            this.bttn_planes.TabIndex = 2;
            this.bttn_planes.Text = "Planes";
            this.bttn_planes.UseVisualStyleBackColor = true;
            this.bttn_planes.Click += new System.EventHandler(this.bttn_planes_Click);
            // 
            // bttn_plataformas
            // 
            this.bttn_plataformas.Image = ((System.Drawing.Image)(resources.GetObject("bttn_plataformas.Image")));
            this.bttn_plataformas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttn_plataformas.Location = new System.Drawing.Point(12, 110);
            this.bttn_plataformas.Name = "bttn_plataformas";
            this.bttn_plataformas.Size = new System.Drawing.Size(136, 41);
            this.bttn_plataformas.TabIndex = 3;
            this.bttn_plataformas.Text = "Plataformas";
            this.bttn_plataformas.UseVisualStyleBackColor = true;
            this.bttn_plataformas.Click += new System.EventHandler(this.bttn_plataformas_Click);
            // 
            // uc_plans
            // 
            this.uc_plans.Location = new System.Drawing.Point(154, 31);
            this.uc_plans.Name = "uc_plans";
            this.uc_plans.request = null;
            this.uc_plans.Size = new System.Drawing.Size(674, 468);
            this.uc_plans.TabIndex = 4;
            this.uc_plans.Load += new System.EventHandler(this.adminPlanControl1_Load);
            // 
            // uc_platf
            // 
            this.uc_platf.Location = new System.Drawing.Point(154, 31);
            this.uc_platf.Name = "uc_platf";
            this.uc_platf.request = null;
            this.uc_platf.Size = new System.Drawing.Size(674, 468);
            this.uc_platf.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(3, 480);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(28, 29);
            this.button3.TabIndex = 7;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 511);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.bttn_plataformas);
            this.Controls.Add(this.bttn_planes);
            this.Controls.Add(this.uc_plans);
            this.Controls.Add(this.uc_platf);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttn_planes;
        private System.Windows.Forms.Button bttn_plataformas;
        private UserControls.Admin.AdminPlanControl uc_plans;
        private UserControls.Admin.AdminPlatformControl uc_platf;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}