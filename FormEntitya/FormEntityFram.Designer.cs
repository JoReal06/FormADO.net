namespace FORMS
{
    partial class FormEntityFram
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
            label4 = new Label();
            txt_FirstName_customers = new TextBox();
            dgv_CreditRisks = new DataGridView();
            dgv_Customers = new DataGridView();
            groupBox1 = new GroupBox();
            btn_delete_customers = new Button();
            btn_add_customers = new Button();
            btn_update_customers = new Button();
            txt_lastName_customers = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            label5 = new Label();
            cmb_customers = new ComboBox();
            btn_delete_credit = new Button();
            button1 = new Button();
            btn_add_credit = new Button();
            button2 = new Button();
            btn_update_credit = new Button();
            button3 = new Button();
            txt_lastName_crdit = new TextBox();
            label6 = new Label();
            txt_firtsName_credit = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_CreditRisks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Customers).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(6, 28);
            label4.Name = "label4";
            label4.Size = new Size(89, 21);
            label4.TabIndex = 18;
            label4.Text = "First Name:";
            // 
            // txt_FirstName_customers
            // 
            txt_FirstName_customers.Location = new Point(101, 30);
            txt_FirstName_customers.Name = "txt_FirstName_customers";
            txt_FirstName_customers.Size = new Size(137, 23);
            txt_FirstName_customers.TabIndex = 17;
            // 
            // dgv_CreditRisks
            // 
            dgv_CreditRisks.Anchor = AnchorStyles.Left;
            dgv_CreditRisks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_CreditRisks.Location = new Point(562, 193);
            dgv_CreditRisks.Name = "dgv_CreditRisks";
            dgv_CreditRisks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_CreditRisks.Size = new Size(531, 364);
            dgv_CreditRisks.TabIndex = 13;
            // 
            // dgv_Customers
            // 
            dgv_Customers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Customers.Location = new Point(17, 193);
            dgv_Customers.Name = "dgv_Customers";
            dgv_Customers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Customers.Size = new Size(526, 364);
            dgv_Customers.TabIndex = 12;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_delete_customers);
            groupBox1.Controls.Add(btn_add_customers);
            groupBox1.Controls.Add(btn_update_customers);
            groupBox1.Controls.Add(txt_lastName_customers);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txt_FirstName_customers);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(17, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(530, 141);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Customers";
            // 
            // btn_delete_customers
            // 
            btn_delete_customers.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_delete_customers.Location = new Point(312, 82);
            btn_delete_customers.Name = "btn_delete_customers";
            btn_delete_customers.Size = new Size(117, 26);
            btn_delete_customers.TabIndex = 23;
            btn_delete_customers.Text = "DELETE";
            btn_delete_customers.UseVisualStyleBackColor = true;
            btn_delete_customers.Click += btn_delete_customers_Click;
            // 
            // btn_add_customers
            // 
            btn_add_customers.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_add_customers.Location = new Point(260, 40);
            btn_add_customers.Name = "btn_add_customers";
            btn_add_customers.Size = new Size(101, 26);
            btn_add_customers.TabIndex = 21;
            btn_add_customers.Text = "ADD";
            btn_add_customers.UseVisualStyleBackColor = true;
            btn_add_customers.Click += btn_add_customers_Click;
            // 
            // btn_update_customers
            // 
            btn_update_customers.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_update_customers.Location = new Point(367, 40);
            btn_update_customers.Name = "btn_update_customers";
            btn_update_customers.Size = new Size(117, 26);
            btn_update_customers.TabIndex = 22;
            btn_update_customers.Text = "UPDATE";
            btn_update_customers.UseVisualStyleBackColor = true;
            btn_update_customers.Click += btn_update_customers_Click;
            // 
            // txt_lastName_customers
            // 
            txt_lastName_customers.Location = new Point(101, 69);
            txt_lastName_customers.Name = "txt_lastName_customers";
            txt_lastName_customers.Size = new Size(137, 23);
            txt_lastName_customers.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 67);
            label2.Name = "label2";
            label2.Size = new Size(80, 21);
            label2.TabIndex = 20;
            label2.Text = "LastName";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(cmb_customers);
            groupBox2.Controls.Add(btn_delete_credit);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(btn_add_credit);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(btn_update_credit);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(txt_lastName_crdit);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txt_firtsName_credit);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(562, 16);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(533, 151);
            groupBox2.TabIndex = 24;
            groupBox2.TabStop = false;
            groupBox2.Text = "Credit Risks";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(13, 116);
            label5.Name = "label5";
            label5.Size = new Size(88, 21);
            label5.TabIndex = 28;
            label5.Text = "Costumers:";
            // 
            // cmb_customers
            // 
            cmb_customers.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_customers.FormattingEnabled = true;
            cmb_customers.Location = new Point(107, 118);
            cmb_customers.Name = "cmb_customers";
            cmb_customers.Size = new Size(177, 23);
            cmb_customers.TabIndex = 27;
            // 
            // btn_delete_credit
            // 
            btn_delete_credit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_delete_credit.Location = new Point(324, 91);
            btn_delete_credit.Name = "btn_delete_credit";
            btn_delete_credit.Size = new Size(117, 26);
            btn_delete_credit.TabIndex = 26;
            btn_delete_credit.Text = "DELETE";
            btn_delete_credit.UseVisualStyleBackColor = true;
            btn_delete_credit.Click += btn_delete_credit_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(645, 133);
            button1.Name = "button1";
            button1.Size = new Size(117, 26);
            button1.TabIndex = 23;
            button1.Text = "DELETE";
            button1.UseVisualStyleBackColor = true;
            // 
            // btn_add_credit
            // 
            btn_add_credit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_add_credit.Location = new Point(272, 49);
            btn_add_credit.Name = "btn_add_credit";
            btn_add_credit.Size = new Size(101, 26);
            btn_add_credit.TabIndex = 24;
            btn_add_credit.Text = "ADD";
            btn_add_credit.UseVisualStyleBackColor = true;
            btn_add_credit.Click += btn_add_credit_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.Location = new Point(593, 91);
            button2.Name = "button2";
            button2.Size = new Size(101, 26);
            button2.TabIndex = 21;
            button2.Text = "ADD";
            button2.UseVisualStyleBackColor = true;
            // 
            // btn_update_credit
            // 
            btn_update_credit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_update_credit.Location = new Point(379, 49);
            btn_update_credit.Name = "btn_update_credit";
            btn_update_credit.Size = new Size(117, 26);
            btn_update_credit.TabIndex = 25;
            btn_update_credit.Text = "UPDATE";
            btn_update_credit.UseVisualStyleBackColor = true;
            btn_update_credit.Click += btn_update_credit_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button3.Location = new Point(700, 91);
            button3.Name = "button3";
            button3.Size = new Size(117, 26);
            button3.TabIndex = 22;
            button3.Text = "UPDATE";
            button3.UseVisualStyleBackColor = true;
            // 
            // txt_lastName_crdit
            // 
            txt_lastName_crdit.Location = new Point(101, 69);
            txt_lastName_crdit.Name = "txt_lastName_crdit";
            txt_lastName_crdit.Size = new Size(137, 23);
            txt_lastName_crdit.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(6, 67);
            label6.Name = "label6";
            label6.Size = new Size(80, 21);
            label6.TabIndex = 20;
            label6.Text = "LastName";
            // 
            // txt_firtsName_credit
            // 
            txt_firtsName_credit.Location = new Point(101, 30);
            txt_firtsName_credit.Name = "txt_firtsName_credit";
            txt_firtsName_credit.Size = new Size(137, 23);
            txt_firtsName_credit.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(6, 28);
            label7.Name = "label7";
            label7.Size = new Size(89, 21);
            label7.TabIndex = 18;
            label7.Text = "First Name:";
            // 
            // FormEntityFram
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 570);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dgv_CreditRisks);
            Controls.Add(dgv_Customers);
            Name = "FormEntityFram";
            Text = "FormEntityFram";
            Load += FormEntityFram_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_CreditRisks).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Customers).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label4;
        private TextBox txt_FirstName_customers;
        private DataGridView dgv_CreditRisks;
        private DataGridView dgv_Customers;
        private GroupBox groupBox1;
        private TextBox txt_lastName_customers;
        private Label label2;
        private Button btn_delete_customers;
        private Button btn_add_customers;
        private Button btn_update_customers;
        private GroupBox groupBox2;
        private Button btn_delete_credit;
        private Button button1;
        private Button btn_add_credit;
        private Button button2;
        private Button btn_update_credit;
        private Button button3;
        private TextBox txt_lastName_crdit;
        private Label label6;
        private TextBox txt_firtsName_credit;
        private Label label7;
        private Label label5;
        private ComboBox cmb_customers;
    }
}