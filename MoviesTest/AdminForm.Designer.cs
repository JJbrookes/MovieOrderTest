namespace MoviesTest
{
    partial class AdminForm
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.description = new System.Windows.Forms.RichTextBox();
            this.releaseYear = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.length = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.ageRating = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.length)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageRating)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AccessibleName = "connectButton";
            this.button1.Location = new System.Drawing.Point(291, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "View all movies";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(291, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 41);
            this.button2.TabIndex = 5;
            this.button2.Text = "Add test movie";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(454, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 43);
            this.button3.TabIndex = 6;
            this.button3.Text = "delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(454, 54);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(143, 41);
            this.button4.TabIndex = 7;
            this.button4.Text = "update";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(3, 12);
            this.title.Name = "title";
            this.title.PlaceholderText = "Title";
            this.title.Size = new System.Drawing.Size(141, 23);
            this.title.TabIndex = 8;
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(150, 21);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(113, 43);
            this.description.TabIndex = 14;
            this.description.Text = "";
            // 
            // releaseYear
            // 
            this.releaseYear.CustomFormat = "yyyy";
            this.releaseYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.releaseYear.Location = new System.Drawing.Point(150, 67);
            this.releaseYear.Name = "releaseYear";
            this.releaseYear.ShowUpDown = true;
            this.releaseYear.Size = new System.Drawing.Size(113, 23);
            this.releaseYear.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Movie Description";
            // 
            // length
            // 
            this.length.Location = new System.Drawing.Point(90, 65);
            this.length.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.length.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(54, 23);
            this.length.TabIndex = 17;
            this.length.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Length (Mins)";
            // 
            // ageRating
            // 
            this.ageRating.Location = new System.Drawing.Point(90, 41);
            this.ageRating.Maximum = new decimal(new int[] {
            21,
            0,
            0,
            0});
            this.ageRating.Name = "ageRating";
            this.ageRating.Size = new System.Drawing.Size(54, 23);
            this.ageRating.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Age Raing";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(488, 101);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(91, 24);
            this.button5.TabIndex = 21;
            this.button5.Text = "Back";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(291, 101);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(157, 41);
            this.searchButton.TabIndex = 22;
            this.searchButton.Text = "Search Movie";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(602, 146);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ageRating);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.length);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.releaseYear);
            this.Controls.Add(this.description);
            this.Controls.Add(this.title);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "AdminForm";
            this.Text = "Movie Database ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.length)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageRating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox title;
        private BindingSource bindingSource1;
        private RichTextBox description;
        private DateTimePicker releaseYear;
        private NumericUpDown length;
        private NumericUpDown ageRating;
        private Label label3;
        private Button button5;
        private Button searchButton;
    }
}