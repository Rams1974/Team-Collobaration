
namespace BMU_projrct55
{
    partial class frmDBsetting
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
            this.lblDBsetting = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDbconnection = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserId = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtdataSource = new System.Windows.Forms.TextBox();
            this.lblDatasorce = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDBsetting
            // 
            this.lblDBsetting.AutoSize = true;
            this.lblDBsetting.BackColor = System.Drawing.Color.Wheat;
            this.lblDBsetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDBsetting.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblDBsetting.Location = new System.Drawing.Point(159, 9);
            this.lblDBsetting.Name = "lblDBsetting";
            this.lblDBsetting.Size = new System.Drawing.Size(460, 108);
            this.lblDBsetting.TabIndex = 0;
            this.lblDBsetting.Text = "DBsetting";
            this.lblDBsetting.Click += new System.EventHandler(this.label1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(109, 180);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(117, 28);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "SQLserver";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.radioButton2.Location = new System.Drawing.Point(109, 216);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(138, 28);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "MSSqlServer";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDbconnection);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.lblUserId);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.txtdataSource);
            this.panel1.Controls.Add(this.lblDatasorce);
            this.panel1.Location = new System.Drawing.Point(358, 155);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 213);
            this.panel1.TabIndex = 3;
            // 
            // btnDbconnection
            // 
            this.btnDbconnection.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnDbconnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDbconnection.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnDbconnection.Location = new System.Drawing.Point(137, 140);
            this.btnDbconnection.Name = "btnDbconnection";
            this.btnDbconnection.Size = new System.Drawing.Size(204, 23);
            this.btnDbconnection.TabIndex = 6;
            this.btnDbconnection.Text = "Test DB connection";
            this.btnDbconnection.UseVisualStyleBackColor = false;
            this.btnDbconnection.Click += new System.EventHandler(this.btnDbconnection_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPassword.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(31, 111);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(78, 23);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password";
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUserId.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserId.Location = new System.Drawing.Point(31, 66);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(55, 23);
            this.lblUserId.TabIndex = 4;
            this.lblUserId.Text = "UserId";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(137, 113);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(204, 21);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(137, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 21);
            this.textBox1.TabIndex = 2;
            // 
            // txtdataSource
            // 
            this.txtdataSource.Location = new System.Drawing.Point(137, 25);
            this.txtdataSource.Name = "txtdataSource";
            this.txtdataSource.Size = new System.Drawing.Size(204, 21);
            this.txtdataSource.TabIndex = 1;
            // 
            // lblDatasorce
            // 
            this.lblDatasorce.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.lblDatasorce.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDatasorce.AutoSize = true;
            this.lblDatasorce.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDatasorce.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatasorce.Location = new System.Drawing.Point(31, 23);
            this.lblDatasorce.Name = "lblDatasorce";
            this.lblDatasorce.Size = new System.Drawing.Size(91, 23);
            this.lblDatasorce.TabIndex = 0;
            this.lblDatasorce.Text = "DataSource";
            // 
            // frmDBsetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(979, 449);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.lblDBsetting);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmDBsetting";
            this.Text = "frmDBsetting";
            this.Load += new System.EventHandler(this.frmDBsetting_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDBsetting;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtdataSource;
        private System.Windows.Forms.Label lblDatasorce;
        private System.Windows.Forms.Button btnDbconnection;
    }
}