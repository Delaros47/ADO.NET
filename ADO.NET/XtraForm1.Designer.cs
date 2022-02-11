namespace ADO.NET
{
    partial class XtraForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraForm1));
            this.gcProducts = new DevExpress.XtraGrid.GridControl();
            this.gvProducts = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lblProductName = new DevExpress.XtraEditors.LabelControl();
            this.tbxProductName = new DevExpress.XtraEditors.TextEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.tbxStockAmount = new DevExpress.XtraEditors.TextEdit();
            this.lblStockAmount = new DevExpress.XtraEditors.LabelControl();
            this.tbxUnitPrice = new DevExpress.XtraEditors.TextEdit();
            this.lblUnitPrice = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gcProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbxStockAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxUnitPrice.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gcProducts
            // 
            this.gcProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcProducts.Location = new System.Drawing.Point(0, 0);
            this.gcProducts.MainView = this.gvProducts;
            this.gcProducts.Name = "gcProducts";
            this.gcProducts.Size = new System.Drawing.Size(872, 249);
            this.gcProducts.TabIndex = 0;
            this.gcProducts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProducts});
            // 
            // gvProducts
            // 
            this.gvProducts.GridControl = this.gcProducts;
            this.gvProducts.Name = "gvProducts";
            this.gvProducts.OptionsView.ShowGroupPanel = false;
            // 
            // lblProductName
            // 
            this.lblProductName.Location = new System.Drawing.Point(13, 36);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(71, 13);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "Product Name:";
            // 
            // tbxProductName
            // 
            this.tbxProductName.Location = new System.Drawing.Point(107, 33);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Properties.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tbxProductName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxProductName.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.tbxProductName.Properties.Appearance.Options.UseBackColor = true;
            this.tbxProductName.Properties.Appearance.Options.UseFont = true;
            this.tbxProductName.Properties.Appearance.Options.UseForeColor = true;
            this.tbxProductName.Size = new System.Drawing.Size(197, 22);
            this.tbxProductName.TabIndex = 2;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnAdd);
            this.panelControl1.Controls.Add(this.tbxStockAmount);
            this.panelControl1.Controls.Add(this.lblStockAmount);
            this.panelControl1.Controls.Add(this.tbxUnitPrice);
            this.panelControl1.Controls.Add(this.lblUnitPrice);
            this.panelControl1.Controls.Add(this.tbxProductName);
            this.panelControl1.Controls.Add(this.lblProductName);
            this.panelControl1.Location = new System.Drawing.Point(12, 273);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(361, 218);
            this.panelControl1.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.Location = new System.Drawing.Point(169, 151);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 38);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxStockAmount
            // 
            this.tbxStockAmount.Location = new System.Drawing.Point(107, 113);
            this.tbxStockAmount.Name = "tbxStockAmount";
            this.tbxStockAmount.Properties.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tbxStockAmount.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxStockAmount.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.tbxStockAmount.Properties.Appearance.Options.UseBackColor = true;
            this.tbxStockAmount.Properties.Appearance.Options.UseFont = true;
            this.tbxStockAmount.Properties.Appearance.Options.UseForeColor = true;
            this.tbxStockAmount.Size = new System.Drawing.Size(197, 22);
            this.tbxStockAmount.TabIndex = 2;
            // 
            // lblStockAmount
            // 
            this.lblStockAmount.Location = new System.Drawing.Point(13, 116);
            this.lblStockAmount.Name = "lblStockAmount";
            this.lblStockAmount.Size = new System.Drawing.Size(70, 13);
            this.lblStockAmount.TabIndex = 1;
            this.lblStockAmount.Text = "Stock Amount:";
            // 
            // tbxUnitPrice
            // 
            this.tbxUnitPrice.Location = new System.Drawing.Point(107, 75);
            this.tbxUnitPrice.Name = "tbxUnitPrice";
            this.tbxUnitPrice.Properties.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tbxUnitPrice.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxUnitPrice.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.tbxUnitPrice.Properties.Appearance.Options.UseBackColor = true;
            this.tbxUnitPrice.Properties.Appearance.Options.UseFont = true;
            this.tbxUnitPrice.Properties.Appearance.Options.UseForeColor = true;
            this.tbxUnitPrice.Size = new System.Drawing.Size(197, 22);
            this.tbxUnitPrice.TabIndex = 2;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.Location = new System.Drawing.Point(13, 78);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(49, 13);
            this.lblUnitPrice.TabIndex = 1;
            this.lblUnitPrice.Text = "Unit Price:";
            // 
            // XtraForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 566);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gcProducts);
            this.Name = "XtraForm1";
            this.Text = "XtraForm1";
            this.Load += new System.EventHandler(this.XtraForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbxStockAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxUnitPrice.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcProducts;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProducts;
        private DevExpress.XtraEditors.LabelControl lblProductName;
        private DevExpress.XtraEditors.TextEdit tbxProductName;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.TextEdit tbxStockAmount;
        private DevExpress.XtraEditors.LabelControl lblStockAmount;
        private DevExpress.XtraEditors.TextEdit tbxUnitPrice;
        private DevExpress.XtraEditors.LabelControl lblUnitPrice;
    }
}