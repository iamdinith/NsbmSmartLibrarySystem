namespace Library_Management_System
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.amctb = new System.Windows.Forms.TextBox();
            this.ambtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.amptb = new System.Windows.Forms.TextBox();
            this.amutb = new System.Windows.Forms.TextBox();
            this.amntb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.umdbtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.umdttb = new System.Windows.Forms.TextBox();
            this.umdftb = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dmutb = new System.Windows.Forms.TextBox();
            this.dmbtn = new System.Windows.Forms.Button();
            this.umdccb = new System.Windows.Forms.ComboBox();
            this.libraryDatabaseDataSet = new Library_Management_System.LibraryDatabaseDataSet();
            this.memberDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memberDetailsTableAdapter = new Library_Management_System.LibraryDatabaseDataSetTableAdapters.MemberDetailsTableAdapter();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.amctb);
            this.groupBox1.Controls.Add(this.ambtn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.amptb);
            this.groupBox1.Controls.Add(this.amutb);
            this.groupBox1.Controls.Add(this.amntb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 121);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Member";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(266, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Contact no:";
            // 
            // amctb
            // 
            this.amctb.Location = new System.Drawing.Point(269, 52);
            this.amctb.Name = "amctb";
            this.amctb.Size = new System.Drawing.Size(155, 20);
            this.amctb.TabIndex = 7;
            // 
            // ambtn
            // 
            this.ambtn.Location = new System.Drawing.Point(642, 77);
            this.ambtn.Name = "ambtn";
            this.ambtn.Size = new System.Drawing.Size(75, 23);
            this.ambtn.TabIndex = 6;
            this.ambtn.Text = "ADD";
            this.ambtn.UseVisualStyleBackColor = true;
            this.ambtn.Click += new System.EventHandler(this.ambtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username:";
            // 
            // amptb
            // 
            this.amptb.Location = new System.Drawing.Point(269, 91);
            this.amptb.Name = "amptb";
            this.amptb.Size = new System.Drawing.Size(155, 20);
            this.amptb.TabIndex = 3;
            // 
            // amutb
            // 
            this.amutb.Location = new System.Drawing.Point(36, 91);
            this.amutb.Name = "amutb";
            this.amutb.Size = new System.Drawing.Size(155, 20);
            this.amutb.TabIndex = 2;
            // 
            // amntb
            // 
            this.amntb.Location = new System.Drawing.Point(36, 54);
            this.amntb.Name = "amntb";
            this.amntb.Size = new System.Drawing.Size(155, 20);
            this.amntb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.umdccb);
            this.groupBox2.Controls.Add(this.umdbtn);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.umdttb);
            this.groupBox2.Controls.Add(this.umdftb);
            this.groupBox2.Location = new System.Drawing.Point(12, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update Member Detail";
            // 
            // umdbtn
            // 
            this.umdbtn.Location = new System.Drawing.Point(642, 56);
            this.umdbtn.Name = "umdbtn";
            this.umdbtn.Size = new System.Drawing.Size(75, 23);
            this.umdbtn.TabIndex = 7;
            this.umdbtn.Text = "UPDATE";
            this.umdbtn.UseVisualStyleBackColor = true;
            this.umdbtn.Click += new System.EventHandler(this.umdbtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(376, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "To:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(185, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "From:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // umdttb
            // 
            this.umdttb.Location = new System.Drawing.Point(379, 58);
            this.umdttb.Name = "umdttb";
            this.umdttb.Size = new System.Drawing.Size(171, 20);
            this.umdttb.TabIndex = 1;
            // 
            // umdftb
            // 
            this.umdftb.Location = new System.Drawing.Point(188, 58);
            this.umdftb.Name = "umdftb";
            this.umdftb.Size = new System.Drawing.Size(165, 20);
            this.umdftb.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.dmutb);
            this.groupBox3.Controls.Add(this.dmbtn);
            this.groupBox3.Location = new System.Drawing.Point(12, 299);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(776, 100);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Delete Member";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Username:";
            // 
            // dmutb
            // 
            this.dmutb.Location = new System.Drawing.Point(36, 54);
            this.dmutb.Name = "dmutb";
            this.dmutb.Size = new System.Drawing.Size(155, 20);
            this.dmutb.TabIndex = 9;
            // 
            // dmbtn
            // 
            this.dmbtn.Location = new System.Drawing.Point(642, 52);
            this.dmbtn.Name = "dmbtn";
            this.dmbtn.Size = new System.Drawing.Size(75, 23);
            this.dmbtn.TabIndex = 6;
            this.dmbtn.Text = "DELETE";
            this.dmbtn.UseVisualStyleBackColor = true;
            this.dmbtn.Click += new System.EventHandler(this.dmbtn_Click);
            // 
            // umdccb
            // 
            this.umdccb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.umdccb.FormattingEnabled = true;
            this.umdccb.Items.AddRange(new object[] {
            "Name",
            "Username",
            "Password",
            "ContactNo"});
            this.umdccb.Location = new System.Drawing.Point(36, 58);
            this.umdccb.Name = "umdccb";
            this.umdccb.Size = new System.Drawing.Size(121, 21);
            this.umdccb.TabIndex = 9;
            // 
            // libraryDatabaseDataSet
            // 
            this.libraryDatabaseDataSet.DataSetName = "LibraryDatabaseDataSet";
            this.libraryDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // memberDetailsBindingSource
            // 
            this.memberDetailsBindingSource.DataMember = "MemberDetails";
            this.memberDetailsBindingSource.DataSource = this.libraryDatabaseDataSet;
            // 
            // memberDetailsTableAdapter
            // 
            this.memberDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Change:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Member Management Interface";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox amctb;
        private System.Windows.Forms.Button ambtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox amptb;
        private System.Windows.Forms.TextBox amutb;
        private System.Windows.Forms.TextBox amntb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button umdbtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox umdttb;
        private System.Windows.Forms.TextBox umdftb;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox dmutb;
        private System.Windows.Forms.Button dmbtn;
        private System.Windows.Forms.ComboBox umdccb;
        private LibraryDatabaseDataSet libraryDatabaseDataSet;
        private System.Windows.Forms.BindingSource memberDetailsBindingSource;
        private LibraryDatabaseDataSetTableAdapters.MemberDetailsTableAdapter memberDetailsTableAdapter;
        private System.Windows.Forms.Label label9;
    }
}

