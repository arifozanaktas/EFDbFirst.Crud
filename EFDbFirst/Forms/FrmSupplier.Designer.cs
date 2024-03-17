namespace EFDbFirst.Crud.Forms;

partial class FrmSupplier
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
        dataGridView1 = new DataGridView();
        btnDelete = new Button();
        txtCompany = new TextBox();
        label1 = new Label();
        txtContact = new TextBox();
        label2 = new Label();
        btnUpdate = new Button();
        btnAdd = new Button();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Location = new Point(22, 191);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowHeadersWidth = 82;
        dataGridView1.Size = new Size(990, 723);
        dataGridView1.TabIndex = 0;
        dataGridView1.CellClick += dataGridView1_CellClick;
        // 
        // btnDelete
        // 
        btnDelete.Location = new Point(32, 108);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(150, 46);
        btnDelete.TabIndex = 1;
        btnDelete.Text = "Delete";
        btnDelete.UseVisualStyleBackColor = true;
        btnDelete.Click += btnDelete_Click;
        // 
        // txtCompany
        // 
        txtCompany.Location = new Point(1309, 257);
        txtCompany.Name = "txtCompany";
        txtCompany.Size = new Size(276, 39);
        txtCompany.TabIndex = 2;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(1094, 260);
        label1.Name = "label1";
        label1.Size = new Size(187, 32);
        label1.TabIndex = 3;
        label1.Text = "Company Name";
        // 
        // txtContact
        // 
        txtContact.Location = new Point(1309, 328);
        txtContact.Name = "txtContact";
        txtContact.Size = new Size(276, 39);
        txtContact.TabIndex = 2;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(1094, 331);
        label2.Name = "label2";
        label2.Size = new Size(167, 32);
        label2.TabIndex = 3;
        label2.Text = "Contact Name";
        // 
        // btnUpdate
        // 
        btnUpdate.Location = new Point(1189, 426);
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Size = new Size(150, 46);
        btnUpdate.TabIndex = 4;
        btnUpdate.Text = "Update";
        btnUpdate.UseVisualStyleBackColor = true;
        btnUpdate.Click += btnUpdate_Click;
        // 
        // btnAdd
        // 
        btnAdd.Location = new Point(1435, 426);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(150, 46);
        btnAdd.TabIndex = 5;
        btnAdd.Text = "Add";
        btnAdd.UseVisualStyleBackColor = true;
        btnAdd.Click += btnAdd_Click;
        // 
        // FrmSupplier
        // 
        AutoScaleDimensions = new SizeF(13F, 32F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1672, 926);
        Controls.Add(btnAdd);
        Controls.Add(btnUpdate);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(txtContact);
        Controls.Add(txtCompany);
        Controls.Add(btnDelete);
        Controls.Add(dataGridView1);
        Name = "FrmSupplier";
        Text = "FrmSupplier";
        Load += FrmSupplier_Load;
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private DataGridView dataGridView1;
    private Button btnDelete;
    private TextBox txtCompany;
    private Label label1;
    private TextBox txtContact;
    private Label label2;
    private Button btnUpdate;
    private Button btnAdd;
}