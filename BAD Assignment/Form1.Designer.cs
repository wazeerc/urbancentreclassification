namespace BAD_Assignment
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
            this.exitBtn = new System.Windows.Forms.Button();
            this.openBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.previousBtn = new System.Windows.Forms.Button();
            this.urbanCenterListBox = new System.Windows.Forms.ListBox();
            this.urbanCenterLabel = new System.Windows.Forms.Label();
            this.reportLabel = new System.Windows.Forms.Label();
            this.removeBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.smallestPopTextBox = new System.Windows.Forms.TextBox();
            this.largestPopTextBox = new System.Windows.Forms.TextBox();
            this.averageTextBox = new System.Windows.Forms.TextBox();
            this.totalPopulationtextBox = new System.Windows.Forms.TextBox();
            this.reportLabel1 = new System.Windows.Forms.Label();
            this.reportLabel2 = new System.Windows.Forms.Label();
            this.reportLabel3 = new System.Windows.Forms.Label();
            this.reportLabel4 = new System.Windows.Forms.Label();
            this.reportLabel5 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.classificationLabel = new System.Windows.Forms.Label();
            this.populationLabel = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.populationTextBox = new System.Windows.Forms.TextBox();
            this.classificationTextBox = new System.Windows.Forms.TextBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.genReportBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(643, 510);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 0;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // openBtn
            // 
            this.openBtn.Location = new System.Drawing.Point(643, 450);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(75, 23);
            this.openBtn.TabIndex = 1;
            this.openBtn.Text = "Open File";
            this.openBtn.UseVisualStyleBackColor = true;
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(299, 510);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(75, 23);
            this.nextBtn.TabIndex = 2;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // previousBtn
            // 
            this.previousBtn.Location = new System.Drawing.Point(204, 510);
            this.previousBtn.Name = "previousBtn";
            this.previousBtn.Size = new System.Drawing.Size(75, 23);
            this.previousBtn.TabIndex = 3;
            this.previousBtn.Text = "Previous";
            this.previousBtn.UseVisualStyleBackColor = true;
            this.previousBtn.Click += new System.EventHandler(this.previousBtn_Click);
            // 
            // urbanCenterListBox
            // 
            this.urbanCenterListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urbanCenterListBox.FormattingEnabled = true;
            this.urbanCenterListBox.ItemHeight = 16;
            this.urbanCenterListBox.Location = new System.Drawing.Point(24, 48);
            this.urbanCenterListBox.Name = "urbanCenterListBox";
            this.urbanCenterListBox.ScrollAlwaysVisible = true;
            this.urbanCenterListBox.Size = new System.Drawing.Size(350, 244);
            this.urbanCenterListBox.TabIndex = 4;
            this.urbanCenterListBox.SelectedIndexChanged += new System.EventHandler(this.urbanCenterListBox_SelectedIndexChanged_1);
            // 
            // urbanCenterLabel
            // 
            this.urbanCenterLabel.AutoSize = true;
            this.urbanCenterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urbanCenterLabel.Location = new System.Drawing.Point(21, 14);
            this.urbanCenterLabel.Name = "urbanCenterLabel";
            this.urbanCenterLabel.Size = new System.Drawing.Size(88, 13);
            this.urbanCenterLabel.TabIndex = 5;
            this.urbanCenterLabel.Text = "Urban Centers";
            // 
            // reportLabel
            // 
            this.reportLabel.AutoSize = true;
            this.reportLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportLabel.Location = new System.Drawing.Point(408, 14);
            this.reportLabel.Name = "reportLabel";
            this.reportLabel.Size = new System.Drawing.Size(45, 13);
            this.reportLabel.TabIndex = 6;
            this.reportLabel.Text = "Report";
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(643, 393);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(75, 23);
            this.removeBtn.TabIndex = 7;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(543, 393);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 8;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // smallestPopTextBox
            // 
            this.smallestPopTextBox.Location = new System.Drawing.Point(602, 272);
            this.smallestPopTextBox.Name = "smallestPopTextBox";
            this.smallestPopTextBox.Size = new System.Drawing.Size(116, 20);
            this.smallestPopTextBox.TabIndex = 11;
            // 
            // largestPopTextBox
            // 
            this.largestPopTextBox.Location = new System.Drawing.Point(602, 214);
            this.largestPopTextBox.Name = "largestPopTextBox";
            this.largestPopTextBox.Size = new System.Drawing.Size(116, 20);
            this.largestPopTextBox.TabIndex = 12;
            // 
            // averageTextBox
            // 
            this.averageTextBox.Location = new System.Drawing.Point(602, 156);
            this.averageTextBox.Name = "averageTextBox";
            this.averageTextBox.Size = new System.Drawing.Size(116, 20);
            this.averageTextBox.TabIndex = 13;
            // 
            // totalPopulationtextBox
            // 
            this.totalPopulationtextBox.Location = new System.Drawing.Point(602, 97);
            this.totalPopulationtextBox.Name = "totalPopulationtextBox";
            this.totalPopulationtextBox.Size = new System.Drawing.Size(116, 20);
            this.totalPopulationtextBox.TabIndex = 14;
            // 
            // reportLabel1
            // 
            this.reportLabel1.AutoSize = true;
            this.reportLabel1.Location = new System.Drawing.Point(408, 48);
            this.reportLabel1.Name = "reportLabel1";
            this.reportLabel1.Size = new System.Drawing.Size(149, 13);
            this.reportLabel1.TabIndex = 15;
            this.reportLabel1.Text = "Total Number of Urban Center";
            // 
            // reportLabel2
            // 
            this.reportLabel2.AutoSize = true;
            this.reportLabel2.Location = new System.Drawing.Point(408, 100);
            this.reportLabel2.Name = "reportLabel2";
            this.reportLabel2.Size = new System.Drawing.Size(84, 13);
            this.reportLabel2.TabIndex = 16;
            this.reportLabel2.Text = "Total Population";
            // 
            // reportLabel3
            // 
            this.reportLabel3.AutoSize = true;
            this.reportLabel3.Location = new System.Drawing.Point(408, 156);
            this.reportLabel3.Name = "reportLabel3";
            this.reportLabel3.Size = new System.Drawing.Size(100, 13);
            this.reportLabel3.TabIndex = 17;
            this.reportLabel3.Text = "Average Population";
            // 
            // reportLabel4
            // 
            this.reportLabel4.AutoSize = true;
            this.reportLabel4.Location = new System.Drawing.Point(408, 217);
            this.reportLabel4.Name = "reportLabel4";
            this.reportLabel4.Size = new System.Drawing.Size(95, 13);
            this.reportLabel4.TabIndex = 18;
            this.reportLabel4.Text = "Largest Population";
            // 
            // reportLabel5
            // 
            this.reportLabel5.AutoSize = true;
            this.reportLabel5.Location = new System.Drawing.Point(408, 279);
            this.reportLabel5.Name = "reportLabel5";
            this.reportLabel5.Size = new System.Drawing.Size(99, 13);
            this.reportLabel5.TabIndex = 19;
            this.reportLabel5.Text = "Smallest Population";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(21, 335);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(101, 13);
            this.nameLabel.TabIndex = 20;
            this.nameLabel.Text = "Urban Center Name";
            // 
            // classificationLabel
            // 
            this.classificationLabel.AutoSize = true;
            this.classificationLabel.Location = new System.Drawing.Point(21, 455);
            this.classificationLabel.Name = "classificationLabel";
            this.classificationLabel.Size = new System.Drawing.Size(68, 13);
            this.classificationLabel.TabIndex = 21;
            this.classificationLabel.Text = "Classification";
            // 
            // populationLabel
            // 
            this.populationLabel.AutoSize = true;
            this.populationLabel.Location = new System.Drawing.Point(21, 398);
            this.populationLabel.Name = "populationLabel";
            this.populationLabel.Size = new System.Drawing.Size(57, 13);
            this.populationLabel.TabIndex = 22;
            this.populationLabel.Text = "Population";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(543, 450);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 23;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(204, 332);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(170, 20);
            this.nameTextBox.TabIndex = 24;
            // 
            // populationTextBox
            // 
            this.populationTextBox.Location = new System.Drawing.Point(204, 395);
            this.populationTextBox.Name = "populationTextBox";
            this.populationTextBox.Size = new System.Drawing.Size(170, 20);
            this.populationTextBox.TabIndex = 25;
            // 
            // classificationTextBox
            // 
            this.classificationTextBox.Location = new System.Drawing.Point(204, 453);
            this.classificationTextBox.Name = "classificationTextBox";
            this.classificationTextBox.Size = new System.Drawing.Size(170, 20);
            this.classificationTextBox.TabIndex = 26;
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(602, 48);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(116, 20);
            this.totalTextBox.TabIndex = 9;
            // 
            // genReportBtn
            // 
            this.genReportBtn.Location = new System.Drawing.Point(543, 332);
            this.genReportBtn.Name = "genReportBtn";
            this.genReportBtn.Size = new System.Drawing.Size(175, 23);
            this.genReportBtn.TabIndex = 27;
            this.genReportBtn.Text = "Generate Report";
            this.genReportBtn.UseVisualStyleBackColor = true;
            this.genReportBtn.Click += new System.EventHandler(this.genReportBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 551);
            this.Controls.Add(this.genReportBtn);
            this.Controls.Add(this.classificationTextBox);
            this.Controls.Add(this.populationTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.populationLabel);
            this.Controls.Add(this.classificationLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.reportLabel5);
            this.Controls.Add(this.reportLabel4);
            this.Controls.Add(this.reportLabel3);
            this.Controls.Add(this.reportLabel2);
            this.Controls.Add(this.reportLabel1);
            this.Controls.Add(this.totalPopulationtextBox);
            this.Controls.Add(this.averageTextBox);
            this.Controls.Add(this.largestPopTextBox);
            this.Controls.Add(this.smallestPopTextBox);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.reportLabel);
            this.Controls.Add(this.urbanCenterLabel);
            this.Controls.Add(this.urbanCenterListBox);
            this.Controls.Add(this.previousBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.openBtn);
            this.Controls.Add(this.exitBtn);
            this.Name = "Form1";
            this.Text = "Urban Center Classification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button openBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button previousBtn;
        private System.Windows.Forms.ListBox urbanCenterListBox;
        private System.Windows.Forms.Label urbanCenterLabel;
        private System.Windows.Forms.Label reportLabel;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox smallestPopTextBox;
        private System.Windows.Forms.TextBox largestPopTextBox;
        private System.Windows.Forms.TextBox averageTextBox;
        private System.Windows.Forms.TextBox totalPopulationtextBox;
        private System.Windows.Forms.Label reportLabel1;
        private System.Windows.Forms.Label reportLabel2;
        private System.Windows.Forms.Label reportLabel3;
        private System.Windows.Forms.Label reportLabel4;
        private System.Windows.Forms.Label reportLabel5;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label classificationLabel;
        private System.Windows.Forms.Label populationLabel;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox populationTextBox;
        private System.Windows.Forms.TextBox classificationTextBox;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.Button genReportBtn;
    }
}

