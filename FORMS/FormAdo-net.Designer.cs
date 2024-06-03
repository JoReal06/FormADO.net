namespace FORMS
{
    partial class FormAdo_net
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
            btn_add_invetory = new Button();
            btn_update_inventory = new Button();
            dataGridView2 = new DataGridView();
            btn_delete_inventory = new Button();
            btn_refresh_dgvInventory = new Button();
            btn_refresh_gtvMakes = new Button();
            btn_delete_makes = new Button();
            btn_update_makes = new Button();
            btn_add_makes = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
            txt_name_makes = new TextBox();
            groupBox2 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            txt_petName = new TextBox();
            label3 = new Label();
            txt_color = new TextBox();
            cmb_makess = new ComboBox();
            label2 = new Label();
            txt_name_inventory = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 197);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(521, 364);
            dataGridView1.TabIndex = 0;
            // 
            // btn_add_invetory
            // 
            btn_add_invetory.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_add_invetory.Location = new Point(6, 129);
            btn_add_invetory.Name = "btn_add_invetory";
            btn_add_invetory.Size = new Size(110, 26);
            btn_add_invetory.TabIndex = 1;
            btn_add_invetory.Text = "ADD";
            btn_add_invetory.UseVisualStyleBackColor = true;
            // 
            // btn_update_inventory
            // 
            btn_update_inventory.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_update_inventory.Location = new Point(135, 129);
            btn_update_inventory.Name = "btn_update_inventory";
            btn_update_inventory.Size = new Size(126, 26);
            btn_update_inventory.TabIndex = 2;
            btn_update_inventory.Text = "UPDATE";
            btn_update_inventory.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.Anchor = AnchorStyles.Left;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(554, 215);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(606, 348);
            dataGridView2.TabIndex = 3;
            // 
            // btn_delete_inventory
            // 
            btn_delete_inventory.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_delete_inventory.Location = new Point(273, 129);
            btn_delete_inventory.Name = "btn_delete_inventory";
            btn_delete_inventory.Size = new Size(126, 26);
            btn_delete_inventory.TabIndex = 4;
            btn_delete_inventory.Text = "DELETE";
            btn_delete_inventory.UseVisualStyleBackColor = true;
            // 
            // btn_refresh_dgvInventory
            // 
            btn_refresh_dgvInventory.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_refresh_dgvInventory.Location = new Point(405, 129);
            btn_refresh_dgvInventory.Name = "btn_refresh_dgvInventory";
            btn_refresh_dgvInventory.Size = new Size(126, 26);
            btn_refresh_dgvInventory.TabIndex = 5;
            btn_refresh_dgvInventory.Text = "REFRESH DATA";
            btn_refresh_dgvInventory.UseVisualStyleBackColor = true;
            // 
            // btn_refresh_gtvMakes
            // 
            btn_refresh_gtvMakes.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_refresh_gtvMakes.Location = new Point(374, 86);
            btn_refresh_gtvMakes.Name = "btn_refresh_gtvMakes";
            btn_refresh_gtvMakes.Size = new Size(117, 26);
            btn_refresh_gtvMakes.TabIndex = 9;
            btn_refresh_gtvMakes.Text = "REFRESH DATA";
            btn_refresh_gtvMakes.UseVisualStyleBackColor = true;
            // 
            // btn_delete_makes
            // 
            btn_delete_makes.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_delete_makes.Location = new Point(251, 86);
            btn_delete_makes.Name = "btn_delete_makes";
            btn_delete_makes.Size = new Size(117, 26);
            btn_delete_makes.TabIndex = 8;
            btn_delete_makes.Text = "DELETE";
            btn_delete_makes.UseVisualStyleBackColor = true;
            // 
            // btn_update_makes
            // 
            btn_update_makes.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_update_makes.Location = new Point(118, 86);
            btn_update_makes.Name = "btn_update_makes";
            btn_update_makes.Size = new Size(117, 26);
            btn_update_makes.TabIndex = 7;
            btn_update_makes.Text = "UPDATE";
            btn_update_makes.UseVisualStyleBackColor = true;
            // 
            // btn_add_makes
            // 
            btn_add_makes.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_add_makes.Location = new Point(11, 86);
            btn_add_makes.Name = "btn_add_makes";
            btn_add_makes.Size = new Size(101, 26);
            btn_add_makes.TabIndex = 6;
            btn_add_makes.Text = "ADD";
            btn_add_makes.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txt_name_makes);
            groupBox1.Controls.Add(btn_delete_makes);
            groupBox1.Controls.Add(btn_add_makes);
            groupBox1.Controls.Add(btn_refresh_gtvMakes);
            groupBox1.Controls.Add(btn_update_makes);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(521, 167);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Makes";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 30);
            label1.Name = "label1";
            label1.Size = new Size(55, 21);
            label1.TabIndex = 11;
            label1.Text = "Name:";
            // 
            // txt_name_makes
            // 
            txt_name_makes.Location = new Point(69, 32);
            txt_name_makes.Name = "txt_name_makes";
            txt_name_makes.Size = new Size(255, 23);
            txt_name_makes.TabIndex = 10;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txt_petName);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txt_color);
            groupBox2.Controls.Add(cmb_makess);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(btn_refresh_dgvInventory);
            groupBox2.Controls.Add(txt_name_inventory);
            groupBox2.Controls.Add(btn_add_invetory);
            groupBox2.Controls.Add(btn_update_inventory);
            groupBox2.Controls.Add(btn_delete_inventory);
            groupBox2.Location = new Point(555, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(606, 187);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Inventory";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(223, 87);
            label5.Name = "label5";
            label5.Size = new Size(58, 21);
            label5.TabIndex = 19;
            label5.Text = "Makes:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(223, 40);
            label4.Name = "label4";
            label4.Size = new Size(80, 21);
            label4.TabIndex = 18;
            label4.Text = "Pet Name:";
            // 
            // txt_petName
            // 
            txt_petName.Location = new Point(309, 38);
            txt_petName.Name = "txt_petName";
            txt_petName.Size = new Size(137, 23);
            txt_petName.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(15, 85);
            label3.Name = "label3";
            label3.Size = new Size(51, 21);
            label3.TabIndex = 16;
            label3.Text = "Color:";
            // 
            // txt_color
            // 
            txt_color.Location = new Point(73, 87);
            txt_color.Name = "txt_color";
            txt_color.Size = new Size(137, 23);
            txt_color.TabIndex = 15;
            // 
            // cmb_makess
            // 
            cmb_makess.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_makess.FormattingEnabled = true;
            cmb_makess.Location = new Point(287, 89);
            cmb_makess.Name = "cmb_makess";
            cmb_makess.Size = new Size(177, 23);
            cmb_makess.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 40);
            label2.Name = "label2";
            label2.Size = new Size(55, 21);
            label2.TabIndex = 13;
            label2.Text = "Name:";
            // 
            // txt_name_inventory
            // 
            txt_name_inventory.Location = new Point(73, 42);
            txt_name_inventory.Name = "txt_name_inventory";
            txt_name_inventory.Size = new Size(137, 23);
            txt_name_inventory.TabIndex = 12;
            // 
            // FormAdo_net
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1172, 573);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Name = "FormAdo_net";
            Text = "FormAdo_net";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btn_add_invetory;
        private Button btn_update_inventory;
        private DataGridView dataGridView2;
        private Button btn_delete_inventory;
        private Button btn_refresh_dgvInventory;
        private Button btn_refresh_gtvMakes;
        private Button btn_delete_makes;
        private Button btn_update_makes;
        private Button btn_add_makes;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private TextBox txt_name_makes;
        private Label label5;
        private Label label4;
        private TextBox txt_petName;
        private Label label3;
        private TextBox txt_color;
        private ComboBox cmb_makess;
        private Label label2;
        private TextBox txt_name_inventory;
    }
}