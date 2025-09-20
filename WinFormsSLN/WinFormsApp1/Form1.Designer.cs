namespace WinFormsApp1
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
            label1 = new Label();
            result = new Label();
            greet = new Button();
            userName = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AccessibleDescription = "Enter your name in the following text box.";
            label1.AccessibleName = "Label for text box";
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(135, 85);
            label1.Name = "label1";
            label1.Size = new Size(104, 41);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // result
            // 
            result.AutoSize = true;
            result.Font = new Font("Segoe UI", 15F);
            result.Location = new Point(135, 316);
            result.Name = "result";
            result.Size = new Size(113, 41);
            result.TabIndex = 0;
            result.Text = "Result: ";
            // 
            // greet
            // 
            greet.Font = new Font("Segoe UI", 11F);
            greet.Location = new Point(322, 189);
            greet.Name = "greet";
            greet.Size = new Size(124, 48);
            greet.TabIndex = 1;
            greet.Text = "Say Hello";
            greet.UseVisualStyleBackColor = true;
            greet.Click += greet_Click;
            // 
            // userName
            // 
            userName.Font = new Font("Segoe UI", 15F);
            userName.Location = new Point(266, 82);
            userName.Name = "userName";
            userName.Size = new Size(359, 47);
            userName.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(userName);
            Controls.Add(greet);
            Controls.Add(result);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Hello WinForms";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label result;
        private Button greet;
        private TextBox userName;
    }
}
