namespace FORMS
{
    partial class FormMain
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
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 47);
            button1.Name = "button1";
            button1.Size = new Size(139, 37);
            button1.TabIndex = 0;
            button1.Text = "ADO.NET";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(12, 104);
            button2.Name = "button2";
            button2.Size = new Size(139, 40);
            button2.TabIndex = 1;
            button2.Text = "ENTITYFRAME";
            button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Location = new Point(184, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(829, 355);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Location = new Point(184, 398);
            panel2.Name = "panel2";
            panel2.Size = new Size(829, 350);
            panel2.TabIndex = 3;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1095, 774);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "FormMain";
            Text = "FormMain";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Panel panel1;
        private Panel panel2;
    }
}