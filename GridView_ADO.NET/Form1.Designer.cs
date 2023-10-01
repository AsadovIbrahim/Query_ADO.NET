namespace GridView_ADO.NET
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
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            execButton = new Button();
            fillButton = new Button();
            updateButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, 0);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1112, 75);
            textBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 180);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1112, 418);
            dataGridView1.TabIndex = 1;
            // 
            // execButton
            // 
            execButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            execButton.Location = new Point(12, 96);
            execButton.Name = "execButton";
            execButton.Size = new Size(154, 63);
            execButton.TabIndex = 2;
            execButton.Text = "Execute";
            execButton.UseVisualStyleBackColor = true;
            execButton.Click += execButton_Click;
            // 
            // fillButton
            // 
            fillButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            fillButton.Location = new Point(739, 96);
            fillButton.Name = "fillButton";
            fillButton.Size = new Size(154, 63);
            fillButton.TabIndex = 3;
            fillButton.Text = "Fill";
            fillButton.UseVisualStyleBackColor = true;
            fillButton.Click += fillButton_Click;
            // 
            // updateButton
            // 
            updateButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            updateButton.Location = new Point(909, 96);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(154, 63);
            updateButton.TabIndex = 4;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 595);
            Controls.Add(updateButton);
            Controls.Add(fillButton);
            Controls.Add(execButton);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Button execButton;
        private Button fillButton;
        private Button updateButton;
    }
}