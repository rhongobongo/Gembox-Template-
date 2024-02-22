namespace W4Act_Gembox_Spreadsheet
{
    partial class DataInfoForm
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
            grpbxInput = new GroupBox();
            btnInputDone = new Button();
            input1 = new TextBox();
            input5 = new TextBox();
            label5 = new Label();
            input4 = new TextBox();
            label4 = new Label();
            input3 = new TextBox();
            label3 = new Label();
            input2 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            grpbxInput.SuspendLayout();
            SuspendLayout();
            // 
            // grpbxInput
            // 
            grpbxInput.Controls.Add(btnInputDone);
            grpbxInput.Controls.Add(input1);
            grpbxInput.Controls.Add(input5);
            grpbxInput.Controls.Add(label5);
            grpbxInput.Controls.Add(input4);
            grpbxInput.Controls.Add(label4);
            grpbxInput.Controls.Add(input3);
            grpbxInput.Controls.Add(label3);
            grpbxInput.Controls.Add(input2);
            grpbxInput.Controls.Add(label2);
            grpbxInput.Controls.Add(label1);
            grpbxInput.Location = new Point(12, 12);
            grpbxInput.Name = "grpbxInput";
            grpbxInput.Size = new Size(320, 417);
            grpbxInput.TabIndex = 0;
            grpbxInput.TabStop = false;
            grpbxInput.Text = "Input Box";
            // 
            // btnInputDone
            // 
            btnInputDone.Location = new Point(122, 394);
            btnInputDone.Name = "btnInputDone";
            btnInputDone.Size = new Size(75, 23);
            btnInputDone.TabIndex = 11;
            btnInputDone.Text = "button1";
            btnInputDone.UseVisualStyleBackColor = true;
            btnInputDone.Click += btnInputDone_Click;
            // 
            // input1
            // 
            input1.Location = new Point(95, 21);
            input1.Name = "input1";
            input1.Size = new Size(219, 23);
            input1.TabIndex = 10;
            input1.TextChanged += input1_TextChanged;
            // 
            // input5
            // 
            input5.Location = new Point(95, 137);
            input5.Name = "input5";
            input5.Size = new Size(219, 23);
            input5.TabIndex = 9;
            input5.TextChanged += input5_TextChanged;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(6, 135);
            label5.Name = "label5";
            label5.Size = new Size(83, 25);
            label5.TabIndex = 8;
            label5.Text = "Input1";
            // 
            // input4
            // 
            input4.Location = new Point(95, 108);
            input4.Name = "input4";
            input4.Size = new Size(219, 23);
            input4.TabIndex = 7;
            input4.TextChanged += input4_TextChanged;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(6, 106);
            label4.Name = "label4";
            label4.Size = new Size(83, 25);
            label4.TabIndex = 6;
            label4.Text = "Input1";
            // 
            // input3
            // 
            input3.Location = new Point(95, 79);
            input3.Name = "input3";
            input3.Size = new Size(219, 23);
            input3.TabIndex = 5;
            input3.TextChanged += input3_TextChanged;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(6, 77);
            label3.Name = "label3";
            label3.Size = new Size(83, 25);
            label3.TabIndex = 4;
            label3.Text = "Input1";
            // 
            // input2
            // 
            input2.Location = new Point(95, 50);
            input2.Name = "input2";
            input2.Size = new Size(219, 23);
            input2.TabIndex = 3;
            input2.TextChanged += input2_TextChanged;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 48);
            label2.Name = "label2";
            label2.Size = new Size(83, 25);
            label2.TabIndex = 2;
            label2.Text = "Input1";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(83, 25);
            label1.TabIndex = 0;
            label1.Text = "Input1";
            // 
            // DataInfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 441);
            Controls.Add(grpbxInput);
            Name = "DataInfoForm";
            Text = "Input - Lorem ipsum dolor";
            grpbxInput.ResumeLayout(false);
            grpbxInput.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpbxInput;
        private Label label1;
        private TextBox input1;
        private TextBox input5;
        private Label label5;
        private TextBox input4;
        private Label label4;
        private TextBox input3;
        private Label label3;
        private TextBox input2;
        private Label label2;
        private Button btnInputDone;
    }
}