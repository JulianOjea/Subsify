namespace SubsifyFrontend.Design.Forms.Admin
{
    partial class AdminAddPlanForm
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
            this.cb_platform = new System.Windows.Forms.ComboBox();
            this.tb_plan_name = new System.Windows.Forms.TextBox();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.cal_start_date = new System.Windows.Forms.MonthCalendar();
            this.cb_freq = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bttn_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_platform
            // 
            this.cb_platform.FormattingEnabled = true;
            this.cb_platform.Location = new System.Drawing.Point(12, 30);
            this.cb_platform.Name = "cb_platform";
            this.cb_platform.Size = new System.Drawing.Size(224, 21);
            this.cb_platform.TabIndex = 0;
            this.cb_platform.SelectedIndexChanged += new System.EventHandler(this.cb_platform_SelectedIndexChanged);
            // 
            // tb_plan_name
            // 
            this.tb_plan_name.Location = new System.Drawing.Point(12, 74);
            this.tb_plan_name.Name = "tb_plan_name";
            this.tb_plan_name.Size = new System.Drawing.Size(224, 20);
            this.tb_plan_name.TabIndex = 1;
            // 
            // tb_price
            // 
            this.tb_price.Location = new System.Drawing.Point(12, 117);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(224, 20);
            this.tb_price.TabIndex = 2;
            // 
            // cal_start_date
            // 
            this.cal_start_date.Location = new System.Drawing.Point(28, 157);
            this.cal_start_date.Name = "cal_start_date";
            this.cal_start_date.TabIndex = 3;
            // 
            // cb_freq
            // 
            this.cb_freq.FormattingEnabled = true;
            this.cb_freq.Location = new System.Drawing.Point(12, 344);
            this.cb_freq.Name = "cb_freq";
            this.cb_freq.Size = new System.Drawing.Size(224, 21);
            this.cb_freq.TabIndex = 4;
            this.cb_freq.SelectedIndexChanged += new System.EventHandler(this.cb_freq_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Plataforma";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Plan de suscripción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fecha de inicio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Frecuencia";
            // 
            // bttn_ok
            // 
            this.bttn_ok.Location = new System.Drawing.Point(68, 381);
            this.bttn_ok.Name = "bttn_ok";
            this.bttn_ok.Size = new System.Drawing.Size(106, 36);
            this.bttn_ok.TabIndex = 10;
            this.bttn_ok.Text = "Confirmar";
            this.bttn_ok.UseVisualStyleBackColor = true;
            this.bttn_ok.Click += new System.EventHandler(this.bttn_ok_Click);
            // 
            // AdminAddPlanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 429);
            this.Controls.Add(this.bttn_ok);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_freq);
            this.Controls.Add(this.cal_start_date);
            this.Controls.Add(this.tb_price);
            this.Controls.Add(this.tb_plan_name);
            this.Controls.Add(this.cb_platform);
            this.Name = "AdminAddPlanForm";
            this.Text = "AdminAddPlanForm";
            this.Load += new System.EventHandler(this.AdminAddPlanForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_platform;
        private System.Windows.Forms.TextBox tb_plan_name;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.MonthCalendar cal_start_date;
        private System.Windows.Forms.ComboBox cb_freq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bttn_ok;
    }
}