namespace MoviesTest
{
    partial class HomeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.database_button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.searchMoviesButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to MovieMagic";
            // 
            // button1
            // 
            this.button1.AccessibleName = "connectButton";
            this.button1.Location = new System.Drawing.Point(70, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "View all movies";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // database_button
            // 
            this.database_button.Location = new System.Drawing.Point(70, 152);
            this.database_button.Name = "database_button";
            this.database_button.Size = new System.Drawing.Size(199, 43);
            this.database_button.TabIndex = 2;
            this.database_button.Text = "Edit Movie Database";
            this.database_button.UseVisualStyleBackColor = true;
            this.database_button.Click += new System.EventHandler(this.database_button_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(70, 104);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 42);
            this.button2.TabIndex = 3;
            this.button2.Text = " Explore Genres";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // searchMoviesButton
            // 
            this.searchMoviesButton.Location = new System.Drawing.Point(70, 263);
            this.searchMoviesButton.Name = "searchMoviesButton";
            this.searchMoviesButton.Size = new System.Drawing.Size(199, 36);
            this.searchMoviesButton.TabIndex = 4;
            this.searchMoviesButton.Text = "Search Movies";
            this.searchMoviesButton.UseVisualStyleBackColor = true;
            this.searchMoviesButton.Click += new System.EventHandler(this.searchMoviesButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(70, 234);
            this.searchBox.Name = "searchBox";
            this.searchBox.PlaceholderText = "Enter Title";
            this.searchBox.Size = new System.Drawing.Size(199, 23);
            this.searchBox.TabIndex = 5;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 342);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.searchMoviesButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.database_button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "HomeForm";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button button1;
        private Button database_button;
        private Button button2;
        private Button searchMoviesButton;
        private TextBox searchBox;
    }
}