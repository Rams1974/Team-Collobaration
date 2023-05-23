
namespace BMU_projrct55
{
    partial class FrmDB_preparation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDB_preparation));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDBsetting = new System.Windows.Forms.TabPage();
            this.tabDBPreparation = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabLanguages = new System.Windows.Forms.TabPage();
            this.dgvLanguageInfo = new System.Windows.Forms.DataGridView();
            this.langID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblFont = new System.Windows.Forms.Label();
            this.lblLangName = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtLangid = new System.Windows.Forms.TextBox();
            this.lblLangid = new System.Windows.Forms.Label();
            this.tabCharacterMap = new System.Windows.Forms.TabPage();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblHint = new System.Windows.Forms.Label();
            this.txtcharacter = new System.Windows.Forms.TextBox();
            this.lblCharacter = new System.Windows.Forms.Label();
            this.txtUnicode = new System.Windows.Forms.TextBox();
            this.lblUnicode = new System.Windows.Forms.Label();
            this.comboBoxLanguageSelection = new System.Windows.Forms.ComboBox();
            this.lblLanguageSelection = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabMessages = new System.Windows.Forms.TabPage();
            this.tabStations = new System.Windows.Forms.TabPage();
            this.tabTrains = new System.Windows.Forms.TabPage();
            this.tabRakePreparation = new System.Windows.Forms.TabPage();
            this.Editsavebtn = new System.Windows.Forms.Button();
            this.Clearbtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabDBPreparation.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabLanguages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLanguageInfo)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabCharacterMap.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDBsetting);
            this.tabControl1.Controls.Add(this.tabDBPreparation);
            this.tabControl1.Controls.Add(this.tabRakePreparation);
            this.tabControl1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1257, 466);
            this.tabControl1.TabIndex = 0;
            // 
            // tabDBsetting
            // 
            this.tabDBsetting.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDBsetting.Location = new System.Drawing.Point(4, 28);
            this.tabDBsetting.Name = "tabDBsetting";
            this.tabDBsetting.Padding = new System.Windows.Forms.Padding(3);
            this.tabDBsetting.Size = new System.Drawing.Size(1265, 477);
            this.tabDBsetting.TabIndex = 0;
            this.tabDBsetting.Text = "DBSetting";
            this.tabDBsetting.UseVisualStyleBackColor = true;
            this.tabDBsetting.Click += new System.EventHandler(this.tabDBsetting_Click);
            // 
            // tabDBPreparation
            // 
            this.tabDBPreparation.Controls.Add(this.tabControl2);
            this.tabDBPreparation.Location = new System.Drawing.Point(4, 28);
            this.tabDBPreparation.Name = "tabDBPreparation";
            this.tabDBPreparation.Padding = new System.Windows.Forms.Padding(3);
            this.tabDBPreparation.Size = new System.Drawing.Size(1249, 434);
            this.tabDBPreparation.TabIndex = 1;
            this.tabDBPreparation.Text = "DBPreparation";
            this.tabDBPreparation.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabLanguages);
            this.tabControl2.Controls.Add(this.tabCharacterMap);
            this.tabControl2.Controls.Add(this.tabMessages);
            this.tabControl2.Controls.Add(this.tabStations);
            this.tabControl2.Controls.Add(this.tabTrains);
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1243, 428);
            this.tabControl2.TabIndex = 0;
            // 
            // tabLanguages
            // 
            this.tabLanguages.Controls.Add(this.Clearbtn);
            this.tabLanguages.Controls.Add(this.Editsavebtn);
            this.tabLanguages.Controls.Add(this.dgvLanguageInfo);
            this.tabLanguages.Controls.Add(this.panel1);
            this.tabLanguages.Location = new System.Drawing.Point(4, 28);
            this.tabLanguages.Name = "tabLanguages";
            this.tabLanguages.Padding = new System.Windows.Forms.Padding(3);
            this.tabLanguages.Size = new System.Drawing.Size(1235, 396);
            this.tabLanguages.TabIndex = 0;
            this.tabLanguages.Text = "Languages";
            this.tabLanguages.UseVisualStyleBackColor = true;
            // 
            // dgvLanguageInfo
            // 
            this.dgvLanguageInfo.AllowUserToOrderColumns = true;
            this.dgvLanguageInfo.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvLanguageInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLanguageInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.langID,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column1,
            this.Column7});
            this.dgvLanguageInfo.Location = new System.Drawing.Point(6, 116);
            this.dgvLanguageInfo.Name = "dgvLanguageInfo";
            this.dgvLanguageInfo.Size = new System.Drawing.Size(885, 277);
            this.dgvLanguageInfo.TabIndex = 1;
            this.dgvLanguageInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // langID
            // 
            this.langID.HeaderText = "langID";
            this.langID.Name = "langID";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Lang Code";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Lang Name";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Font Name";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Font Size";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Font Type";
            this.Column6.Name = "Column6";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Add/Edit";
            this.Column1.Image = ((System.Drawing.Image)(resources.GetObject("Column1.Image")));
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Delete";
            this.Column7.Image = ((System.Drawing.Image)(resources.GetObject("Column7.Image")));
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.lblFont);
            this.panel1.Controls.Add(this.lblLangName);
            this.panel1.Controls.Add(this.lblCode);
            this.panel1.Controls.Add(this.txtLangid);
            this.panel1.Controls.Add(this.lblLangid);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1236, 110);
            this.panel1.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1010, 53);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(169, 27);
            this.textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(753, 51);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(169, 27);
            this.textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(447, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 27);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblFont
            // 
            this.lblFont.AutoSize = true;
            this.lblFont.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFont.Location = new System.Drawing.Point(947, 54);
            this.lblFont.Name = "lblFont";
            this.lblFont.Size = new System.Drawing.Size(57, 26);
            this.lblFont.TabIndex = 4;
            this.lblFont.Text = "Font:";
            // 
            // lblLangName
            // 
            this.lblLangName.AutoSize = true;
            this.lblLangName.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLangName.Location = new System.Drawing.Point(632, 51);
            this.lblLangName.Name = "lblLangName";
            this.lblLangName.Size = new System.Drawing.Size(115, 26);
            this.lblLangName.TabIndex = 3;
            this.lblLangName.Text = "Lang Name:";
            this.lblLangName.Click += new System.EventHandler(this.lblLangName_Click);
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(321, 50);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(107, 26);
            this.lblCode.TabIndex = 2;
            this.lblCode.Text = "Lang Code:";
            // 
            // txtLangid
            // 
            this.txtLangid.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtLangid.Location = new System.Drawing.Point(129, 50);
            this.txtLangid.Name = "txtLangid";
            this.txtLangid.Size = new System.Drawing.Size(168, 27);
            this.txtLangid.TabIndex = 1;
            // 
            // lblLangid
            // 
            this.lblLangid.AutoSize = true;
            this.lblLangid.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLangid.Location = new System.Drawing.Point(42, 50);
            this.lblLangid.Name = "lblLangid";
            this.lblLangid.Size = new System.Drawing.Size(82, 26);
            this.lblLangid.TabIndex = 0;
            this.lblLangid.Text = "Lang ID:";
            // 
            // tabCharacterMap
            // 
            this.tabCharacterMap.Controls.Add(this.textBox4);
            this.tabCharacterMap.Controls.Add(this.lblHint);
            this.tabCharacterMap.Controls.Add(this.txtcharacter);
            this.tabCharacterMap.Controls.Add(this.lblCharacter);
            this.tabCharacterMap.Controls.Add(this.txtUnicode);
            this.tabCharacterMap.Controls.Add(this.lblUnicode);
            this.tabCharacterMap.Controls.Add(this.comboBoxLanguageSelection);
            this.tabCharacterMap.Controls.Add(this.lblLanguageSelection);
            this.tabCharacterMap.Controls.Add(this.panel3);
            this.tabCharacterMap.Controls.Add(this.panel2);
            this.tabCharacterMap.Location = new System.Drawing.Point(4, 28);
            this.tabCharacterMap.Name = "tabCharacterMap";
            this.tabCharacterMap.Padding = new System.Windows.Forms.Padding(3);
            this.tabCharacterMap.Size = new System.Drawing.Size(1235, 412);
            this.tabCharacterMap.TabIndex = 1;
            this.tabCharacterMap.Text = "CharacterMap";
            this.tabCharacterMap.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(693, 368);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(157, 27);
            this.textBox4.TabIndex = 9;
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblHint.Location = new System.Drawing.Point(617, 366);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(49, 23);
            this.lblHint.TabIndex = 8;
            this.lblHint.Text = "Hint:";
            // 
            // txtcharacter
            // 
            this.txtcharacter.Location = new System.Drawing.Point(337, 362);
            this.txtcharacter.Name = "txtcharacter";
            this.txtcharacter.Size = new System.Drawing.Size(158, 27);
            this.txtcharacter.TabIndex = 7;
            // 
            // lblCharacter
            // 
            this.lblCharacter.AutoSize = true;
            this.lblCharacter.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblCharacter.Location = new System.Drawing.Point(219, 362);
            this.lblCharacter.Name = "lblCharacter";
            this.lblCharacter.Size = new System.Drawing.Size(92, 23);
            this.lblCharacter.TabIndex = 6;
            this.lblCharacter.Text = "Character:";
            // 
            // txtUnicode
            // 
            this.txtUnicode.Location = new System.Drawing.Point(693, 323);
            this.txtUnicode.Name = "txtUnicode";
            this.txtUnicode.Size = new System.Drawing.Size(157, 27);
            this.txtUnicode.TabIndex = 5;
            // 
            // lblUnicode
            // 
            this.lblUnicode.AutoSize = true;
            this.lblUnicode.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblUnicode.Location = new System.Drawing.Point(586, 323);
            this.lblUnicode.Name = "lblUnicode";
            this.lblUnicode.Size = new System.Drawing.Size(80, 23);
            this.lblUnicode.TabIndex = 4;
            this.lblUnicode.Text = "Unicode:";
            this.lblUnicode.Click += new System.EventHandler(this.lblUnicode_Click);
            // 
            // comboBoxLanguageSelection
            // 
            this.comboBoxLanguageSelection.FormattingEnabled = true;
            this.comboBoxLanguageSelection.Location = new System.Drawing.Point(337, 327);
            this.comboBoxLanguageSelection.Name = "comboBoxLanguageSelection";
            this.comboBoxLanguageSelection.Size = new System.Drawing.Size(158, 27);
            this.comboBoxLanguageSelection.TabIndex = 3;
            // 
            // lblLanguageSelection
            // 
            this.lblLanguageSelection.AutoSize = true;
            this.lblLanguageSelection.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblLanguageSelection.Location = new System.Drawing.Point(149, 327);
            this.lblLanguageSelection.Name = "lblLanguageSelection";
            this.lblLanguageSelection.Size = new System.Drawing.Size(162, 23);
            this.lblLanguageSelection.TabIndex = 2;
            this.lblLanguageSelection.Text = "LanguageSelection:";
            this.lblLanguageSelection.Click += new System.EventHandler(this.lblLanguageSelection_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Location = new System.Drawing.Point(6, 162);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1223, 116);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(6, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1223, 140);
            this.panel2.TabIndex = 0;
            // 
            // tabMessages
            // 
            this.tabMessages.Location = new System.Drawing.Point(4, 28);
            this.tabMessages.Name = "tabMessages";
            this.tabMessages.Padding = new System.Windows.Forms.Padding(3);
            this.tabMessages.Size = new System.Drawing.Size(1235, 412);
            this.tabMessages.TabIndex = 2;
            this.tabMessages.Text = "Messages";
            this.tabMessages.UseVisualStyleBackColor = true;
            // 
            // tabStations
            // 
            this.tabStations.Location = new System.Drawing.Point(4, 28);
            this.tabStations.Name = "tabStations";
            this.tabStations.Padding = new System.Windows.Forms.Padding(3);
            this.tabStations.Size = new System.Drawing.Size(1235, 412);
            this.tabStations.TabIndex = 3;
            this.tabStations.Text = "Stations";
            this.tabStations.UseVisualStyleBackColor = true;
            // 
            // tabTrains
            // 
            this.tabTrains.Location = new System.Drawing.Point(4, 28);
            this.tabTrains.Name = "tabTrains";
            this.tabTrains.Padding = new System.Windows.Forms.Padding(3);
            this.tabTrains.Size = new System.Drawing.Size(1235, 412);
            this.tabTrains.TabIndex = 4;
            this.tabTrains.Text = "Trains";
            this.tabTrains.UseVisualStyleBackColor = true;
            // 
            // tabRakePreparation
            // 
            this.tabRakePreparation.Location = new System.Drawing.Point(4, 28);
            this.tabRakePreparation.Name = "tabRakePreparation";
            this.tabRakePreparation.Padding = new System.Windows.Forms.Padding(3);
            this.tabRakePreparation.Size = new System.Drawing.Size(1265, 477);
            this.tabRakePreparation.TabIndex = 2;
            this.tabRakePreparation.Text = "RakePreparation";
            this.tabRakePreparation.UseVisualStyleBackColor = true;
            // 
            // Editsavebtn
            // 
            this.Editsavebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Editsavebtn.ForeColor = System.Drawing.Color.GhostWhite;
            this.Editsavebtn.Location = new System.Drawing.Point(925, 116);
            this.Editsavebtn.Name = "Editsavebtn";
            this.Editsavebtn.Size = new System.Drawing.Size(115, 34);
            this.Editsavebtn.TabIndex = 2;
            this.Editsavebtn.Text = "EDIT/SAVE";
            this.Editsavebtn.UseVisualStyleBackColor = false;
            // 
            // Clearbtn
            // 
            this.Clearbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Clearbtn.ForeColor = System.Drawing.Color.Cornsilk;
            this.Clearbtn.Location = new System.Drawing.Point(1066, 116);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(114, 34);
            this.Clearbtn.TabIndex = 3;
            this.Clearbtn.Text = "CLEAR";
            this.Clearbtn.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Teal;
            this.panel4.Controls.Add(this.BtnLogin);
            this.panel4.Location = new System.Drawing.Point(16, 484);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1253, 104);
            this.panel4.TabIndex = 1;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(1150, 55);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(99, 35);
            this.BtnLogin.TabIndex = 0;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            // 
            // FrmDB_preparation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 602);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmDB_preparation";
            this.Text = "FrmDB_preparation";
            this.tabControl1.ResumeLayout(false);
            this.tabDBPreparation.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabLanguages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLanguageInfo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabCharacterMap.ResumeLayout(false);
            this.tabCharacterMap.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDBsetting;
        private System.Windows.Forms.TabPage tabDBPreparation;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabLanguages;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblFont;
        private System.Windows.Forms.Label lblLangName;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtLangid;
        private System.Windows.Forms.Label lblLangid;
        private System.Windows.Forms.TabPage tabCharacterMap;
        private System.Windows.Forms.TabPage tabMessages;
        private System.Windows.Forms.TabPage tabStations;
        private System.Windows.Forms.TabPage tabTrains;
        private System.Windows.Forms.TabPage tabRakePreparation;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dgvLanguageInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn langID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn Column7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtUnicode;
        private System.Windows.Forms.Label lblUnicode;
        private System.Windows.Forms.ComboBox comboBoxLanguageSelection;
        private System.Windows.Forms.Label lblLanguageSelection;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.TextBox txtcharacter;
        private System.Windows.Forms.Label lblCharacter;
        private System.Windows.Forms.Button Clearbtn;
        private System.Windows.Forms.Button Editsavebtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BtnLogin;
    }
}