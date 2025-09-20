namespace Resume_App_Level_2
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
            this.btnAddSkill = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstSkills = new System.Windows.Forms.ListBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSkill = new System.Windows.Forms.TextBox();
            this.btnRemoveSkill = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtUniversity = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDegree = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.txtExpYears = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtAchievementDesc = new System.Windows.Forms.TextBox();
            this.txtAchievementHeading = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtLoad = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddSkill
            // 
            this.btnAddSkill.AccessibleDescription = "Clicking this button will add a new skill into the skill box";
            this.btnAddSkill.AccessibleName = "Add Skill";
            this.btnAddSkill.Location = new System.Drawing.Point(31, 216);
            this.btnAddSkill.Name = "btnAddSkill";
            this.btnAddSkill.Size = new System.Drawing.Size(130, 46);
            this.btnAddSkill.TabIndex = 6;
            this.btnAddSkill.Text = "Add";
            this.btnAddSkill.UseVisualStyleBackColor = true;
            this.btnAddSkill.Click += new System.EventHandler(this.btnAddSkill_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // lstSkills
            // 
            this.lstSkills.FormattingEnabled = true;
            this.lstSkills.ItemHeight = 25;
            this.lstSkills.Location = new System.Drawing.Point(31, 104);
            this.lstSkills.Name = "lstSkills";
            this.lstSkills.Size = new System.Drawing.Size(480, 104);
            this.lstSkills.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.AccessibleDescription = "In this field you have to enter your name.";
            this.txtName.AccessibleName = "Name Field";
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(126, 46);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(385, 41);
            this.txtName.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleDescription = "In this section use have to input their basic details.";
            this.groupBox1.AccessibleName = "Basic Details";
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAge);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(83, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 293);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Basic Details Section";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 36);
            this.label4.TabIndex = 1;
            this.label4.Text = "Phone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Age:";
            // 
            // txtPhone
            // 
            this.txtPhone.AccessibleDescription = "Enter your Phone Number";
            this.txtPhone.AccessibleName = "Phone Number Field";
            this.txtPhone.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(141, 221);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(370, 41);
            this.txtPhone.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 36);
            this.label3.TabIndex = 1;
            this.label3.Text = "Email:";
            // 
            // txtAge
            // 
            this.txtAge.AccessibleDescription = "Enter your age";
            this.txtAge.AccessibleName = "Age Field";
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(126, 101);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(385, 41);
            this.txtAge.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.AccessibleDescription = "Enter your email address";
            this.txtEmail.AccessibleName = "Email Field";
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(126, 159);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(385, 41);
            this.txtEmail.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.AccessibleDescription = "In this section use have to input their basic details.";
            this.groupBox2.AccessibleName = "Basic Details";
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtSkill);
            this.groupBox2.Controls.Add(this.btnRemoveSkill);
            this.groupBox2.Controls.Add(this.btnAddSkill);
            this.groupBox2.Controls.Add(this.lstSkills);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(678, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(551, 293);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Skills Section";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 36);
            this.label8.TabIndex = 1;
            this.label8.Text = "Skill:";
            // 
            // txtSkill
            // 
            this.txtSkill.AccessibleDescription = "In this field you have to enter your name.";
            this.txtSkill.AccessibleName = "Name Field";
            this.txtSkill.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSkill.Location = new System.Drawing.Point(126, 46);
            this.txtSkill.Name = "txtSkill";
            this.txtSkill.Size = new System.Drawing.Size(385, 41);
            this.txtSkill.TabIndex = 5;
            // 
            // btnRemoveSkill
            // 
            this.btnRemoveSkill.AccessibleDescription = "Clicking this button will remove the selected skill in the list box.";
            this.btnRemoveSkill.AccessibleName = "Remove Skill";
            this.btnRemoveSkill.Location = new System.Drawing.Point(179, 216);
            this.btnRemoveSkill.Name = "btnRemoveSkill";
            this.btnRemoveSkill.Size = new System.Drawing.Size(130, 46);
            this.btnRemoveSkill.TabIndex = 8;
            this.btnRemoveSkill.Text = "Remove";
            this.btnRemoveSkill.UseVisualStyleBackColor = true;
            this.btnRemoveSkill.Click += new System.EventHandler(this.btnRemoveSkill_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.AccessibleDescription = "In this section use have to input their basic details.";
            this.groupBox3.AccessibleName = "Basic Details";
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtYear);
            this.groupBox3.Controls.Add(this.txtUniversity);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtDegree);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(83, 419);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(551, 233);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Education Section";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 36);
            this.label6.TabIndex = 1;
            this.label6.Text = "Year:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 36);
            this.label7.TabIndex = 1;
            this.label7.Text = "University:";
            // 
            // txtYear
            // 
            this.txtYear.AccessibleDescription = "Enter your age";
            this.txtYear.AccessibleName = "Age Field";
            this.txtYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.Location = new System.Drawing.Point(126, 108);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(385, 41);
            this.txtYear.TabIndex = 10;
            // 
            // txtUniversity
            // 
            this.txtUniversity.AccessibleDescription = "Enter your email address";
            this.txtUniversity.AccessibleName = "Email Field";
            this.txtUniversity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUniversity.Location = new System.Drawing.Point(186, 167);
            this.txtUniversity.Name = "txtUniversity";
            this.txtUniversity.Size = new System.Drawing.Size(325, 41);
            this.txtUniversity.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(25, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 36);
            this.label9.TabIndex = 1;
            this.label9.Text = "Degree:";
            // 
            // txtDegree
            // 
            this.txtDegree.AccessibleDescription = "In this field you have to enter your name.";
            this.txtDegree.AccessibleName = "Name Field";
            this.txtDegree.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDegree.Location = new System.Drawing.Point(150, 46);
            this.txtDegree.Name = "txtDegree";
            this.txtDegree.Size = new System.Drawing.Size(361, 41);
            this.txtDegree.TabIndex = 9;
            // 
            // groupBox4
            // 
            this.groupBox4.AccessibleDescription = "In this section use have to input their basic details.";
            this.groupBox4.AccessibleName = "Basic Details";
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.txtRole);
            this.groupBox4.Controls.Add(this.txtExpYears);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.txtCompany);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(678, 419);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(551, 233);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Work Experience Section";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 36);
            this.label5.TabIndex = 1;
            this.label5.Text = "Role:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(25, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 36);
            this.label10.TabIndex = 1;
            this.label10.Text = "Years:";
            // 
            // txtRole
            // 
            this.txtRole.AccessibleDescription = "Enter your age";
            this.txtRole.AccessibleName = "Age Field";
            this.txtRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRole.Location = new System.Drawing.Point(126, 109);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(385, 41);
            this.txtRole.TabIndex = 13;
            // 
            // txtExpYears
            // 
            this.txtExpYears.AccessibleDescription = "Enter your email address";
            this.txtExpYears.AccessibleName = "Email Field";
            this.txtExpYears.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpYears.Location = new System.Drawing.Point(131, 170);
            this.txtExpYears.Name = "txtExpYears";
            this.txtExpYears.Size = new System.Drawing.Size(380, 41);
            this.txtExpYears.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(25, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(149, 36);
            this.label11.TabIndex = 1;
            this.label11.Text = "Company:";
            // 
            // txtCompany
            // 
            this.txtCompany.AccessibleDescription = "In this field you have to enter your name.";
            this.txtCompany.AccessibleName = "Name Field";
            this.txtCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompany.Location = new System.Drawing.Point(179, 46);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(332, 41);
            this.txtCompany.TabIndex = 12;
            // 
            // groupBox5
            // 
            this.groupBox5.AccessibleDescription = "In this section use have to input their basic details.";
            this.groupBox5.AccessibleName = "Basic Details";
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.txtAchievementDesc);
            this.groupBox5.Controls.Add(this.txtAchievementHeading);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(1279, 95);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(551, 557);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Achievement Section";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(25, 172);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(194, 36);
            this.label13.TabIndex = 1;
            this.label13.Text = "Achievement:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(25, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(313, 36);
            this.label12.TabIndex = 1;
            this.label12.Text = "Achievement Heading:";
            // 
            // txtAchievementDesc
            // 
            this.txtAchievementDesc.AccessibleDescription = "In this field you have to enter your name.";
            this.txtAchievementDesc.AccessibleName = "Name Field";
            this.txtAchievementDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAchievementDesc.Location = new System.Drawing.Point(31, 211);
            this.txtAchievementDesc.Multiline = true;
            this.txtAchievementDesc.Name = "txtAchievementDesc";
            this.txtAchievementDesc.Size = new System.Drawing.Size(490, 319);
            this.txtAchievementDesc.TabIndex = 16;
            // 
            // txtAchievementHeading
            // 
            this.txtAchievementHeading.AccessibleDescription = "In this field you have to enter your name.";
            this.txtAchievementHeading.AccessibleName = "Name Field";
            this.txtAchievementHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAchievementHeading.Location = new System.Drawing.Point(31, 99);
            this.txtAchievementHeading.Name = "txtAchievementHeading";
            this.txtAchievementHeading.Size = new System.Drawing.Size(490, 41);
            this.txtAchievementHeading.TabIndex = 15;
            // 
            // btnSave
            // 
            this.btnSave.AccessibleDescription = "Clicking this button will add a new skill into the skill box";
            this.btnSave.AccessibleName = "Add Skill";
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(83, 718);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(170, 60);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtLoad
            // 
            this.txtLoad.AccessibleDescription = "Clicking this button will add a new skill into the skill box";
            this.txtLoad.AccessibleName = "Add Skill";
            this.txtLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoad.Location = new System.Drawing.Point(278, 718);
            this.txtLoad.Name = "txtLoad";
            this.txtLoad.Size = new System.Drawing.Size(170, 60);
            this.txtLoad.TabIndex = 18;
            this.txtLoad.Text = "Load";
            this.txtLoad.UseVisualStyleBackColor = true;
            this.txtLoad.Click += new System.EventHandler(this.txtLoad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1788, 838);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.txtLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddSkill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstSkills;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSkill;
        private System.Windows.Forms.Button btnRemoveSkill;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtUniversity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDegree;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.TextBox txtExpYears;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtAchievementHeading;
        private System.Windows.Forms.TextBox txtAchievementDesc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button txtLoad;
    }
}

