namespace ofd_sfd_practice_3
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
            this.btnSave = new System.Windows.Forms.Button();
            this.chNotes = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdoCSharp = new System.Windows.Forms.RadioButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.chCertification = new System.Windows.Forms.CheckBox();
            this.chInternship = new System.Windows.Forms.CheckBox();
            this.rdoJava = new System.Windows.Forms.RadioButton();
            this.btnLoad = new System.Windows.Forms.Button();
            this.rdoPython = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(91, 365);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 50);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chNotes
            // 
            this.chNotes.AutoSize = true;
            this.chNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chNotes.Location = new System.Drawing.Point(91, 121);
            this.chNotes.Name = "chNotes";
            this.chNotes.Size = new System.Drawing.Size(114, 36);
            this.chNotes.TabIndex = 2;
            this.chNotes.Text = "Notes";
            this.chNotes.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // rdoCSharp
            // 
            this.rdoCSharp.AutoSize = true;
            this.rdoCSharp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoCSharp.Location = new System.Drawing.Point(324, 121);
            this.rdoCSharp.Name = "rdoCSharp";
            this.rdoCSharp.Size = new System.Drawing.Size(75, 36);
            this.rdoCSharp.TabIndex = 5;
            this.rdoCSharp.TabStop = true;
            this.rdoCSharp.Text = "C#";
            this.rdoCSharp.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(188, 48);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(508, 39);
            this.txtName.TabIndex = 1;
            // 
            // chCertification
            // 
            this.chCertification.AutoSize = true;
            this.chCertification.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chCertification.Location = new System.Drawing.Point(91, 163);
            this.chCertification.Name = "chCertification";
            this.chCertification.Size = new System.Drawing.Size(192, 36);
            this.chCertification.TabIndex = 3;
            this.chCertification.Text = "Certification";
            this.chCertification.UseVisualStyleBackColor = true;
            // 
            // chInternship
            // 
            this.chInternship.AutoSize = true;
            this.chInternship.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chInternship.Location = new System.Drawing.Point(91, 205);
            this.chInternship.Name = "chInternship";
            this.chInternship.Size = new System.Drawing.Size(165, 36);
            this.chInternship.TabIndex = 4;
            this.chInternship.Text = "Internship";
            this.chInternship.UseVisualStyleBackColor = true;
            // 
            // rdoJava
            // 
            this.rdoJava.AutoSize = true;
            this.rdoJava.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoJava.Location = new System.Drawing.Point(324, 163);
            this.rdoJava.Name = "rdoJava";
            this.rdoJava.Size = new System.Drawing.Size(99, 36);
            this.rdoJava.TabIndex = 6;
            this.rdoJava.TabStop = true;
            this.rdoJava.Text = "Java";
            this.rdoJava.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(224, 365);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(127, 50);
            this.btnLoad.TabIndex = 9;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // rdoPython
            // 
            this.rdoPython.AutoSize = true;
            this.rdoPython.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoPython.Location = new System.Drawing.Point(324, 204);
            this.rdoPython.Name = "rdoPython";
            this.rdoPython.Size = new System.Drawing.Size(128, 36);
            this.rdoPython.TabIndex = 7;
            this.rdoPython.TabStop = true;
            this.rdoPython.Text = "Python";
            this.rdoPython.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.rdoPython);
            this.Controls.Add(this.rdoJava);
            this.Controls.Add(this.rdoCSharp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chCertification);
            this.Controls.Add(this.chInternship);
            this.Controls.Add(this.chNotes);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chNotes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoCSharp;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.CheckBox chCertification;
        private System.Windows.Forms.CheckBox chInternship;
        private System.Windows.Forms.RadioButton rdoJava;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.RadioButton rdoPython;
    }
}

