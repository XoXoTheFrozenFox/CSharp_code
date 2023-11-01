namespace Act1
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnDisplayAll = new System.Windows.Forms.Button();
            this.txtDifficulty = new System.Windows.Forms.TextBox();
            this.txtDogBreed = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelectBetween = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDelete = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtInsertDogType = new System.Windows.Forms.TextBox();
            this.txtInsertPricePerCut = new System.Windows.Forms.TextBox();
            this.txtInsertPricePerWash = new System.Windows.Forms.TextBox();
            this.txtInsertCutDifficult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(604, 279);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(426, 319);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(178, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(426, 348);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(178, 23);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnDisplayAll
            // 
            this.btnDisplayAll.Location = new System.Drawing.Point(426, 290);
            this.btnDisplayAll.Name = "btnDisplayAll";
            this.btnDisplayAll.Size = new System.Drawing.Size(178, 23);
            this.btnDisplayAll.TabIndex = 3;
            this.btnDisplayAll.Text = "Display all";
            this.btnDisplayAll.UseVisualStyleBackColor = true;
            this.btnDisplayAll.Click += new System.EventHandler(this.btnDisplayAll_Click);
            // 
            // txtDifficulty
            // 
            this.txtDifficulty.Location = new System.Drawing.Point(261, 316);
            this.txtDifficulty.Name = "txtDifficulty";
            this.txtDifficulty.Size = new System.Drawing.Size(145, 20);
            this.txtDifficulty.TabIndex = 4;
            // 
            // txtDogBreed
            // 
            this.txtDogBreed.Location = new System.Drawing.Point(261, 345);
            this.txtDogBreed.Name = "txtDogBreed";
            this.txtDogBreed.Size = new System.Drawing.Size(145, 20);
            this.txtDogBreed.TabIndex = 5;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(66, 324);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(100, 13);
            this.lblSearch.TabIndex = 6;
            this.lblSearch.Text = "Search cut difficulty";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Find the dog breed";
            // 
            // btnSelectBetween
            // 
            this.btnSelectBetween.Location = new System.Drawing.Point(426, 377);
            this.btnSelectBetween.Name = "btnSelectBetween";
            this.btnSelectBetween.Size = new System.Drawing.Size(178, 23);
            this.btnSelectBetween.TabIndex = 9;
            this.btnSelectBetween.Text = "150 and 300";
            this.btnSelectBetween.UseVisualStyleBackColor = true;
            this.btnSelectBetween.Click += new System.EventHandler(this.btnSelectBetween_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Price per cut between 150 and 300";
            // 
            // cmbDelete
            // 
            this.cmbDelete.FormattingEnabled = true;
            this.cmbDelete.Location = new System.Drawing.Point(261, 410);
            this.cmbDelete.Name = "cmbDelete";
            this.cmbDelete.Size = new System.Drawing.Size(145, 21);
            this.cmbDelete.TabIndex = 11;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(426, 410);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(178, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtInsertDogType
            // 
            this.txtInsertDogType.Location = new System.Drawing.Point(841, 12);
            this.txtInsertDogType.Name = "txtInsertDogType";
            this.txtInsertDogType.Size = new System.Drawing.Size(145, 20);
            this.txtInsertDogType.TabIndex = 13;
            // 
            // txtInsertPricePerCut
            // 
            this.txtInsertPricePerCut.Location = new System.Drawing.Point(841, 38);
            this.txtInsertPricePerCut.Name = "txtInsertPricePerCut";
            this.txtInsertPricePerCut.Size = new System.Drawing.Size(145, 20);
            this.txtInsertPricePerCut.TabIndex = 14;
            // 
            // txtInsertPricePerWash
            // 
            this.txtInsertPricePerWash.Location = new System.Drawing.Point(841, 64);
            this.txtInsertPricePerWash.Name = "txtInsertPricePerWash";
            this.txtInsertPricePerWash.Size = new System.Drawing.Size(145, 20);
            this.txtInsertPricePerWash.TabIndex = 15;
            // 
            // txtInsertCutDifficult
            // 
            this.txtInsertCutDifficult.Location = new System.Drawing.Point(841, 90);
            this.txtInsertCutDifficult.Name = "txtInsertCutDifficult";
            this.txtInsertCutDifficult.Size = new System.Drawing.Size(145, 20);
            this.txtInsertCutDifficult.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(711, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Dog breed:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(711, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Price per cut:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(711, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Price per wash:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(711, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Cut difficulty:";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(758, 132);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(178, 23);
            this.btnInsert.TabIndex = 21;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1188, 682);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtInsertCutDifficult);
            this.Controls.Add(this.txtInsertPricePerWash);
            this.Controls.Add(this.txtInsertPricePerCut);
            this.Controls.Add(this.txtInsertDogType);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cmbDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelectBetween);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtDogBreed);
            this.Controls.Add(this.txtDifficulty);
            this.Controls.Add(this.btnDisplayAll);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnDisplayAll;
        private System.Windows.Forms.TextBox txtDifficulty;
        private System.Windows.Forms.TextBox txtDogBreed;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSelectBetween;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtInsertDogType;
        private System.Windows.Forms.TextBox txtInsertPricePerCut;
        private System.Windows.Forms.TextBox txtInsertPricePerWash;
        private System.Windows.Forms.TextBox txtInsertCutDifficult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnInsert;
    }
}