namespace EFDbFirst.Crud.Forms;

partial class FrmAddProduct
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
        btnAdd = new Button();
        txtPrice = new TextBox();
        txtStock = new TextBox();
        txtName = new TextBox();
        cmbCategory = new ComboBox();
        label4 = new Label();
        label3 = new Label();
        label2 = new Label();
        label1 = new Label();
        SuspendLayout();
        // 
        // btnAdd
        // 
        btnAdd.Location = new Point(689, 546);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(150, 46);
        btnAdd.TabIndex = 12;
        btnAdd.Text = "Add";
        btnAdd.UseVisualStyleBackColor = true;
        btnAdd.Click += btnAdd_Click;
        // 
        // txtPrice
        // 
        txtPrice.Location = new Point(597, 461);
        txtPrice.Name = "txtPrice";
        txtPrice.Size = new Size(242, 39);
        txtPrice.TabIndex = 9;
        // 
        // txtStock
        // 
        txtStock.Location = new Point(597, 381);
        txtStock.Name = "txtStock";
        txtStock.Size = new Size(242, 39);
        txtStock.TabIndex = 10;
        // 
        // txtName
        // 
        txtName.Location = new Point(597, 293);
        txtName.Name = "txtName";
        txtName.Size = new Size(242, 39);
        txtName.TabIndex = 11;
        // 
        // cmbCategory
        // 
        cmbCategory.FormattingEnabled = true;
        cmbCategory.Location = new Point(597, 190);
        cmbCategory.Name = "cmbCategory";
        cmbCategory.Size = new Size(242, 40);
        cmbCategory.TabIndex = 8;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(398, 468);
        label4.Name = "label4";
        label4.Size = new Size(116, 32);
        label4.TabIndex = 4;
        label4.Text = "Unit Price";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(398, 388);
        label3.Name = "label3";
        label3.Size = new Size(71, 32);
        label3.TabIndex = 5;
        label3.Text = "Stock";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(398, 296);
        label2.Name = "label2";
        label2.Size = new Size(78, 32);
        label2.TabIndex = 6;
        label2.Text = "Name";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(398, 191);
        label1.Name = "label1";
        label1.Size = new Size(110, 32);
        label1.TabIndex = 7;
        label1.Text = "Category";
        // 
        // FrmAddProduct
        // 
        AutoScaleDimensions = new SizeF(13F, 32F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1236, 783);
        Controls.Add(btnAdd);
        Controls.Add(txtPrice);
        Controls.Add(txtStock);
        Controls.Add(txtName);
        Controls.Add(cmbCategory);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Name = "FrmAddProduct";
        Text = "FrmAddProduct";
        Load += FrmAddProduct_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btnAdd;
    private TextBox txtPrice;
    private TextBox txtStock;
    private TextBox txtName;
    private ComboBox cmbCategory;
    private Label label4;
    private Label label3;
    private Label label2;
    private Label label1;
}