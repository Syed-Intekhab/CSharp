namespace ofd_sfd_practice_5
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.chkFileUpload = new System.Windows.Forms.CheckBox();
            this.rdoExcellent = new System.Windows.Forms.RadioButton();
            this.chkChat = new System.Windows.Forms.CheckBox();
            this.chkNotification = new System.Windows.Forms.CheckBox();
            this.chkReports = new System.Windows.Forms.CheckBox();
            this.rdoGood = new System.Windows.Forms.RadioButton();
            this.rdoAverage = new System.Windows.Forms.RadioButton();
            this.rdoPoor = new System.Windows.Forms.RadioButton();
            this.btnLoad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(181, 51);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(503, 32);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(181, 332);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 45);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkFileUpload
            // 
            this.chkFileUpload.AutoSize = true;
            this.chkFileUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFileUpload.Location = new System.Drawing.Point(181, 109);
            this.chkFileUpload.Name = "chkFileUpload";
            this.chkFileUpload.Size = new System.Drawing.Size(148, 30);
            this.chkFileUpload.TabIndex = 2;
            this.chkFileUpload.Text = "File Upload";
            this.chkFileUpload.UseVisualStyleBackColor = true;
            // 
            // rdoExcellent
            // 
            this.rdoExcellent.AutoSize = true;
            this.rdoExcellent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoExcellent.Location = new System.Drawing.Point(390, 109);
            this.rdoExcellent.Name = "rdoExcellent";
            this.rdoExcellent.Size = new System.Drawing.Size(126, 30);
            this.rdoExcellent.TabIndex = 6;
            this.rdoExcellent.TabStop = true;
            this.rdoExcellent.Text = "Excellent";
            this.rdoExcellent.UseVisualStyleBackColor = true;
            // 
            // chkChat
            // 
            this.chkChat.AutoSize = true;
            this.chkChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkChat.Location = new System.Drawing.Point(181, 145);
            this.chkChat.Name = "chkChat";
            this.chkChat.Size = new System.Drawing.Size(84, 30);
            this.chkChat.TabIndex = 3;
            this.chkChat.Text = "Chat";
            this.chkChat.UseVisualStyleBackColor = true;
            // 
            // chkNotification
            // 
            this.chkNotification.AutoSize = true;
            this.chkNotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNotification.Location = new System.Drawing.Point(181, 181);
            this.chkNotification.Name = "chkNotification";
            this.chkNotification.Size = new System.Drawing.Size(146, 30);
            this.chkNotification.TabIndex = 4;
            this.chkNotification.Text = "Notification";
            this.chkNotification.UseVisualStyleBackColor = true;
            // 
            // chkReports
            // 
            this.chkReports.AutoSize = true;
            this.chkReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkReports.Location = new System.Drawing.Point(181, 217);
            this.chkReports.Name = "chkReports";
            this.chkReports.Size = new System.Drawing.Size(114, 30);
            this.chkReports.TabIndex = 5;
            this.chkReports.Text = "Reports";
            this.chkReports.UseVisualStyleBackColor = true;
            // 
            // rdoGood
            // 
            this.rdoGood.AutoSize = true;
            this.rdoGood.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoGood.Location = new System.Drawing.Point(390, 145);
            this.rdoGood.Name = "rdoGood";
            this.rdoGood.Size = new System.Drawing.Size(90, 30);
            this.rdoGood.TabIndex = 7;
            this.rdoGood.TabStop = true;
            this.rdoGood.Text = "Good";
            this.rdoGood.UseVisualStyleBackColor = true;
            // 
            // rdoAverage
            // 
            this.rdoAverage.AutoSize = true;
            this.rdoAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoAverage.Location = new System.Drawing.Point(390, 181);
            this.rdoAverage.Name = "rdoAverage";
            this.rdoAverage.Size = new System.Drawing.Size(118, 30);
            this.rdoAverage.TabIndex = 8;
            this.rdoAverage.TabStop = true;
            this.rdoAverage.Text = "Average";
            this.rdoAverage.UseVisualStyleBackColor = true;
            // 
            // rdoPoor
            // 
            this.rdoPoor.AutoSize = true;
            this.rdoPoor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoPoor.Location = new System.Drawing.Point(390, 217);
            this.rdoPoor.Name = "rdoPoor";
            this.rdoPoor.Size = new System.Drawing.Size(83, 30);
            this.rdoPoor.TabIndex = 9;
            this.rdoPoor.TabStop = true;
            this.rdoPoor.Text = "Poor";
            this.rdoPoor.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(301, 332);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(114, 45);
            this.btnLoad.TabIndex = 11;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rdoPoor);
            this.Controls.Add(this.rdoAverage);
            this.Controls.Add(this.rdoGood);
            this.Controls.Add(this.rdoExcellent);
            this.Controls.Add(this.chkReports);
            this.Controls.Add(this.chkNotification);
            this.Controls.Add(this.chkChat);
            this.Controls.Add(this.chkFileUpload);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chkFileUpload;
        private System.Windows.Forms.RadioButton rdoExcellent;
        private System.Windows.Forms.CheckBox chkChat;
        private System.Windows.Forms.CheckBox chkNotification;
        private System.Windows.Forms.CheckBox chkReports;
        private System.Windows.Forms.RadioButton rdoGood;
        private System.Windows.Forms.RadioButton rdoAverage;
        private System.Windows.Forms.RadioButton rdoPoor;
        private System.Windows.Forms.Button btnLoad;
    }
}

