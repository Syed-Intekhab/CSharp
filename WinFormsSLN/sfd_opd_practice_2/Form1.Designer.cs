namespace sfd_opd_practice_2
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chReading = new System.Windows.Forms.CheckBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.chSports = new System.Windows.Forms.CheckBox();
            this.chMusic = new System.Windows.Forms.CheckBox();
            this.chCoding = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(178, 51);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(529, 39);
            this.txtName.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(178, 352);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(147, 51);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // chReading
            // 
            this.chReading.AutoSize = true;
            this.chReading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chReading.Location = new System.Drawing.Point(178, 113);
            this.chReading.Name = "chReading";
            this.chReading.Size = new System.Drawing.Size(147, 36);
            this.chReading.TabIndex = 2;
            this.chReading.Text = "Reading";
            this.chReading.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(331, 352);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(147, 51);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // chSports
            // 
            this.chSports.AutoSize = true;
            this.chSports.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chSports.Location = new System.Drawing.Point(178, 155);
            this.chSports.Name = "chSports";
            this.chSports.Size = new System.Drawing.Size(122, 36);
            this.chSports.TabIndex = 3;
            this.chSports.Text = "Sports";
            this.chSports.UseVisualStyleBackColor = true;
            // 
            // chMusic
            // 
            this.chMusic.AutoSize = true;
            this.chMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chMusic.Location = new System.Drawing.Point(178, 197);
            this.chMusic.Name = "chMusic";
            this.chMusic.Size = new System.Drawing.Size(114, 36);
            this.chMusic.TabIndex = 4;
            this.chMusic.Text = "Music";
            this.chMusic.UseVisualStyleBackColor = true;
            // 
            // chCoding
            // 
            this.chCoding.AutoSize = true;
            this.chCoding.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chCoding.Location = new System.Drawing.Point(178, 239);
            this.chCoding.Name = "chCoding";
            this.chCoding.Size = new System.Drawing.Size(131, 36);
            this.chCoding.TabIndex = 5;
            this.chCoding.Text = "Coding";
            this.chCoding.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chCoding);
            this.Controls.Add(this.chMusic);
            this.Controls.Add(this.chSports);
            this.Controls.Add(this.chReading);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chReading;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.CheckBox chSports;
        private System.Windows.Forms.CheckBox chMusic;
        private System.Windows.Forms.CheckBox chCoding;
    }
}

