namespace DESAFIO_WINDOWS_FORMS
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
            LabelName = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // LabelName
            // 
            LabelName.AutoSize = true;
            LabelName.Location = new Point(64, 85);
            LabelName.Name = "LabelName";
            LabelName.Size = new Size(65, 15);
            LabelName.TabIndex = 0;
            LabelName.Text = "João Pedro";
            // 
            // button1
            // 
            button1.Location = new Point(64, 300);
            button1.Name = "button1";
            button1.Size = new Size(183, 45);
            button1.TabIndex = 1;
            button1.Text = "ALTERAR NOME";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(LabelName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelName;
        private Button button1;
    }
}