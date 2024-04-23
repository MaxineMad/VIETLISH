namespace WinFormsApp1
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
            search = new Button();
            tb = new TextBox();
            searchstick = new ComboBox();
            tb1 = new TextBox();
            tb2 = new TextBox();
            close = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // search
            // 
            search.Cursor = Cursors.Hand;
            search.Location = new Point(594, 24);
            search.Name = "search";
            search.Size = new Size(94, 29);
            search.TabIndex = 0;
            search.Text = "search";
            search.UseVisualStyleBackColor = true;
            search.Click += search_Click;
            // 
            // tb
            // 
            tb.Location = new Point(12, 86);
            tb.Multiline = true;
            tb.Name = "tb";
            tb.ScrollBars = ScrollBars.Vertical;
            tb.Size = new Size(326, 352);
            tb.TabIndex = 1;
            // 
            // searchstick
            // 
            searchstick.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            searchstick.AutoCompleteSource = AutoCompleteSource.ListItems;
            searchstick.FormattingEnabled = true;
            searchstick.Location = new Point(195, 25);
            searchstick.MaxDropDownItems = 5;
            searchstick.Name = "searchstick";
            searchstick.Size = new Size(393, 28);
            searchstick.TabIndex = 2;
            searchstick.SelectedValueChanged += searchstick_SelectedValueChanged;
            // 
            // tb1
            // 
            tb1.Location = new Point(344, 368);
            tb1.Multiline = true;
            tb1.Name = "tb1";
            tb1.Size = new Size(444, 70);
            tb1.TabIndex = 3;
            // 
            // tb2
            // 
            tb2.Location = new Point(617, 86);
            tb2.Multiline = true;
            tb2.Name = "tb2";
            tb2.ScrollBars = ScrollBars.Vertical;
            tb2.Size = new Size(171, 254);
            tb2.TabIndex = 4;
            // 
            // close
            // 
            close.Location = new Point(95, 24);
            close.Name = "close";
            close.Size = new Size(94, 29);
            close.TabIndex = 5;
            close.Text = "QUIT";
            close.UseVisualStyleBackColor = true;
            close.Click += close_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(344, 343);
            label1.Name = "label1";
            label1.Size = new Size(84, 22);
            label1.TabIndex = 6;
            label1.Text = "v1-v2-v3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 61);
            label2.Name = "label2";
            label2.Size = new Size(78, 22);
            label2.TabIndex = 7;
            label2.Text = "Meaning";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(617, 61);
            label3.Name = "label3";
            label3.Size = new Size(175, 22);
            label3.TabIndex = 8;
            label3.Text = "Synonym && Antonym";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(344, 86);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(267, 254);
            textBox1.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(398, 61);
            label4.Name = "label4";
            label4.Size = new Size(111, 22);
            label4.TabIndex = 10;
            label4.Text = "Phrasel Verb";
            // 
            // Form1
            // 
            AcceptButton = search;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(close);
            Controls.Add(tb2);
            Controls.Add(tb1);
            Controls.Add(searchstick);
            Controls.Add(tb);
            Controls.Add(search);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DICTIONARY";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button search;
        private TextBox tb;
        private ComboBox searchstick;
        private TextBox tb1;
        private TextBox tb2;
        private Button close;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
    }
}
