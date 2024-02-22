namespace W4Act_Gembox_Spreadsheet
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvClassList = new DataGridView();
            btnLoad = new Button();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClassList).BeginInit();
            SuspendLayout();
            // 
            // dgvClassList
            // 
            dgvClassList.AllowUserToAddRows = false;
            dgvClassList.AllowUserToDeleteRows = false;
            dgvClassList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClassList.Location = new Point(12, 12);
            dgvClassList.Name = "dgvClassList";
            dgvClassList.ReadOnly = true;
            dgvClassList.RowTemplate.Height = 25;
            dgvClassList.Size = new Size(776, 378);
            dgvClassList.TabIndex = 0;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(571, 396);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(103, 42);
            btnLoad.TabIndex = 1;
            btnLoad.Text = "Open File";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(680, 396);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(108, 42);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save File";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(btnLoad);
            Controls.Add(dgvClassList);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClassList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvClassList;
        private Button btnLoad;
        private Button btnSave;
    }
}
