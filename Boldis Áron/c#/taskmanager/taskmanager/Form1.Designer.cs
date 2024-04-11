namespace taskmanager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tasksGrid = new System.Windows.Forms.DataGridView();
            this.taskNameTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.descTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.statusList = new System.Windows.Forms.ComboBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.taskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tasksGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tasksGrid
            // 
            this.tasksGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tasksGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.taskName,
            this.description,
            this.status});
            this.tasksGrid.Location = new System.Drawing.Point(264, 9);
            this.tasksGrid.Name = "tasksGrid";
            this.tasksGrid.ReadOnly = true;
            this.tasksGrid.Size = new System.Drawing.Size(370, 251);
            this.tasksGrid.TabIndex = 0;
            this.tasksGrid.SelectionChanged += new System.EventHandler(this.DataGridView_SelectionChanged);
            // 
            // taskNameTxtBox
            // 
            this.taskNameTxtBox.Location = new System.Drawing.Point(80, 9);
            this.taskNameTxtBox.Name = "taskNameTxtBox";
            this.taskNameTxtBox.Size = new System.Drawing.Size(166, 20);
            this.taskNameTxtBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Feldat Név:";
            // 
            // descTxtBox
            // 
            this.descTxtBox.Location = new System.Drawing.Point(80, 44);
            this.descTxtBox.Name = "descTxtBox";
            this.descTxtBox.Size = new System.Drawing.Size(166, 20);
            this.descTxtBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-4, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Feladat Leírás:";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(12, 121);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(72, 31);
            this.addBtn.TabIndex = 5;
            this.addBtn.Text = "Hozzáadás";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Státusz:";
            // 
            // statusList
            // 
            this.statusList.FormattingEnabled = true;
            this.statusList.Items.AddRange(new object[] {
            "Kész",
            "Elkezdve",
            "Nincs Elkezdve"});
            this.statusList.Location = new System.Drawing.Point(80, 74);
            this.statusList.Name = "statusList";
            this.statusList.Size = new System.Drawing.Size(166, 21);
            this.statusList.TabIndex = 8;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(90, 121);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(72, 31);
            this.deleteBtn.TabIndex = 9;
            this.deleteBtn.Text = "Törlés";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(168, 121);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(72, 31);
            this.editBtn.TabIndex = 10;
            this.editBtn.Text = "Szerkesztés";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // taskName
            // 
            this.taskName.HeaderText = "Feladat";
            this.taskName.Name = "taskName";
            // 
            // description
            // 
            this.description.HeaderText = "Leírás";
            this.description.Name = "description";
            // 
            // status
            // 
            this.status.HeaderText = "Státusz";
            this.status.Name = "status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 321);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.statusList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.descTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.taskNameTxtBox);
            this.Controls.Add(this.tasksGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Feladat Kezelő";
            ((System.ComponentModel.ISupportInitialize)(this.tasksGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tasksGrid;
        private System.Windows.Forms.TextBox taskNameTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox descTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox statusList;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskName;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}

