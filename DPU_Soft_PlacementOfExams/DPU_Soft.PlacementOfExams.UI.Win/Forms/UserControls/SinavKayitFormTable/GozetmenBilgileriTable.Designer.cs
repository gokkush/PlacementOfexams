﻿namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.SinavKayitFormTable
{
    partial class GozetmenBilgileriTable
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grid = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.Grid.DpuGridControl();
            this.tablo = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.Grid.DpuGridView();
            this.colGozetmenAdi = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.Grid.DpuGridColumn();
            this.colGorevlendirilmeSayisi = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.Grid.DpuGridColumn();
            this.colSinavSalonAdi = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.Grid.DpuGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MainView = this.tablo;
            this.grid.MenuManager = this.barManager;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(495, 225);
            this.grid.TabIndex = 5;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tablo});
            // 
            // tablo
            // 
            this.tablo.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.tablo.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.tablo.Appearance.FooterPanel.Options.UseFont = true;
            this.tablo.Appearance.FooterPanel.Options.UseForeColor = true;
            this.tablo.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.tablo.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.tablo.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.tablo.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tablo.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.tablo.Appearance.ViewCaption.Options.UseForeColor = true;
            this.tablo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGozetmenAdi,
            this.colGorevlendirilmeSayisi,
            this.colSinavSalonAdi});
            this.tablo.GridControl = this.grid;
            this.tablo.Name = "tablo";
            this.tablo.OptionsCustomization.AllowFilter = false;
            this.tablo.OptionsCustomization.AllowSort = false;
            this.tablo.OptionsFilter.AllowColumnMRUFilterList = false;
            this.tablo.OptionsFilter.AllowFilterEditor = false;
            this.tablo.OptionsFilter.AllowFilterIncrementalSearch = false;
            this.tablo.OptionsFilter.AllowMRUFilterList = false;
            this.tablo.OptionsFilter.AllowMultiSelectInCheckedFilterPopup = false;
            this.tablo.OptionsMenu.EnableColumnMenu = false;
            this.tablo.OptionsMenu.EnableFooterMenu = false;
            this.tablo.OptionsMenu.EnableGroupPanelMenu = false;
            this.tablo.OptionsNavigation.EnterMoveNextColumn = true;
            this.tablo.OptionsPrint.AutoWidth = false;
            this.tablo.OptionsPrint.PrintGroupFooter = false;
            this.tablo.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.tablo.OptionsView.RowAutoHeight = true;
            this.tablo.OptionsView.ShowGroupPanel = false;
            this.tablo.OptionsView.ShowViewCaption = true;
            this.tablo.StatusBarAciklama = null;
            this.tablo.StatusBarKisayol = null;
            this.tablo.StatusBarKisayolAciklama = null;
            this.tablo.ViewCaption = "Gözetmen Seçim Modülü";
            // 
            // colGozetmenAdi
            // 
            this.colGozetmenAdi.Caption = "Gözetmen Adı Soyadı";
            this.colGozetmenAdi.FieldName = "GozetmenAdi";
            this.colGozetmenAdi.Name = "colGozetmenAdi";
            this.colGozetmenAdi.OptionsColumn.AllowEdit = false;
            this.colGozetmenAdi.OptionsColumn.AllowMove = false;
            this.colGozetmenAdi.StatusBarAciklama = null;
            this.colGozetmenAdi.StatusBarKisayol = null;
            this.colGozetmenAdi.StatusBarKisayolAciklama = null;
            this.colGozetmenAdi.Visible = true;
            this.colGozetmenAdi.VisibleIndex = 0;
            this.colGozetmenAdi.Width = 692;
            // 
            // colGorevlendirilmeSayisi
            // 
            this.colGorevlendirilmeSayisi.Caption = "Görevlendirilme Sayısı";
            this.colGorevlendirilmeSayisi.FieldName = "GorevlendirmeSayisi";
            this.colGorevlendirilmeSayisi.Name = "colGorevlendirilmeSayisi";
            this.colGorevlendirilmeSayisi.OptionsColumn.AllowEdit = false;
            this.colGorevlendirilmeSayisi.OptionsColumn.AllowMove = false;
            this.colGorevlendirilmeSayisi.StatusBarAciklama = null;
            this.colGorevlendirilmeSayisi.StatusBarKisayol = null;
            this.colGorevlendirilmeSayisi.StatusBarKisayolAciklama = null;
            this.colGorevlendirilmeSayisi.Visible = true;
            this.colGorevlendirilmeSayisi.VisibleIndex = 2;
            this.colGorevlendirilmeSayisi.Width = 139;
            // 
            // colSinavSalonAdi
            // 
            this.colSinavSalonAdi.Caption = "Görevlendirildiği Salon";
            this.colSinavSalonAdi.FieldName = "SinavSalonAdi";
            this.colSinavSalonAdi.Name = "colSinavSalonAdi";
            this.colSinavSalonAdi.OptionsColumn.AllowEdit = false;
            this.colSinavSalonAdi.OptionsColumn.AllowMove = false;
            this.colSinavSalonAdi.StatusBarAciklama = null;
            this.colSinavSalonAdi.StatusBarKisayol = null;
            this.colSinavSalonAdi.StatusBarKisayolAciklama = null;
            this.colSinavSalonAdi.Visible = true;
            this.colSinavSalonAdi.VisibleIndex = 1;
            this.colSinavSalonAdi.Width = 264;
            // 
            // GozetmenBilgileriTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "GozetmenBilgileriTable";
            this.Controls.SetChildIndex(this.ınsUptNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Controls.Grid.DpuGridView tablo;
        private Controls.Grid.DpuGridColumn colGozetmenAdi;
        private Controls.Grid.DpuGridColumn colGorevlendirilmeSayisi;
        public Controls.Grid.DpuGridControl grid;
        private Controls.Grid.DpuGridColumn colSinavSalonAdi;
    }
}
