namespace W4Act_Gembox_Spreadsheet
{
    partial class MainForm
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
            dgvList = new DataGridView();
            btnLoad = new Button();
            btnSave = new Button();
            btnAddInput = new Button();
            labelTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvList).BeginInit();
            SuspendLayout();
            // 
            // dgvList
            // 
            dgvList.AllowUserToAddRows = false;
            dgvList.AllowUserToDeleteRows = false;
            dgvList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvList.Location = new Point(12, 56);
            dgvList.Name = "dgvList";
            dgvList.ReadOnly = true;
            dgvList.RowTemplate.Height = 25;
            dgvList.Size = new Size(776, 334);
            dgvList.TabIndex = 0;
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
            // btnAddInput
            // 
            btnAddInput.Location = new Point(12, 396);
            btnAddInput.Name = "btnAddInput";
            btnAddInput.Size = new Size(103, 42);
            btnAddInput.TabIndex = 3;
            btnAddInput.Text = "Add Input";
            btnAddInput.UseVisualStyleBackColor = true;
            btnAddInput.Click += btnAddInput_Click;
            // 
            // labelTitle
            // 
            labelTitle.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitle.Location = new Point(12, 9);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(302, 44);
            labelTitle.TabIndex = 4;
            labelTitle.Text = "Lorem ipsum dolor\r\n";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelTitle);
            Controls.Add(btnAddInput);
            Controls.Add(btnSave);
            Controls.Add(btnLoad);
            Controls.Add(dgvList);
            Name = "MainForm";
            Text = "Lorem ipsum dolor";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvList;
        private Button btnLoad;
        private Button btnSave;
        private Button btnAddInput;
        private Label labelTitle;
    }
}
