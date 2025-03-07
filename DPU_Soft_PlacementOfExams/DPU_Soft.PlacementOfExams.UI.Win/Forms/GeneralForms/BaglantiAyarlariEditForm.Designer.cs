﻿namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.GeneralForms
{
    partial class BaglantiAyarlariEditForm
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
            DevExpress.XtraLayout.ColumnDefinition columnDefinition3 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition4 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition5 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition6 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition7 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition8 = new DevExpress.XtraLayout.RowDefinition();
            this.dpuDataLayoutControl = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.DpuDataLayoutControl();
            this.txtSifre = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.DpuTextEdit();
            this.txtKullaniciAdi = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.DpuTextEdit();
            this.txtYetkilendirmeTuru = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.DpuComboBoxEdit();
            this.txtServer = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.DpuTextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpuDataLayoutControl)).BeginInit();
            this.dpuDataLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYetkilendirmeTuru.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            // 
            // 
            // 
            this.ribbonControl.SearchEditItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.ribbonControl.SearchEditItem.EditWidth = 150;
            this.ribbonControl.SearchEditItem.Id = -5000;
            this.ribbonControl.SearchEditItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControl.Size = new System.Drawing.Size(458, 109);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // dpuDataLayoutControl
            // 
            this.dpuDataLayoutControl.Controls.Add(this.txtSifre);
            this.dpuDataLayoutControl.Controls.Add(this.txtKullaniciAdi);
            this.dpuDataLayoutControl.Controls.Add(this.txtYetkilendirmeTuru);
            this.dpuDataLayoutControl.Controls.Add(this.txtServer);
            this.dpuDataLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dpuDataLayoutControl.Location = new System.Drawing.Point(0, 109);
            this.dpuDataLayoutControl.Name = "dpuDataLayoutControl";
            this.dpuDataLayoutControl.OptionsFocus.EnableAutoTabOrder = false;
            this.dpuDataLayoutControl.Root = this.Root;
            this.dpuDataLayoutControl.Size = new System.Drawing.Size(458, 116);
            this.dpuDataLayoutControl.TabIndex = 0;
            this.dpuDataLayoutControl.Text = "dpuDataLayoutControl1";
            // 
            // txtSifre
            // 
            this.txtSifre.EnterMoveNextControl = true;
            this.txtSifre.Location = new System.Drawing.Point(107, 84);
            this.txtSifre.MenuManager = this.ribbonControl;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtSifre.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtSifre.Properties.MaxLength = 50;
            this.txtSifre.Properties.UseSystemPasswordChar = true;
            this.txtSifre.Size = new System.Drawing.Size(201, 20);
            this.txtSifre.StatusBarAciklama = "Şifre Giriniz";
            this.txtSifre.StyleController = this.dpuDataLayoutControl;
            this.txtSifre.TabIndex = 3;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.EnterMoveNextControl = true;
            this.txtKullaniciAdi.Location = new System.Drawing.Point(107, 60);
            this.txtKullaniciAdi.MenuManager = this.ribbonControl;
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtKullaniciAdi.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtKullaniciAdi.Properties.MaxLength = 50;
            this.txtKullaniciAdi.Size = new System.Drawing.Size(201, 20);
            this.txtKullaniciAdi.StatusBarAciklama = "Kullanıcı Adı Giriniz";
            this.txtKullaniciAdi.StyleController = this.dpuDataLayoutControl;
            this.txtKullaniciAdi.TabIndex = 2;
            // 
            // txtYetkilendirmeTuru
            // 
            this.txtYetkilendirmeTuru.EnterMoveNextControl = true;
            this.txtYetkilendirmeTuru.Location = new System.Drawing.Point(107, 36);
            this.txtYetkilendirmeTuru.MenuManager = this.ribbonControl;
            this.txtYetkilendirmeTuru.Name = "txtYetkilendirmeTuru";
            this.txtYetkilendirmeTuru.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtYetkilendirmeTuru.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtYetkilendirmeTuru.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtYetkilendirmeTuru.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtYetkilendirmeTuru.Size = new System.Drawing.Size(201, 20);
            this.txtYetkilendirmeTuru.StatusBarAciklama = "Yetkilendirme Türü";
            this.txtYetkilendirmeTuru.StatusBarKisayol = "F4 : ";
            this.txtYetkilendirmeTuru.StatusBarKisayolAciklama = "Seçim Yap";
            this.txtYetkilendirmeTuru.StyleController = this.dpuDataLayoutControl;
            this.txtYetkilendirmeTuru.TabIndex = 1;
            // 
            // txtServer
            // 
            this.txtServer.EnterMoveNextControl = true;
            this.txtServer.Location = new System.Drawing.Point(107, 12);
            this.txtServer.MenuManager = this.ribbonControl;
            this.txtServer.Name = "txtServer";
            this.txtServer.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtServer.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtServer.Properties.MaxLength = 50;
            this.txtServer.Size = new System.Drawing.Size(339, 20);
            this.txtServer.StatusBarAciklama = "Server Adı Giriniz";
            this.txtServer.StyleController = this.dpuDataLayoutControl;
            this.txtServer.TabIndex = 0;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.Root.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.Root.Name = "Root";
            columnDefinition3.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition3.Width = 300D;
            columnDefinition4.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition4.Width = 100D;
            this.Root.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition3,
            columnDefinition4});
            rowDefinition5.Height = 24D;
            rowDefinition5.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition6.Height = 24D;
            rowDefinition6.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition7.Height = 24D;
            rowDefinition7.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition8.Height = 100D;
            rowDefinition8.SizeType = System.Windows.Forms.SizeType.Percent;
            this.Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition5,
            rowDefinition6,
            rowDefinition7,
            rowDefinition8});
            this.Root.Size = new System.Drawing.Size(458, 116);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem1.Control = this.txtServer;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.OptionsTableLayoutItem.ColumnSpan = 2;
            this.layoutControlItem1.Size = new System.Drawing.Size(438, 24);
            this.layoutControlItem1.Text = "Server:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(92, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem2.Control = this.txtYetkilendirmeTuru;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem2.Size = new System.Drawing.Size(300, 24);
            this.layoutControlItem2.Text = "Yetkilendirme Türü:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(92, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem3.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem3.Control = this.txtKullaniciAdi;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.OptionsTableLayoutItem.RowIndex = 2;
            this.layoutControlItem3.Size = new System.Drawing.Size(300, 24);
            this.layoutControlItem3.Text = "Kullanıcı Adı:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(92, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem4.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem4.Control = this.txtSifre;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.OptionsTableLayoutItem.RowIndex = 3;
            this.layoutControlItem4.Size = new System.Drawing.Size(300, 24);
            this.layoutControlItem4.Text = "Şifre:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(92, 13);
            // 
            // BaglantiAyarlariEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 249);
            this.Controls.Add(this.dpuDataLayoutControl);
            this.IconOptions.ShowIcon = false;
            this.MinimumSize = new System.Drawing.Size(460, 250);
            this.Name = "BaglantiAyarlariEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bağlantı Ayarları";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.dpuDataLayoutControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpuDataLayoutControl)).EndInit();
            this.dpuDataLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYetkilendirmeTuru.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Controls.DpuDataLayoutControl dpuDataLayoutControl;
        private UserControls.Controls.DpuTextEdit txtSifre;
        private UserControls.Controls.DpuTextEdit txtKullaniciAdi;
        private UserControls.Controls.DpuComboBoxEdit txtYetkilendirmeTuru;
        private UserControls.Controls.DpuTextEdit txtServer;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}