namespace EFDbFirst.Forms
{
    partial class FrmOneSupplier
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
            txtId = new TextBox();
            label1 = new Label();
            btnFind = new Button();
            label2 = new Label();
            lblCompanyName = new Label();
            label4 = new Label();
            lblContactName = new Label();
            label6 = new Label();
            lblContactTitle = new Label();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(281, 30);
            txtId.Name = "txtId";
            txtId.Size = new Size(150, 31);
            txtId.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(209, 33);
            label1.Name = "label1";
            label1.Size = new Size(28, 25);
            label1.TabIndex = 1;
            label1.Text = "Id";
            // 
            // btnFind
            // 
            btnFind.Location = new Point(319, 88);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(112, 34);
            btnFind.TabIndex = 2;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(95, 183);
            label2.Name = "label2";
            label2.Size = new Size(145, 25);
            label2.TabIndex = 3;
            label2.Text = "Company Name:";
            // 
            // lblCompanyName
            // 
            lblCompanyName.AutoSize = true;
            lblCompanyName.Location = new Point(281, 183);
            lblCompanyName.Name = "lblCompanyName";
            lblCompanyName.Size = new Size(22, 25);
            lblCompanyName.TabIndex = 3;
            lblCompanyName.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(95, 237);
            label4.Name = "label4";
            label4.Size = new Size(129, 25);
            label4.TabIndex = 3;
            label4.Text = "Contact Name:";
            // 
            // lblContactName
            // 
            lblContactName.AutoSize = true;
            lblContactName.Location = new Point(281, 237);
            lblContactName.Name = "lblContactName";
            lblContactName.Size = new Size(22, 25);
            lblContactName.TabIndex = 3;
            lblContactName.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(95, 296);
            label6.Name = "label6";
            label6.Size = new Size(114, 25);
            label6.TabIndex = 3;
            label6.Text = "Contact Title:";
            // 
            // lblContactTitle
            // 
            lblContactTitle.AutoSize = true;
            lblContactTitle.Location = new Point(281, 296);
            lblContactTitle.Name = "lblContactTitle";
            lblContactTitle.Size = new Size(22, 25);
            lblContactTitle.TabIndex = 3;
            lblContactTitle.Text = "0";
            // 
            // FrmOneSupplier
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblContactTitle);
            Controls.Add(label6);
            Controls.Add(lblContactName);
            Controls.Add(label4);
            Controls.Add(lblCompanyName);
            Controls.Add(label2);
            Controls.Add(btnFind);
            Controls.Add(label1);
            Controls.Add(txtId);
            Name = "FrmOneSupplier";
            Text = "FrmOneSupplier";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private Label label1;
        private Button btnFind;
        private Label label2;
        private Label lblCompanyName;
        private Label label4;
        private Label lblContactName;
        private Label label6;
        private Label lblContactTitle;
    }
}