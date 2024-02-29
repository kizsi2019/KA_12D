namespace CLUD
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
            this.btn_CreateTbl = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.btn_Read = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_DeleteRecord = new System.Windows.Forms.Button();
            this.tb_1 = new System.Windows.Forms.TextBox();
            this.tb_2 = new System.Windows.Forms.TextBox();
            this.tb_3 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_CreateTbl
            // 
            this.btn_CreateTbl.Location = new System.Drawing.Point(12, 12);
            this.btn_CreateTbl.Name = "btn_CreateTbl";
            this.btn_CreateTbl.Size = new System.Drawing.Size(119, 23);
            this.btn_CreateTbl.TabIndex = 0;
            this.btn_CreateTbl.Text = "Create Table";
            this.btn_CreateTbl.UseVisualStyleBackColor = true;
            this.btn_CreateTbl.Click += new System.EventHandler(this.btn_CreateTbl_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(12, 41);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(119, 23);
            this.btn_Insert.TabIndex = 1;
            this.btn_Insert.Text = "Insert Date Table";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // btn_Read
            // 
            this.btn_Read.Location = new System.Drawing.Point(12, 70);
            this.btn_Read.Name = "btn_Read";
            this.btn_Read.Size = new System.Drawing.Size(119, 23);
            this.btn_Read.TabIndex = 2;
            this.btn_Read.Text = "Read data from Table";
            this.btn_Read.UseVisualStyleBackColor = true;
            this.btn_Read.Click += new System.EventHandler(this.btn_Read_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(12, 99);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(119, 23);
            this.btn_Update.TabIndex = 3;
            this.btn_Update.Text = "Update Table";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_DeleteRecord
            // 
            this.btn_DeleteRecord.Location = new System.Drawing.Point(12, 128);
            this.btn_DeleteRecord.Name = "btn_DeleteRecord";
            this.btn_DeleteRecord.Size = new System.Drawing.Size(119, 23);
            this.btn_DeleteRecord.TabIndex = 4;
            this.btn_DeleteRecord.Text = "Delete Record";
            this.btn_DeleteRecord.UseVisualStyleBackColor = true;
            this.btn_DeleteRecord.Click += new System.EventHandler(this.btn_DeleteRecord_Click);
            // 
            // tb_1
            // 
            this.tb_1.Location = new System.Drawing.Point(178, 12);
            this.tb_1.Name = "tb_1";
            this.tb_1.Size = new System.Drawing.Size(100, 20);
            this.tb_1.TabIndex = 5;
            // 
            // tb_2
            // 
            this.tb_2.Location = new System.Drawing.Point(178, 44);
            this.tb_2.Name = "tb_2";
            this.tb_2.Size = new System.Drawing.Size(100, 20);
            this.tb_2.TabIndex = 6;
            // 
            // tb_3
            // 
            this.tb_3.Location = new System.Drawing.Point(178, 73);
            this.tb_3.Name = "tb_3";
            this.tb_3.Size = new System.Drawing.Size(100, 20);
            this.tb_3.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(178, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(600, 280);
            this.dataGridView1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tb_3);
            this.Controls.Add(this.tb_2);
            this.Controls.Add(this.tb_1);
            this.Controls.Add(this.btn_DeleteRecord);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Read);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.btn_CreateTbl);
            this.Name = "Form1";
            this.Text = "CLUD";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_CreateTbl;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Button btn_Read;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_DeleteRecord;
        private System.Windows.Forms.TextBox tb_1;
        private System.Windows.Forms.TextBox tb_2;
        private System.Windows.Forms.TextBox tb_3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

