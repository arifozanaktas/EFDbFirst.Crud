namespace EFDbFirst.Forms;

partial class FrmSearch
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
        label1 = new Label();
        txtMin = new TextBox();
        label2 = new Label();
        txtMax = new TextBox();
        btnFilter = new Button();
        dtGridView1 = new DataGridView();
        lblName = new Label();
        txtName = new TextBox();
        label3 = new Label();
        txtUnitPrice = new TextBox();
        label4 = new Label();
        txtStock = new TextBox();
        btnUpdate = new Button();
        ((System.ComponentModel.ISupportInitialize)dtGridView1).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(91, 54);
        label1.Name = "label1";
        label1.Size = new Size(61, 32);
        label1.TabIndex = 0;
        label1.Text = "Min:";
        // 
        // txtMin
        // 
        txtMin.Location = new Point(265, 57);
        txtMin.Name = "txtMin";
        txtMin.Size = new Size(200, 39);
        txtMin.TabIndex = 1;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(567, 54);
        label2.Name = "label2";
        label2.Size = new Size(64, 32);
        label2.TabIndex = 0;
        label2.Text = "Max:";
        // 
        // txtMax
        // 
        txtMax.Location = new Point(741, 57);
        txtMax.Name = "txtMax";
        txtMax.Size = new Size(200, 39);
        txtMax.TabIndex = 1;
        // 
        // btnFilter
        // 
        btnFilter.Location = new Point(1086, 50);
        btnFilter.Name = "btnFilter";
        btnFilter.Size = new Size(150, 46);
        btnFilter.TabIndex = 2;
        btnFilter.Text = "Filtrele";
        btnFilter.UseVisualStyleBackColor = true;
        btnFilter.Click += btnFilter_Click;
        // 
        // dtGridView1
        // 
        dtGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dtGridView1.Location = new Point(30, 156);
        dtGridView1.Name = "dtGridView1";
        dtGridView1.RowHeadersWidth = 82;
        dtGridView1.Size = new Size(793, 694);
        dtGridView1.TabIndex = 3;
        dtGridView1.CellClick += dtGridView1_CellClick;
        // 
        // lblName
        // 
        lblName.AutoSize = true;
        lblName.Location = new Point(829, 196);
        lblName.Name = "lblName";
        lblName.Size = new Size(83, 32);
        lblName.TabIndex = 0;
        lblName.Text = "Name:";
        // 
        // txtName
        // 
        txtName.Location = new Point(1003, 199);
        txtName.Name = "txtName";
        txtName.Size = new Size(358, 39);
        txtName.TabIndex = 1;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(829, 265);
        label3.Name = "label3";
        label3.Size = new Size(121, 32);
        label3.TabIndex = 0;
        label3.Text = "Unit Price:";
        // 
        // txtUnitPrice
        // 
        txtUnitPrice.Location = new Point(1003, 268);
        txtUnitPrice.Name = "txtUnitPrice";
        txtUnitPrice.Size = new Size(358, 39);
        txtUnitPrice.TabIndex = 1;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(829, 340);
        label4.Name = "label4";
        label4.Size = new Size(76, 32);
        label4.TabIndex = 0;
        label4.Text = "Stock:";
        // 
        // txtStock
        // 
        txtStock.Location = new Point(1003, 343);
        txtStock.Name = "txtStock";
        txtStock.Size = new Size(358, 39);
        txtStock.TabIndex = 1;
        // 
        // btnUpdate
        // 
        btnUpdate.Location = new Point(1211, 428);
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Size = new Size(150, 46);
        btnUpdate.TabIndex = 4;
        btnUpdate.Text = "Güncelle";
        btnUpdate.UseVisualStyleBackColor = true;
        btnUpdate.Click += btnUpdate_Click;
        // 
        // FrmSearch
        // 
        AutoScaleDimensions = new SizeF(13F, 32F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1612, 883);
        Controls.Add(btnUpdate);
        Controls.Add(dtGridView1);
        Controls.Add(btnFilter);
        Controls.Add(txtMax);
        Controls.Add(label2);
        Controls.Add(txtStock);
        Controls.Add(label4);
        Controls.Add(txtUnitPrice);
        Controls.Add(label3);
        Controls.Add(txtName);
        Controls.Add(lblName);
        Controls.Add(txtMin);
        Controls.Add(label1);
        Name = "FrmSearch";
        Text = "FrmSearch";
        ((System.ComponentModel.ISupportInitialize)dtGridView1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private TextBox txtMin;
    private Label label2;
    private TextBox txtMax;
    private Button btnFilter;
    private DataGridView dtGridView1;
    private Label lblName;
    private TextBox txtName;
    private Label label3;
    private TextBox txtUnitPrice;
    private Label label4;
    private TextBox txtStock;
    private Button btnUpdate;
}