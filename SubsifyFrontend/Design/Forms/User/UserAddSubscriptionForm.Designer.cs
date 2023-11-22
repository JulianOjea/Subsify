namespace SubsifyFrontend.Design.Forms.User
{
    partial class UserAddSubscriptionForm
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
            this.cb_platf_name = new System.Windows.Forms.ComboBox();
            this.cb_plan_name = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.cal_startDate = new System.Windows.Forms.MonthCalendar();
            this.label4 = new System.Windows.Forms.Label();
            this.bttn_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_platf_name
            // 
            this.cb_platf_name.FormattingEnabled = true;
            this.cb_platf_name.Location = new System.Drawing.Point(12, 25);
            this.cb_platf_name.Name = "cb_platf_name";
            this.cb_platf_name.Size = new System.Drawing.Size(213, 21);
            this.cb_platf_name.TabIndex = 0;
            this.cb_platf_name.SelectedIndexChanged += new System.EventHandler(this.cb_platf_name_SelectedIndexChanged);
            // 
            // cb_plan_name
            // 
            this.cb_plan_name.FormattingEnabled = true;
            this.cb_plan_name.Location = new System.Drawing.Point(12, 76);
            this.cb_plan_name.Name = "cb_plan_name";
            this.cb_plan_name.Size = new System.Drawing.Size(213, 21);
            this.cb_plan_name.TabIndex = 1;
            this.cb_plan_name.SelectedIndexChanged += new System.EventHandler(this.cb_plan_name_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Plataforma:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Plan de suscripción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Precio";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tb_price
            // 
            this.tb_price.Location = new System.Drawing.Point(11, 128);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(214, 20);
            this.tb_price.TabIndex = 5;
            // 
            // cal_startDate
            // 
            this.cal_startDate.Location = new System.Drawing.Point(18, 185);
            this.cal_startDate.Name = "cal_startDate";
            this.cal_startDate.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha de inicio";
            // 
            // bttn_ok
            // 
            this.bttn_ok.Location = new System.Drawing.Point(54, 359);
            this.bttn_ok.Name = "bttn_ok";
            this.bttn_ok.Size = new System.Drawing.Size(128, 39);
            this.bttn_ok.TabIndex = 8;
            this.bttn_ok.Text = "Confirmar";
            this.bttn_ok.UseVisualStyleBackColor = true;
            this.bttn_ok.Click += new System.EventHandler(this.bttn_ok_Click);
            // 
            // UserAddSubscriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 410);
            this.Controls.Add(this.bttn_ok);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cal_startDate);
            this.Controls.Add(this.tb_price);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_plan_name);
            this.Controls.Add(this.cb_platf_name);
            this.Name = "UserAddSubscriptionForm";
            this.Text = "Nueva Suscripcion";
            this.Load += new System.EventHandler(this.UserAddSubscriptionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_platf_name;
        private System.Windows.Forms.ComboBox cb_plan_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.MonthCalendar cal_startDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bttn_ok;
    }
}