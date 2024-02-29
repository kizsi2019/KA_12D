namespace MySQL2
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
            this.btnFeladat2 = new System.Windows.Forms.Button();
            this.btnFeladat3 = new System.Windows.Forms.Button();
            this.btnFeladat4 = new System.Windows.Forms.Button();
            this.btnFeladat5 = new System.Windows.Forms.Button();
            this.btnFeladat6 = new System.Windows.Forms.Button();
            this.btnFeladat7 = new System.Windows.Forms.Button();
            this.btnFeladat8 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCreate.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCreate.Location = new System.Drawing.Point(37, 37);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(108, 49);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create table";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnInsert.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnInsert.Location = new System.Drawing.Point(37, 102);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(108, 49);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = "Insert data in table";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnRead
            // 
            this.btnRead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnRead.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRead.Location = new System.Drawing.Point(37, 168);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(108, 49);
            this.btnRead.TabIndex = 2;
            this.btnRead.Text = "Read data from table";
            this.btnRead.UseVisualStyleBackColor = false;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnUpdate.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUpdate.Location = new System.Drawing.Point(37, 233);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(108, 49);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update table";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelete.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDelete.Location = new System.Drawing.Point(37, 299);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 49);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete record";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(340, 28);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(152, 20);
            this.tb1.TabIndex = 5;
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(592, 28);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(152, 20);
            this.tb2.TabIndex = 6;
            // 
            // tb3
            // 
            this.tb3.Location = new System.Drawing.Point(592, 66);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(152, 20);
            this.tb3.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(364, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(398, 277);
            this.dataGridView1.TabIndex = 8;
            // 
            // btnFeladat2
            // 
            this.btnFeladat2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnFeladat2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFeladat2.Location = new System.Drawing.Point(173, 37);
            this.btnFeladat2.Name = "btnFeladat2";
            this.btnFeladat2.Size = new System.Drawing.Size(108, 42);
            this.btnFeladat2.TabIndex = 9;
            this.btnFeladat2.Text = "2. feladat";
            this.btnFeladat2.UseVisualStyleBackColor = false;
            this.btnFeladat2.Click += new System.EventHandler(this.btnFeladat2_Click);
            // 
            // btnFeladat3
            // 
            this.btnFeladat3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnFeladat3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFeladat3.Location = new System.Drawing.Point(173, 85);
            this.btnFeladat3.Name = "btnFeladat3";
            this.btnFeladat3.Size = new System.Drawing.Size(108, 40);
            this.btnFeladat3.TabIndex = 10;
            this.btnFeladat3.Text = "3. feladat";
            this.btnFeladat3.UseVisualStyleBackColor = false;
            this.btnFeladat3.Click += new System.EventHandler(this.btnFeladat3_Click);
            // 
            // btnFeladat4
            // 
            this.btnFeladat4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnFeladat4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFeladat4.Location = new System.Drawing.Point(173, 131);
            this.btnFeladat4.Name = "btnFeladat4";
            this.btnFeladat4.Size = new System.Drawing.Size(108, 41);
            this.btnFeladat4.TabIndex = 11;
            this.btnFeladat4.Text = "4. feladat";
            this.btnFeladat4.UseVisualStyleBackColor = false;
            this.btnFeladat4.Click += new System.EventHandler(this.btnFeladat4_Click);
            // 
            // btnFeladat5
            // 
            this.btnFeladat5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnFeladat5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFeladat5.Location = new System.Drawing.Point(173, 178);
            this.btnFeladat5.Name = "btnFeladat5";
            this.btnFeladat5.Size = new System.Drawing.Size(108, 39);
            this.btnFeladat5.TabIndex = 12;
            this.btnFeladat5.Text = "5. feladat";
            this.btnFeladat5.UseVisualStyleBackColor = false;
            this.btnFeladat5.Click += new System.EventHandler(this.btnFeladat5_Click);
            // 
            // btnFeladat6
            // 
            this.btnFeladat6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnFeladat6.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFeladat6.Location = new System.Drawing.Point(173, 224);
            this.btnFeladat6.Name = "btnFeladat6";
            this.btnFeladat6.Size = new System.Drawing.Size(108, 39);
            this.btnFeladat6.TabIndex = 13;
            this.btnFeladat6.Text = "6. feladat";
            this.btnFeladat6.UseVisualStyleBackColor = false;
            this.btnFeladat6.Click += new System.EventHandler(this.btnFeladat6_Click);
            // 
            // btnFeladat7
            // 
            this.btnFeladat7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnFeladat7.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFeladat7.Location = new System.Drawing.Point(173, 271);
            this.btnFeladat7.Name = "btnFeladat7";
            this.btnFeladat7.Size = new System.Drawing.Size(108, 37);
            this.btnFeladat7.TabIndex = 14;
            this.btnFeladat7.Text = "7. feladat";
            this.btnFeladat7.UseVisualStyleBackColor = false;
            this.btnFeladat7.Click += new System.EventHandler(this.btnFeladat7_Click);
            // 
            // btnFeladat8
            // 
            this.btnFeladat8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnFeladat8.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFeladat8.Location = new System.Drawing.Point(173, 314);
            this.btnFeladat8.Name = "btnFeladat8";
            this.btnFeladat8.Size = new System.Drawing.Size(108, 34);
            this.btnFeladat8.TabIndex = 15;
            this.btnFeladat8.Text = "8. feladat";
            this.btnFeladat8.UseVisualStyleBackColor = false;
            this.btnFeladat8.Click += new System.EventHandler(this.btnFeladat8_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(524, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "Táblázat";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFeladat8);
            this.Controls.Add(this.btnFeladat7);
            this.Controls.Add(this.btnFeladat6);
            this.Controls.Add(this.btnFeladat5);
            this.Controls.Add(this.btnFeladat4);
            this.Controls.Add(this.btnFeladat3);
            this.Controls.Add(this.btnFeladat2);
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
        private System.Windows.Forms.Button btnFeladat2;
        private System.Windows.Forms.Button btnFeladat3;
        private System.Windows.Forms.Button btnFeladat4;
        private System.Windows.Forms.Button btnFeladat5;
        private System.Windows.Forms.Button btnFeladat6;
        private System.Windows.Forms.Button btnFeladat7;
        private System.Windows.Forms.Button btnFeladat8;
        private System.Windows.Forms.Label label1;
    }
}

