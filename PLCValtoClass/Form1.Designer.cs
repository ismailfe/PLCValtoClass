namespace PLCValtoClass
{
    partial class Form1
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
            this.DGV1 = new System.Windows.Forms.DataGridView();
            this.B_DosyaSec = new System.Windows.Forms.Button();
            this.TB_DosyaYolu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.B_ClassOlustur = new System.Windows.Forms.Button();
            this.B_DosyaAc = new System.Windows.Forms.Button();
            this.CB_Sayfa = new System.Windows.Forms.ComboBox();
            this.TB_Status = new System.Windows.Forms.RichTextBox();
            this.TB_Class_ValueSet = new System.Windows.Forms.RichTextBox();
            this.TB_Class_ValueCreate = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RB_READ = new System.Windows.Forms.RadioButton();
            this.RB_WRITE = new System.Windows.Forms.RadioButton();
            this.TB_ValueSetOnEk = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_ValueCreateOnEk = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.B_Export_DGVResult = new System.Windows.Forms.Button();
            this.DGV_Result = new System.Windows.Forms.DataGridView();
            this.B_TabloOlustur = new System.Windows.Forms.Button();
            this.TB_DBNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Result)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV1
            // 
            this.DGV1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV1.Location = new System.Drawing.Point(11, 33);
            this.DGV1.Name = "DGV1";
            this.DGV1.Size = new System.Drawing.Size(989, 295);
            this.DGV1.TabIndex = 0;
            // 
            // B_DosyaSec
            // 
            this.B_DosyaSec.Location = new System.Drawing.Point(236, 6);
            this.B_DosyaSec.Name = "B_DosyaSec";
            this.B_DosyaSec.Size = new System.Drawing.Size(54, 23);
            this.B_DosyaSec.TabIndex = 1;
            this.B_DosyaSec.Text = "Seç";
            this.B_DosyaSec.UseVisualStyleBackColor = true;
            this.B_DosyaSec.Click += new System.EventHandler(this.B_DosyaSec_Click);
            // 
            // TB_DosyaYolu
            // 
            this.TB_DosyaYolu.Location = new System.Drawing.Point(47, 7);
            this.TB_DosyaYolu.Name = "TB_DosyaYolu";
            this.TB_DosyaYolu.Size = new System.Drawing.Size(188, 20);
            this.TB_DosyaYolu.TabIndex = 2;
            this.TB_DosyaYolu.Text = "C:\\DB96.xls";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dosya";
            // 
            // B_ClassOlustur
            // 
            this.B_ClassOlustur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_ClassOlustur.Location = new System.Drawing.Point(895, 4);
            this.B_ClassOlustur.Name = "B_ClassOlustur";
            this.B_ClassOlustur.Size = new System.Drawing.Size(105, 28);
            this.B_ClassOlustur.TabIndex = 1;
            this.B_ClassOlustur.Text = "CLASS OLUŞTUR";
            this.B_ClassOlustur.UseVisualStyleBackColor = true;
            this.B_ClassOlustur.Click += new System.EventHandler(this.B_ClassOlustur_Click);
            // 
            // B_DosyaAc
            // 
            this.B_DosyaAc.Location = new System.Drawing.Point(290, 6);
            this.B_DosyaAc.Name = "B_DosyaAc";
            this.B_DosyaAc.Size = new System.Drawing.Size(152, 23);
            this.B_DosyaAc.TabIndex = 1;
            this.B_DosyaAc.Text = "Secilli Excel Dosyasını Aç";
            this.B_DosyaAc.UseVisualStyleBackColor = true;
            this.B_DosyaAc.Click += new System.EventHandler(this.B_DosyaAc_Click);
            // 
            // CB_Sayfa
            // 
            this.CB_Sayfa.FormattingEnabled = true;
            this.CB_Sayfa.Location = new System.Drawing.Point(443, 7);
            this.CB_Sayfa.Name = "CB_Sayfa";
            this.CB_Sayfa.Size = new System.Drawing.Size(91, 21);
            this.CB_Sayfa.TabIndex = 4;
            // 
            // TB_Status
            // 
            this.TB_Status.Location = new System.Drawing.Point(13, 724);
            this.TB_Status.Name = "TB_Status";
            this.TB_Status.ReadOnly = true;
            this.TB_Status.Size = new System.Drawing.Size(1362, 20);
            this.TB_Status.TabIndex = 5;
            this.TB_Status.Text = "";
            // 
            // TB_Class_ValueSet
            // 
            this.TB_Class_ValueSet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TB_Class_ValueSet.Location = new System.Drawing.Point(2, 28);
            this.TB_Class_ValueSet.Name = "TB_Class_ValueSet";
            this.TB_Class_ValueSet.ReadOnly = true;
            this.TB_Class_ValueSet.Size = new System.Drawing.Size(484, 213);
            this.TB_Class_ValueSet.TabIndex = 5;
            this.TB_Class_ValueSet.Text = ".";
            // 
            // TB_Class_ValueCreate
            // 
            this.TB_Class_ValueCreate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TB_Class_ValueCreate.Location = new System.Drawing.Point(493, 28);
            this.TB_Class_ValueCreate.Name = "TB_Class_ValueCreate";
            this.TB_Class_ValueCreate.ReadOnly = true;
            this.TB_Class_ValueCreate.Size = new System.Drawing.Size(489, 213);
            this.TB_Class_ValueCreate.TabIndex = 5;
            this.TB_Class_ValueCreate.Text = ".";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "VALUE SET";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(495, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "VALUE CREATE";
            // 
            // RB_READ
            // 
            this.RB_READ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RB_READ.AutoSize = true;
            this.RB_READ.Checked = true;
            this.RB_READ.Location = new System.Drawing.Point(776, 9);
            this.RB_READ.Name = "RB_READ";
            this.RB_READ.Size = new System.Drawing.Size(55, 17);
            this.RB_READ.TabIndex = 6;
            this.RB_READ.TabStop = true;
            this.RB_READ.Text = "READ";
            this.RB_READ.UseVisualStyleBackColor = true;
            // 
            // RB_WRITE
            // 
            this.RB_WRITE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RB_WRITE.AutoSize = true;
            this.RB_WRITE.Location = new System.Drawing.Point(834, 9);
            this.RB_WRITE.Name = "RB_WRITE";
            this.RB_WRITE.Size = new System.Drawing.Size(61, 17);
            this.RB_WRITE.TabIndex = 6;
            this.RB_WRITE.Text = "WRITE";
            this.RB_WRITE.UseVisualStyleBackColor = true;
            // 
            // TB_ValueSetOnEk
            // 
            this.TB_ValueSetOnEk.Location = new System.Drawing.Point(309, 5);
            this.TB_ValueSetOnEk.Name = "TB_ValueSetOnEk";
            this.TB_ValueSetOnEk.Size = new System.Drawing.Size(177, 20);
            this.TB_ValueSetOnEk.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ön Ek (örnek: CLS.PLCVar):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(628, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ön Ek (örnek: CLS.PLCVar):";
            // 
            // TB_ValueCreateOnEk
            // 
            this.TB_ValueCreateOnEk.Location = new System.Drawing.Point(771, 5);
            this.TB_ValueCreateOnEk.Name = "TB_ValueCreateOnEk";
            this.TB_ValueCreateOnEk.Size = new System.Drawing.Size(211, 20);
            this.TB_ValueCreateOnEk.TabIndex = 7;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(11, 334);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(996, 273);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.TB_ValueCreateOnEk);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.TB_ValueSetOnEk);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.TB_Class_ValueSet);
            this.tabPage1.Controls.Add(this.TB_Class_ValueCreate);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(988, 247);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Class Oluşturma";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.B_Export_DGVResult);
            this.tabPage2.Controls.Add(this.DGV_Result);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(988, 247);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tablo Oluşturma";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // B_Export_DGVResult
            // 
            this.B_Export_DGVResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Export_DGVResult.Location = new System.Drawing.Point(907, 223);
            this.B_Export_DGVResult.Name = "B_Export_DGVResult";
            this.B_Export_DGVResult.Size = new System.Drawing.Size(75, 22);
            this.B_Export_DGVResult.TabIndex = 1;
            this.B_Export_DGVResult.Text = "Export ";
            this.B_Export_DGVResult.UseVisualStyleBackColor = true;
            this.B_Export_DGVResult.Click += new System.EventHandler(this.B_Export_DGVResult_Click);
            // 
            // DGV_Result
            // 
            this.DGV_Result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_Result.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.DGV_Result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Result.Location = new System.Drawing.Point(6, 6);
            this.DGV_Result.Name = "DGV_Result";
            this.DGV_Result.RowHeadersVisible = false;
            this.DGV_Result.Size = new System.Drawing.Size(976, 217);
            this.DGV_Result.TabIndex = 0;
            // 
            // B_TabloOlustur
            // 
            this.B_TabloOlustur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_TabloOlustur.Location = new System.Drawing.Point(653, 3);
            this.B_TabloOlustur.Name = "B_TabloOlustur";
            this.B_TabloOlustur.Size = new System.Drawing.Size(108, 28);
            this.B_TabloOlustur.TabIndex = 9;
            this.B_TabloOlustur.Text = "TABLO OLUŞTUR";
            this.B_TabloOlustur.UseVisualStyleBackColor = true;
            this.B_TabloOlustur.Click += new System.EventHandler(this.B_TabloOlustur_Click);
            // 
            // TB_DBNo
            // 
            this.TB_DBNo.Location = new System.Drawing.Point(600, 7);
            this.TB_DBNo.Name = "TB_DBNo";
            this.TB_DBNo.Size = new System.Drawing.Size(53, 20);
            this.TB_DBNo.TabIndex = 2;
            this.TB_DBNo.Text = "DB0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(556, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "DB NO:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 637);
            this.Controls.Add(this.B_TabloOlustur);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.RB_WRITE);
            this.Controls.Add(this.RB_READ);
            this.Controls.Add(this.TB_Status);
            this.Controls.Add(this.CB_Sayfa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_DBNo);
            this.Controls.Add(this.TB_DosyaYolu);
            this.Controls.Add(this.B_ClassOlustur);
            this.Controls.Add(this.B_DosyaAc);
            this.Controls.Add(this.B_DosyaSec);
            this.Controls.Add(this.DGV1);
            this.MinimumSize = new System.Drawing.Size(1027, 600);
            this.Name = "Form1";
            this.Text = "PLC DATA BLOK to PLC CONTROL PROGRAMS";
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Result)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV1;
        private System.Windows.Forms.Button B_DosyaSec;
        private System.Windows.Forms.TextBox TB_DosyaYolu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button B_ClassOlustur;
        private System.Windows.Forms.Button B_DosyaAc;
        private System.Windows.Forms.ComboBox CB_Sayfa;
        private System.Windows.Forms.RichTextBox TB_Status;
        private System.Windows.Forms.RichTextBox TB_Class_ValueSet;
        private System.Windows.Forms.RichTextBox TB_Class_ValueCreate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton RB_READ;
        private System.Windows.Forms.RadioButton RB_WRITE;
        private System.Windows.Forms.TextBox TB_ValueSetOnEk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_ValueCreateOnEk;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView DGV_Result;
        private System.Windows.Forms.Button B_TabloOlustur;
        private System.Windows.Forms.TextBox TB_DBNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button B_Export_DGVResult;
    }
}

