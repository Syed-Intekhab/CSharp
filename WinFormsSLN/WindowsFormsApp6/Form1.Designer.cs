namespace WindowsFormsApp6
{
    partial class Form1
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
            this.counter = new System.Windows.Forms.Label();
            this.increase = new System.Windows.Forms.Button();
            this.decrease = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // counter
            // 
            this.counter.AutoSize = true;
            this.counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.counter.Location = new System.Drawing.Point(378, 85);
            this.counter.Name = "counter";
            this.counter.Size = new System.Drawing.Size(32, 36);
            this.counter.TabIndex = 0;
            this.counter.Text = "0";
            // 
            // increase
            // 
            this.increase.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.increase.Location = new System.Drawing.Point(211, 171);
            this.increase.Name = "increase";
            this.increase.Size = new System.Drawing.Size(147, 48);
            this.increase.TabIndex = 1;
            this.increase.Text = "Increase";
            this.increase.UseVisualStyleBackColor = true;
            this.increase.Click += new System.EventHandler(this.increase_Click);
            // 
            // decrease
            // 
            this.decrease.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decrease.Location = new System.Drawing.Point(414, 171);
            this.decrease.Name = "decrease";
            this.decrease.Size = new System.Drawing.Size(147, 48);
            this.decrease.TabIndex = 1;
            this.decrease.Text = "Decrease";
            this.decrease.UseVisualStyleBackColor = true;
            this.decrease.Click += new System.EventHandler(this.decrease_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.decrease);
            this.Controls.Add(this.increase);
            this.Controls.Add(this.counter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label counter;
        private System.Windows.Forms.Button increase;
        private System.Windows.Forms.Button decrease;
    }
}

