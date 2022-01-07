
namespace StokUretimProgramlari
{
    partial class FrmIsEmri
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbTamamlanmis = new System.Windows.Forms.RadioButton();
            this.rbYeni = new System.Windows.Forms.RadioButton();
            this.txtIsEmriNo = new DevExpress.XtraEditors.TextEdit();
            this.btnSiparisTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSiparisListesi = new DevExpress.XtraEditors.SimpleButton();
            this.btnStokListesi = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnIsEmriListesi = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtTeslimTarihi = new DevExpress.XtraEditors.DateEdit();
            this.txtKalemId = new DevExpress.XtraEditors.TextEdit();
            this.txtSiparisNo = new DevExpress.XtraEditors.TextEdit();
            this.txtIsEmriTarihi = new DevExpress.XtraEditors.DateEdit();
            this.txtStokKodu = new DevExpress.XtraEditors.TextEdit();
            this.txtIsEmriAciklama = new DevExpress.XtraEditors.TextEdit();
            this.txtMiktar = new DevExpress.XtraEditors.TextEdit();
            this.txtStokAdi = new DevExpress.XtraEditors.TextEdit();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIsEmriNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTeslimTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTeslimTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKalemId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSiparisNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIsEmriTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIsEmriTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIsEmriAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMiktar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokAdi.Properties)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtIsEmriNo);
            this.groupBox1.Controls.Add(this.btnSiparisTemizle);
            this.groupBox1.Controls.Add(this.btnSiparisListesi);
            this.groupBox1.Controls.Add(this.btnStokListesi);
            this.groupBox1.Controls.Add(this.sbtnIsEmriListesi);
            this.groupBox1.Controls.Add(this.labelControl7);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.labelControl9);
            this.groupBox1.Controls.Add(this.labelControl6);
            this.groupBox1.Controls.Add(this.labelControl8);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.txtTeslimTarihi);
            this.groupBox1.Controls.Add(this.txtKalemId);
            this.groupBox1.Controls.Add(this.txtSiparisNo);
            this.groupBox1.Controls.Add(this.txtIsEmriTarihi);
            this.groupBox1.Controls.Add(this.txtStokKodu);
            this.groupBox1.Controls.Add(this.txtIsEmriAciklama);
            this.groupBox1.Controls.Add(this.txtMiktar);
            this.groupBox1.Controls.Add(this.txtStokAdi);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(582, 281);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İş Emri Genel Bilgiler";
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.Image = global::StokUretimProgramlari.Properties.Resources.cancel_16x162;
            this.btnSil.Location = new System.Drawing.Point(152, 227);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(96, 27);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "Sil";
            // 
            // btnKaydet
            // 
            this.btnKaydet.ImageOptions.Image = global::StokUretimProgramlari.Properties.Resources.apply_16x163;
            this.btnKaydet.Location = new System.Drawing.Point(32, 227);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(96, 27);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "Kaydet";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbTamamlanmis);
            this.groupBox2.Controls.Add(this.rbYeni);
            this.groupBox2.Location = new System.Drawing.Point(296, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 71);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İş Emri Durumu";
            // 
            // rbTamamlanmis
            // 
            this.rbTamamlanmis.AutoSize = true;
            this.rbTamamlanmis.Location = new System.Drawing.Point(130, 35);
            this.rbTamamlanmis.Name = "rbTamamlanmis";
            this.rbTamamlanmis.Size = new System.Drawing.Size(108, 23);
            this.rbTamamlanmis.TabIndex = 0;
            this.rbTamamlanmis.TabStop = true;
            this.rbTamamlanmis.Text = "Tamamlanmış";
            this.rbTamamlanmis.UseVisualStyleBackColor = true;
            // 
            // rbYeni
            // 
            this.rbYeni.AutoSize = true;
            this.rbYeni.Location = new System.Drawing.Point(15, 35);
            this.rbYeni.Name = "rbYeni";
            this.rbYeni.Size = new System.Drawing.Size(53, 23);
            this.rbYeni.TabIndex = 0;
            this.rbYeni.TabStop = true;
            this.rbYeni.Text = "Yeni";
            this.rbYeni.UseVisualStyleBackColor = true;
            // 
            // txtIsEmriNo
            // 
            this.txtIsEmriNo.Location = new System.Drawing.Point(135, 34);
            this.txtIsEmriNo.Name = "txtIsEmriNo";
            this.txtIsEmriNo.Size = new System.Drawing.Size(91, 20);
            this.txtIsEmriNo.TabIndex = 2;
            // 
            // btnSiparisTemizle
            // 
            this.btnSiparisTemizle.ImageOptions.Image = global::StokUretimProgramlari.Properties.Resources.add_16x16;
            this.btnSiparisTemizle.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnSiparisTemizle.Location = new System.Drawing.Point(152, 0);
            this.btnSiparisTemizle.Name = "btnSiparisTemizle";
            this.btnSiparisTemizle.Size = new System.Drawing.Size(29, 23);
            this.btnSiparisTemizle.TabIndex = 3;
            // 
            // btnSiparisListesi
            // 
            this.btnSiparisListesi.ImageOptions.Image = global::StokUretimProgramlari.Properties.Resources.listbullets_16x16;
            this.btnSiparisListesi.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnSiparisListesi.Location = new System.Drawing.Point(236, 146);
            this.btnSiparisListesi.Name = "btnSiparisListesi";
            this.btnSiparisListesi.Size = new System.Drawing.Size(32, 27);
            this.btnSiparisListesi.TabIndex = 3;
            this.btnSiparisListesi.Click += new System.EventHandler(this.btnSiparisListesi_Click);
            // 
            // btnStokListesi
            // 
            this.btnStokListesi.ImageOptions.Image = global::StokUretimProgramlari.Properties.Resources.listbullets_16x16;
            this.btnStokListesi.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnStokListesi.Location = new System.Drawing.Point(236, 69);
            this.btnStokListesi.Name = "btnStokListesi";
            this.btnStokListesi.Size = new System.Drawing.Size(32, 27);
            this.btnStokListesi.TabIndex = 3;
            // 
            // sbtnIsEmriListesi
            // 
            this.sbtnIsEmriListesi.ImageOptions.Image = global::StokUretimProgramlari.Properties.Resources.listbullets_16x16;
            this.sbtnIsEmriListesi.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.sbtnIsEmriListesi.Location = new System.Drawing.Point(236, 25);
            this.sbtnIsEmriListesi.Name = "sbtnIsEmriListesi";
            this.sbtnIsEmriListesi.Size = new System.Drawing.Size(32, 27);
            this.sbtnIsEmriListesi.TabIndex = 3;
            this.sbtnIsEmriListesi.Click += new System.EventHandler(this.sbtnIsEmriListesi_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(6, 35);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(112, 19);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "İş Emri Numarası :";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(296, 117);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(84, 19);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Teslim Tarihi :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(296, 31);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(88, 19);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "İş Emri Tarihi :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(9, 119);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(120, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "İş Emri Açıklaması :";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(19, 188);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(109, 19);
            this.labelControl9.TabIndex = 0;
            this.labelControl9.Text = "Sipariş Kalem Id :";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(19, 152);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(110, 19);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Sipariş Numarası :";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(321, 152);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(48, 19);
            this.labelControl8.TabIndex = 0;
            this.labelControl8.Text = "Miktar :";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(321, 75);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(62, 19);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Stok Adı :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(43, 75);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(75, 19);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Stok Kodu :";
            // 
            // txtTeslimTarihi
            // 
            this.txtTeslimTarihi.EditValue = null;
            this.txtTeslimTarihi.Location = new System.Drawing.Point(390, 118);
            this.txtTeslimTarihi.Name = "txtTeslimTarihi";
            this.txtTeslimTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTeslimTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTeslimTarihi.Properties.DisplayFormat.FormatString = "";
            this.txtTeslimTarihi.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtTeslimTarihi.Properties.EditFormat.FormatString = "";
            this.txtTeslimTarihi.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtTeslimTarihi.Properties.Mask.EditMask = "";
            this.txtTeslimTarihi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtTeslimTarihi.Size = new System.Drawing.Size(107, 20);
            this.txtTeslimTarihi.TabIndex = 4;
            // 
            // txtKalemId
            // 
            this.txtKalemId.Location = new System.Drawing.Point(135, 189);
            this.txtKalemId.Name = "txtKalemId";
            this.txtKalemId.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtKalemId.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtKalemId.Size = new System.Drawing.Size(89, 20);
            this.txtKalemId.TabIndex = 4;
            // 
            // txtSiparisNo
            // 
            this.txtSiparisNo.Location = new System.Drawing.Point(135, 153);
            this.txtSiparisNo.Name = "txtSiparisNo";
            this.txtSiparisNo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtSiparisNo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtSiparisNo.Size = new System.Drawing.Size(89, 20);
            this.txtSiparisNo.TabIndex = 4;
            // 
            // txtIsEmriTarihi
            // 
            this.txtIsEmriTarihi.EditValue = null;
            this.txtIsEmriTarihi.Location = new System.Drawing.Point(390, 32);
            this.txtIsEmriTarihi.Name = "txtIsEmriTarihi";
            this.txtIsEmriTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtIsEmriTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtIsEmriTarihi.Properties.DisplayFormat.FormatString = "";
            this.txtIsEmriTarihi.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtIsEmriTarihi.Properties.EditFormat.FormatString = "";
            this.txtIsEmriTarihi.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtIsEmriTarihi.Properties.Mask.EditMask = "";
            this.txtIsEmriTarihi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtIsEmriTarihi.Size = new System.Drawing.Size(107, 20);
            this.txtIsEmriTarihi.TabIndex = 4;
            // 
            // txtStokKodu
            // 
            this.txtStokKodu.Location = new System.Drawing.Point(135, 76);
            this.txtStokKodu.Name = "txtStokKodu";
            this.txtStokKodu.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtStokKodu.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtStokKodu.Size = new System.Drawing.Size(89, 20);
            this.txtStokKodu.TabIndex = 4;
            // 
            // txtIsEmriAciklama
            // 
            this.txtIsEmriAciklama.Location = new System.Drawing.Point(135, 120);
            this.txtIsEmriAciklama.Name = "txtIsEmriAciklama";
            this.txtIsEmriAciklama.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtIsEmriAciklama.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtIsEmriAciklama.Size = new System.Drawing.Size(136, 20);
            this.txtIsEmriAciklama.TabIndex = 4;
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(390, 153);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtMiktar.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtMiktar.Size = new System.Drawing.Size(107, 20);
            this.txtMiktar.TabIndex = 4;
            // 
            // txtStokAdi
            // 
            this.txtStokAdi.Location = new System.Drawing.Point(390, 76);
            this.txtStokAdi.Name = "txtStokAdi";
            this.txtStokAdi.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtStokAdi.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtStokAdi.Size = new System.Drawing.Size(186, 20);
            this.txtStokAdi.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gridControl1);
            this.groupBox3.Location = new System.Drawing.Point(13, 300);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(582, 222);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "İş Emri Listesi";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 22);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(576, 197);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // FrmIsEmri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 534);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmIsEmri";
            this.Text = "İş Emri Girişi";
            this.Load += new System.EventHandler(this.FrmIsEmri_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIsEmriNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTeslimTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTeslimTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKalemId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSiparisNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIsEmriTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIsEmriTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIsEmriAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMiktar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokAdi.Properties)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit txtIsEmriNo;
        private DevExpress.XtraEditors.SimpleButton btnSiparisTemizle;
        private DevExpress.XtraEditors.SimpleButton btnStokListesi;
        private DevExpress.XtraEditors.SimpleButton sbtnIsEmriListesi;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit txtIsEmriTarihi;
        private DevExpress.XtraEditors.TextEdit txtStokKodu;
        private DevExpress.XtraEditors.TextEdit txtStokAdi;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit txtTeslimTarihi;
        private DevExpress.XtraEditors.TextEdit txtIsEmriAciklama;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbTamamlanmis;
        private System.Windows.Forms.RadioButton rbYeni;
        private DevExpress.XtraEditors.SimpleButton btnSiparisListesi;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtKalemId;
        private DevExpress.XtraEditors.TextEdit txtSiparisNo;
        private DevExpress.XtraEditors.TextEdit txtMiktar;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}