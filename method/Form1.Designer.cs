namespace method
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblName = new Label();
            lblAge = new Label();
            lblHeight = new Label();
            lblWeight = new Label();
            txtName = new TextBox();
            txtAge = new TextBox();
            txtHeight = new TextBox();
            txtWeight = new TextBox();
            lblResult = new Label();
            btnbmi = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F);
            lblTitle.Location = new Point(248, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(271, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "โปรแกรมคำนวณค่า BMI";
            lblTitle.Click += label1_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(71, 95);
            lblName.Name = "lblName";
            lblName.Size = new Size(81, 20);
            lblName.TabIndex = 1;
            lblName.Text = "ชื่อ-นามสกุล";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(120, 142);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(32, 20);
            lblAge.TabIndex = 2;
            lblAge.Text = "อายุ";
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Location = new Point(71, 190);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(81, 20);
            lblHeight.TabIndex = 3;
            lblHeight.Text = "ส่วนสูง (cm)";
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Location = new Point(70, 239);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(82, 20);
            lblWeight.TabIndex = 4;
            lblWeight.Text = "น้ำหนัก (kg)";
            // 
            // txtName
            // 
            txtName.Location = new Point(168, 92);
            txtName.Name = "txtName";
            txtName.Size = new Size(236, 27);
            txtName.TabIndex = 1;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(168, 139);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(125, 27);
            txtAge.TabIndex = 2;
            txtAge.TextChanged += txtAge_TextChanged;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(168, 187);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(125, 27);
            txtHeight.TabIndex = 3;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(168, 236);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(125, 27);
            txtWeight.TabIndex = 4;
            // 
            // lblResult
            // 
            lblResult.BackColor = SystemColors.ActiveBorder;
            lblResult.Font = new Font("Segoe UI", 20F);
            lblResult.ForeColor = SystemColors.ButtonHighlight;
            lblResult.Location = new Point(12, 300);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(731, 218);
            lblResult.TabIndex = 9;
            lblResult.Text = "...";
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnbmi
            // 
            btnbmi.Location = new Point(509, 92);
            btnbmi.Name = "btnbmi";
            btnbmi.Size = new Size(188, 74);
            btnbmi.TabIndex = 5;
            btnbmi.Text = "ค่า BMI";
            btnbmi.UseVisualStyleBackColor = true;
            btnbmi.Click += button1_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(509, 190);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(188, 74);
            btnClear.TabIndex = 10;
            btnClear.Text = "เริ่มใหม่";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(755, 528);
            Controls.Add(btnClear);
            Controls.Add(btnbmi);
            Controls.Add(lblResult);
            Controls.Add(txtWeight);
            Controls.Add(txtHeight);
            Controls.Add(txtAge);
            Controls.Add(txtName);
            Controls.Add(lblWeight);
            Controls.Add(lblHeight);
            Controls.Add(lblAge);
            Controls.Add(lblName);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblName;
        private Label lblAge;
        private Label lblHeight;
        private Label lblWeight;
        private TextBox txtName;
        private TextBox txtAge;
        private TextBox txtHeight;
        private TextBox txtWeight;
        private Label lblResult;
        private Button btnbmi;
        private Button btnClear;
    }
}
