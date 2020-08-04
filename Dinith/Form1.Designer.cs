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
            this.label9 = new System.Windows.Forms.Label();
            this.umdccb = new System.Windows.Forms.ComboBox();
            this.umdbtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.umdttb = new System.Windows.Forms.TextBox();
            this.umdftb = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dmutb = new System.Windows.Forms.TextBox();
            this.dmbtn = new System.Windows.Forms.Button();
            this.libraryDatabaseDataSet = new Library_Management_System.LibraryDatabaseDataSet();
            this.memberDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memberDetailsTableAdapter = new Library_Management_System.LibraryDatabaseDataSetTableAdapters.MemberDetailsTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.amctb);
            this.groupBox1.Controls.Add(this.ambtn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.amptb);
            this.groupBox1.Controls.Add(this.amutb);
            this.groupBox1.Controls.Add(this.amntb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.LightGray;
            this.groupBox1.Location = new System.Drawing.Point(13, 129);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1207, 186);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "A d d   M e m b e r";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(399, 58);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Contact no:";
            // 
            // amctb
            // 
            this.amctb.Location = new System.Drawing.Point(404, 80);
            this.amctb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.amctb.Name = "amctb";
            this.amctb.Size = new System.Drawing.Size(230, 26);
            this.amctb.TabIndex = 7;
            // 
            // ambtn
            // 
            this.ambtn.BackColor = System.Drawing.Color.Black;
            this.ambtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ambtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ambtn.Location = new System.Drawing.Point(963, 131);
            this.ambtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ambtn.Name = "ambtn";
            this.ambtn.Size = new System.Drawing.Size(112, 35);
            this.ambtn.TabIndex = 6;
            this.ambtn.Text = "ADD";
            this.ambtn.UseVisualStyleBackColor = false;
            this.ambtn.Click += new System.EventHandler(this.ambtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(399, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(50, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username:";
            // 
            // amptb
            // 
            this.amptb.Location = new System.Drawing.Point(404, 140);
            this.amptb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.amptb.Name = "amptb";
            this.amptb.Size = new System.Drawing.Size(230, 26);
            this.amptb.TabIndex = 3;
            // 
            // amutb
            // 
            this.amutb.Location = new System.Drawing.Point(54, 140);
            this.amutb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.amutb.Name = "amutb";
            this.amutb.Size = new System.Drawing.Size(230, 26);
            this.amutb.TabIndex = 2;
            // 
            // amntb
            // 
            this.amntb.Location = new System.Drawing.Point(54, 83);
            this.amntb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.amntb.Name = "amntb";
            this.amntb.Size = new System.Drawing.Size(230, 26);
            this.amntb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.umdccb);
            this.groupBox2.Controls.Add(this.umdbtn);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.umdttb);
            this.groupBox2.Controls.Add(this.umdftb);
            this.groupBox2.ForeColor = System.Drawing.Color.LightGray;
            this.groupBox2.Location = new System.Drawing.Point(13, 352);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(1207, 154);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "U p d a t e   M e m b e r   D e t a i l";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(50, 83);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Change:";
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
            this.umdccb.Location = new System.Drawing.Point(54, 108);
            this.umdccb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.umdccb.Name = "umdccb";
            this.umdccb.Size = new System.Drawing.Size(180, 28);
            this.umdccb.TabIndex = 9;
            // 
            // umdbtn
            // 
            this.umdbtn.BackColor = System.Drawing.Color.Black;
            this.umdbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.umdbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.umdbtn.Location = new System.Drawing.Point(963, 99);
            this.umdbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.umdbtn.Name = "umdbtn";
            this.umdbtn.Size = new System.Drawing.Size(112, 35);
            this.umdbtn.TabIndex = 7;
            this.umdbtn.Text = "UPDATE";
            this.umdbtn.UseVisualStyleBackColor = false;
            this.umdbtn.Click += new System.EventHandler(this.umdbtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(564, 83);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "To:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(269, 83);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "From:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // umdttb
            // 
            this.umdttb.Location = new System.Drawing.Point(568, 108);
            this.umdttb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.umdttb.Name = "umdttb";
            this.umdttb.Size = new System.Drawing.Size(254, 26);
            this.umdttb.TabIndex = 1;
            // 
            // umdftb
            // 
            this.umdftb.Location = new System.Drawing.Point(273, 108);
            this.umdftb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.umdftb.Name = "umdftb";
            this.umdftb.Size = new System.Drawing.Size(246, 26);
            this.umdftb.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.dmutb);
            this.groupBox3.Controls.Add(this.dmbtn);
            this.groupBox3.ForeColor = System.Drawing.Color.LightGray;
            this.groupBox3.Location = new System.Drawing.Point(13, 538);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(1207, 154);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "D e l e t e   M e m b e r";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(50, 80);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Username:";
            // 
            // dmutb
            // 
            this.dmutb.Location = new System.Drawing.Point(54, 105);
            this.dmutb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dmutb.Name = "dmutb";
            this.dmutb.Size = new System.Drawing.Size(230, 26);
            this.dmutb.TabIndex = 9;
            // 
            // dmbtn
            // 
            this.dmbtn.BackColor = System.Drawing.Color.Black;
            this.dmbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dmbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dmbtn.ForeColor = System.Drawing.Color.OrangeRed;
            this.dmbtn.Location = new System.Drawing.Point(963, 96);
            this.dmbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dmbtn.Name = "dmbtn";
            this.dmbtn.Size = new System.Drawing.Size(112, 35);
            this.dmbtn.TabIndex = 6;
            this.dmbtn.Text = "DELETE";
            this.dmbtn.UseVisualStyleBackColor = false;
            this.dmbtn.Click += new System.EventHandler(this.dmbtn_Click);
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
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(-34, -31);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1281, 126);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "     \r\n     NSBM\r\n     Smart Library System\r\n";
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Library_Management_System.Properties.Resources.menu;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(1158, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 75);
            this.button2.TabIndex = 11;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Library_Management_System.Properties.Resources.grey;
            this.ClientSize = new System.Drawing.Size(1233, 749);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
    }
}

