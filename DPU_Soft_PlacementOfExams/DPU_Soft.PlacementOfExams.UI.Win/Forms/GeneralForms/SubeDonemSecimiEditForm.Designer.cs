﻿namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.GeneralForms
{
    partial class SubeDonemSecimiEditForm
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
            DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition2 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
            this.dpuDataLayoutControl = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.DpuDataLayoutControl();
            this.donemNavigator = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.Navigators.smallNavigator();
            this.subeNavigator = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.Navigators.smallNavigator();
            this.donemGrid = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.Grid.DpuGridControl();
            this.donemTablo = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.Grid.DpuGridView();
            this.colDonemId = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.Grid.DpuGridColumn();
            this.colDonemAdi = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.Grid.DpuGridColumn();
            this.subeGrid = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.Grid.DpuGridControl();
            this.subeTablo = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.Grid.DpuGridView();
            this.colSubeId = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.Grid.DpuGridColumn();
            this.colSubeAdi = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.Grid.DpuGridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpuDataLayoutControl)).BeginInit();
            this.dpuDataLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.donemGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donemTablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subeGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subeTablo)).BeginInit();
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
            this.ribbonControl.Size = new System.Drawing.Size(723, 109);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // dpuDataLayoutControl
            // 
            this.dpuDataLayoutControl.Controls.Add(this.donemNavigator);
            this.dpuDataLayoutControl.Controls.Add(this.subeNavigator);
            this.dpuDataLayoutControl.Controls.Add(this.donemGrid);
            this.dpuDataLayoutControl.Controls.Add(this.subeGrid);
            this.dpuDataLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dpuDataLayoutControl.Location = new System.Drawing.Point(0, 109);
            this.dpuDataLayoutControl.Name = "dpuDataLayoutControl";
            this.dpuDataLayoutControl.OptionsFocus.EnableAutoTabOrder = false;
            this.dpuDataLayoutControl.Root = this.Root;
            this.dpuDataLayoutControl.Size = new System.Drawing.Size(723, 212);
            this.dpuDataLayoutControl.TabIndex = 2;
            this.dpuDataLayoutControl.Text = "dpuDataLayoutControl1";
            // 
            // donemNavigator
            // 
            this.donemNavigator.Location = new System.Drawing.Point(363, 188);
            this.donemNavigator.Name = "donemNavigator";
            this.donemNavigator.Size = new System.Drawing.Size(358, 22);
            this.donemNavigator.TabIndex = 7;
            // 
            // subeNavigator
            // 
            this.subeNavigator.Location = new System.Drawing.Point(2, 188);
            this.subeNavigator.Name = "subeNavigator";
            this.subeNavigator.Size = new System.Drawing.Size(357, 22);
            this.subeNavigator.TabIndex = 6;
            // 
            // donemGrid
            // 
            this.donemGrid.Location = new System.Drawing.Point(363, 2);
            this.donemGrid.MainView = this.donemTablo;
            this.donemGrid.MenuManager = this.ribbonControl;
            this.donemGrid.Name = "donemGrid";
            this.donemGrid.Size = new System.Drawing.Size(358, 182);
            this.donemGrid.TabIndex = 5;
            this.donemGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.donemTablo});
            // 
            // donemTablo
            // 
            this.donemTablo.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.donemTablo.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.donemTablo.Appearance.FooterPanel.Options.UseFont = true;
            this.donemTablo.Appearance.FooterPanel.Options.UseForeColor = true;
            this.donemTablo.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.donemTablo.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.donemTablo.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.donemTablo.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.donemTablo.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.donemTablo.Appearance.ViewCaption.Options.UseForeColor = true;
            this.donemTablo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDonemId,
            this.colDonemAdi});
            this.donemTablo.GridControl = this.donemGrid;
            this.donemTablo.Name = "donemTablo";
            this.donemTablo.OptionsMenu.EnableColumnMenu = false;
            this.donemTablo.OptionsMenu.EnableFooterMenu = false;
            this.donemTablo.OptionsMenu.EnableGroupPanelMenu = false;
            this.donemTablo.OptionsNavigation.EnterMoveNextColumn = true;
            this.donemTablo.OptionsPrint.AutoWidth = false;
            this.donemTablo.OptionsPrint.PrintGroupFooter = false;
            this.donemTablo.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.donemTablo.OptionsView.RowAutoHeight = true;
            this.donemTablo.OptionsView.ShowColumnHeaders = false;
            this.donemTablo.OptionsView.ShowGroupPanel = false;
            this.donemTablo.OptionsView.ShowViewCaption = true;
            this.donemTablo.StatusBarAciklama = "Kullanıcının Yetkili Olduğu Dönemler";
            this.donemTablo.StatusBarKisayol = null;
            this.donemTablo.StatusBarKisayolAciklama = null;
            this.donemTablo.ViewCaption = "Dönem Kartları";
            // 
            // colDonemId
            // 
            this.colDonemId.Caption = "DonemId";
            this.colDonemId.FieldName = "DonemId";
            this.colDonemId.Name = "colDonemId";
            this.colDonemId.OptionsColumn.AllowEdit = false;
            this.colDonemId.OptionsColumn.ShowInCustomizationForm = false;
            this.colDonemId.StatusBarAciklama = null;
            this.colDonemId.StatusBarKisayol = null;
            this.colDonemId.StatusBarKisayolAciklama = null;
            // 
            // colDonemAdi
            // 
            this.colDonemAdi.Caption = "DonemAdı";
            this.colDonemAdi.FieldName = "DonemAdi";
            this.colDonemAdi.Name = "colDonemAdi";
            this.colDonemAdi.OptionsColumn.AllowEdit = false;
            this.colDonemAdi.OptionsColumn.AllowFocus = false;
            this.colDonemAdi.StatusBarAciklama = null;
            this.colDonemAdi.StatusBarKisayol = null;
            this.colDonemAdi.StatusBarKisayolAciklama = null;
            this.colDonemAdi.Visible = true;
            this.colDonemAdi.VisibleIndex = 0;
            // 
            // subeGrid
            // 
            this.subeGrid.Location = new System.Drawing.Point(2, 2);
            this.subeGrid.MainView = this.subeTablo;
            this.subeGrid.MenuManager = this.ribbonControl;
            this.subeGrid.Name = "subeGrid";
            this.subeGrid.Size = new System.Drawing.Size(357, 182);
            this.subeGrid.TabIndex = 4;
            this.subeGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.subeTablo});
            // 
            // subeTablo
            // 
            this.subeTablo.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.subeTablo.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.subeTablo.Appearance.FooterPanel.Options.UseFont = true;
            this.subeTablo.Appearance.FooterPanel.Options.UseForeColor = true;
            this.subeTablo.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.subeTablo.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.subeTablo.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.subeTablo.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.subeTablo.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.subeTablo.Appearance.ViewCaption.Options.UseForeColor = true;
            this.subeTablo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSubeId,
            this.colSubeAdi});
            this.subeTablo.GridControl = this.subeGrid;
            this.subeTablo.Name = "subeTablo";
            this.subeTablo.OptionsMenu.EnableColumnMenu = false;
            this.subeTablo.OptionsMenu.EnableFooterMenu = false;
            this.subeTablo.OptionsMenu.EnableGroupPanelMenu = false;
            this.subeTablo.OptionsNavigation.EnterMoveNextColumn = true;
            this.subeTablo.OptionsPrint.AutoWidth = false;
            this.subeTablo.OptionsPrint.PrintGroupFooter = false;
            this.subeTablo.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.subeTablo.OptionsView.RowAutoHeight = true;
            this.subeTablo.OptionsView.ShowColumnHeaders = false;
            this.subeTablo.OptionsView.ShowGroupPanel = false;
            this.subeTablo.OptionsView.ShowViewCaption = true;
            this.subeTablo.StatusBarAciklama = "Kullanıcının Yetkili Olduğu Bölümler";
            this.subeTablo.StatusBarKisayol = null;
            this.subeTablo.StatusBarKisayolAciklama = null;
            this.subeTablo.ViewCaption = "Bölüm Kartları";
            // 
            // colSubeId
            // 
            this.colSubeId.Caption = "Id";
            this.colSubeId.FieldName = "SubeId";
            this.colSubeId.Name = "colSubeId";
            this.colSubeId.OptionsColumn.AllowEdit = false;
            this.colSubeId.OptionsColumn.ShowInCustomizationForm = false;
            this.colSubeId.StatusBarAciklama = null;
            this.colSubeId.StatusBarKisayol = null;
            this.colSubeId.StatusBarKisayolAciklama = null;
            // 
            // colSubeAdi
            // 
            this.colSubeAdi.Caption = "Bölüm Adı";
            this.colSubeAdi.FieldName = "SubeAdi";
            this.colSubeAdi.Name = "colSubeAdi";
            this.colSubeAdi.OptionsColumn.AllowEdit = false;
            this.colSubeAdi.OptionsColumn.AllowFocus = false;
            this.colSubeAdi.StatusBarAciklama = null;
            this.colSubeAdi.StatusBarKisayol = null;
            this.colSubeAdi.StatusBarKisayolAciklama = null;
            this.colSubeAdi.Visible = true;
            this.colSubeAdi.VisibleIndex = 0;
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
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition1.Width = 50D;
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition2.Width = 50D;
            this.Root.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1,
            columnDefinition2});
            rowDefinition1.Height = 100D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
            rowDefinition2.Height = 26D;
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute;
            this.Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2});
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.Root.Size = new System.Drawing.Size(723, 212);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem1.Control = this.subeGrid;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(361, 186);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem2.Control = this.donemGrid;
            this.layoutControlItem2.Location = new System.Drawing.Point(361, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlItem2.Size = new System.Drawing.Size(362, 186);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem3.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem3.Control = this.subeNavigator;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 186);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem3.Size = new System.Drawing.Size(361, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem4.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem4.Control = this.donemNavigator;
            this.layoutControlItem4.Location = new System.Drawing.Point(361, 186);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlItem4.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem4.Size = new System.Drawing.Size(362, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // SubeDonemSecimiEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 345);
            this.Controls.Add(this.dpuDataLayoutControl);
            this.IconOptions.ShowIcon = false;
            this.Name = "SubeDonemSecimiEditForm";
            this.Text = "Şube ve Dönem Seçimi";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.dpuDataLayoutControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpuDataLayoutControl)).EndInit();
            this.dpuDataLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.donemGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donemTablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subeGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subeTablo)).EndInit();
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
        private UserControls.Controls.Navigators.smallNavigator donemNavigator;
        private UserControls.Controls.Navigators.smallNavigator subeNavigator;
        private UserControls.Controls.Grid.DpuGridControl donemGrid;
        private UserControls.Controls.Grid.DpuGridView donemTablo;
        private UserControls.Controls.Grid.DpuGridColumn colDonemId;
        private UserControls.Controls.Grid.DpuGridControl subeGrid;
        private UserControls.Controls.Grid.DpuGridView subeTablo;
        private UserControls.Controls.Grid.DpuGridColumn colSubeId;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private UserControls.Controls.Grid.DpuGridColumn colSubeAdi;
        private UserControls.Controls.Grid.DpuGridColumn colDonemAdi;
    }
}