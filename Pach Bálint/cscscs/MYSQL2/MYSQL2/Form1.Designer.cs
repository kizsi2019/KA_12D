namespace CRUD
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(39, 23);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(140, 45);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create Table";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(39, 117);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(140, 44);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = "Insert Data In Table";
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(39, 203);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(140, 45);
            this.btnRead.TabIndex = 2;
            this.btnRead.Text = "Read Data From Table";
            this.btnRead.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(39, 295);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(140, 44);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update Table";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(39, 368);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(140, 40);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete Record";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(269, 42);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(173, 20);
            this.tb1.TabIndex = 5;
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(269, 130);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(173, 20);
            this.tb2.TabIndex = 6;
            // 
            // tb3
            // 
            this.tb3.Location = new System.Drawing.Point(269, 203);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(173, 20);
            this.tb3.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(506, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 278);
            this.dataGridView1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tb3);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnCreate);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

