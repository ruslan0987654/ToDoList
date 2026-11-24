namespace TaskManager
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTask;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Label lblDeadline;
        private System.Windows.Forms.TextBox txtTask;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.DateTimePicker dtpDeadline;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvTasks;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn removeColumn;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTask = new System.Windows.Forms.Label();
            this.lblDetails = new System.Windows.Forms.Label();
            this.lblDeadline = new System.Windows.Forms.Label();
            this.txtTask = new System.Windows.Forms.TextBox();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.dtpDeadline = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvTasks = new System.Windows.Forms.DataGridView();
            this.taskColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.removeColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblHint = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTask
            // 
            this.lblTask.AutoSize = true;
            this.lblTask.ForeColor = System.Drawing.Color.FromArgb(105, 105, 105);
            this.lblTask.Location = new System.Drawing.Point(19, 15);
            this.lblTask.Name = "lblTask";
            this.lblTask.Size = new System.Drawing.Size(57, 19);
            this.lblTask.TabIndex = 0;
            this.lblTask.Text = "textBox1";
            // 
            // txtTask
            // 
            this.txtTask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTask.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTask.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtTask.Location = new System.Drawing.Point(19, 39);
            this.txtTask.Name = "txtTask";
            this.txtTask.Size = new System.Drawing.Size(681, 27);
            this.txtTask.TabIndex = 1;
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.ForeColor = System.Drawing.Color.FromArgb(105, 105, 105);
            this.lblDetails.Location = new System.Drawing.Point(19, 88);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(57, 19);
            this.lblDetails.TabIndex = 2;
            this.lblDetails.Text = "textBox2";
            // 
            // txtDetails
            // 
            this.txtDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDetails.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtDetails.Location = new System.Drawing.Point(19, 112);
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(681, 27);
            this.txtDetails.TabIndex = 3;
            // 
            // lblDeadline
            // 
            this.lblDeadline.AutoSize = true;
            this.lblDeadline.ForeColor = System.Drawing.Color.FromArgb(105, 105, 105);
            this.lblDeadline.Location = new System.Drawing.Point(19, 161);
            this.lblDeadline.Name = "lblDeadline";
            this.lblDeadline.Size = new System.Drawing.Size(108, 19);
            this.lblDeadline.TabIndex = 4;
            this.lblDeadline.Text = "dateTimePicker1";
            // 
            // dtpDeadline
            // 
            this.dtpDeadline.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDeadline.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpDeadline.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dtpDeadline.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDeadline.Location = new System.Drawing.Point(19, 185);
            this.dtpDeadline.Name = "dtpDeadline";
            this.dtpDeadline.Size = new System.Drawing.Size(681, 27);
            this.dtpDeadline.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(246, 245, 242);
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(160, 160, 160);
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(35, 35, 35);
            this.btnAdd.Location = new System.Drawing.Point(19, 247);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(681, 44);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "button1 — Əlavə et";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.AddTask);
            // 
            // dgvTasks
            // 
            this.dgvTasks.AllowUserToAddRows = false;
            this.dgvTasks.AllowUserToDeleteRows = false;
            this.dgvTasks.AllowUserToResizeRows = false;
            this.dgvTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTasks.BackgroundColor = System.Drawing.Color.White;
            this.dgvTasks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvTasks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTasks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvTasks.ColumnHeadersHeight = 36;
            this.dgvTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.taskColumn,
            this.detailsColumn,
            this.dateColumn,
            this.removeColumn});
            this.dgvTasks.EnableHeadersVisualStyles = false;
            this.dgvTasks.GridColor = System.Drawing.Color.FromArgb(215, 213, 207);
            this.dgvTasks.Location = new System.Drawing.Point(19, 313);
            this.dgvTasks.MultiSelect = false;
            this.dgvTasks.Name = "dgvTasks";
            this.dgvTasks.RowHeadersVisible = false;
            this.dgvTasks.RowTemplate.Height = 40;
            this.dgvTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTasks.Size = new System.Drawing.Size(681, 117);
            this.dgvTasks.TabIndex = 7;
            this.dgvTasks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TaskCellClicked);
            this.dgvTasks.CurrentCellDirtyStateChanged += new System.EventHandler(this.GridDirtyStateChanged);
            // 
            // taskColumn
            // 
            this.taskColumn.FillWeight = 28F;
            this.taskColumn.HeaderText = "Ad";
            this.taskColumn.Name = "taskColumn";
            this.taskColumn.ReadOnly = true;
            // 
            // detailsColumn
            // 
            this.detailsColumn.FillWeight = 28F;
            this.detailsColumn.HeaderText = "Təsvir";
            this.detailsColumn.Name = "detailsColumn";
            this.detailsColumn.ReadOnly = true;
            // 
            // dateColumn
            // 
            this.dateColumn.FillWeight = 28F;
            this.dateColumn.HeaderText = "Tarix";
            this.dateColumn.Name = "dateColumn";
            this.dateColumn.ReadOnly = true;
            // 
            // removeColumn
            // 
            this.removeColumn.FillWeight = 10F;
            this.removeColumn.HeaderText = "";
            this.removeColumn.Name = "removeColumn";
            this.removeColumn.ThreeState = false;
            // 
            // lblHint
            // 
            this.lblHint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblHint.AutoSize = true;
            this.lblHint.ForeColor = System.Drawing.Color.FromArgb(110, 110, 110);
            this.lblHint.Location = new System.Drawing.Point(19, 443);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(299, 19);
            this.lblHint.TabIndex = 8;
            this.lblHint.Text = "CheckBox sütununa klik → silmə təsdiqi çıxır";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(720, 600);
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.dgvTasks);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtpDeadline);
            this.Controls.Add(this.lblDeadline);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.txtTask);
            this.Controls.Add(this.lblTask);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MinimumSize = new System.Drawing.Size(650, 540);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1 — ToDoList";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
