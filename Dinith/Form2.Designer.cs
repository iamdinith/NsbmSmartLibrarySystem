namespace Library_Management_System
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
            this.bmrbtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bmbrbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bmbidtb = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.bmftb = new System.Windows.Forms.TextBox();
            this.bmlbtn = new System.Windows.Forms.Button();
            this.bmltb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(431, 195);
            this.dataGridView1.TabIndex = 0;
            // 
            // bmrbtn
            // 
            this.bmrbtn.Location = new System.Drawing.Point(665, 351);
            this.bmrbtn.Name = "bmrbtn";
            this.bmrbtn.Size = new System.Drawing.Size(134, 46);
            this.bmrbtn.TabIndex = 1;
            this.bmrbtn.Text = "REFRESH";
            this.bmrbtn.UseVisualStyleBackColor = true;
            this.bmrbtn.Click += new System.EventHandler(this.bgbtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bmbrbtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bmbidtb);
            this.groupBox1.Location = new System.Drawing.Point(571, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 122);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Book Return";
            // 
            // bmbrbtn
            // 
            this.bmbrbtn.Location = new System.Drawing.Point(42, 66);
            this.bmbrbtn.Name = "bmbrbtn";
            this.bmbrbtn.Size = new System.Drawing.Size(107, 23);
            this.bmbrbtn.TabIndex = 2;
            this.bmbrbtn.Text = "Book Returned";
            this.bmbrbtn.UseVisualStyleBackColor = true;
            this.bmbrbtn.Click += new System.EventHandler(this.bmbrbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Book ID:";
            // 
            // bmbidtb
            // 
            this.bmbidtb.Location = new System.Drawing.Point(85, 31);
            this.bmbidtb.Name = "bmbidtb";
            this.bmbidtb.Size = new System.Drawing.Size(82, 20);
            this.bmbidtb.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 276);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView2.Size = new System.Drawing.Size(629, 49);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Get Position";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bmftb
            // 
            this.bmftb.Location = new System.Drawing.Point(12, 250);
            this.bmftb.Name = "bmftb";
            this.bmftb.Size = new System.Drawing.Size(100, 20);
            this.bmftb.TabIndex = 5;
            // 
            // bmlbtn
            // 
            this.bmlbtn.Location = new System.Drawing.Point(402, 374);
            this.bmlbtn.Name = "bmlbtn";
            this.bmlbtn.Size = new System.Drawing.Size(75, 23);
            this.bmlbtn.TabIndex = 7;
            this.bmlbtn.Text = "Lent";
            this.bmlbtn.UseVisualStyleBackColor = true;
            this.bmlbtn.Click += new System.EventHandler(this.bmlbtn_Click);
            // 
            // bmltb
            // 
            this.bmltb.Location = new System.Drawing.Point(402, 348);
            this.bmltb.Name = "bmltb";
            this.bmltb.Size = new System.Drawing.Size(100, 20);
            this.bmltb.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(383, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Enter the book ID and click Lent to confirm that the book is lent to the borrower" +
    ":";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 409);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bmltb);
            this.Controls.Add(this.bmlbtn);
            this.Controls.Add(this.bmftb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bmrbtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Borrow and Return Management Interface";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bmrbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox bmbidtb;
        private System.Windows.Forms.Button bmbrbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox bmftb;
        private System.Windows.Forms.Button bmlbtn;
        private System.Windows.Forms.TextBox bmltb;
        private System.Windows.Forms.Label label2;
    }
}