namespace MoviesTest
{
    partial class AllMovies
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
            this.allMoviesListView = new System.Windows.Forms.ListView();
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.Title = new System.Windows.Forms.ColumnHeader();
            this.Description = new System.Windows.Forms.ColumnHeader();
            this.Age_rating = new System.Windows.Forms.ColumnHeader();
            this.release_year = new System.Windows.Forms.ColumnHeader();
            this.length = new System.Windows.Forms.ColumnHeader();
            this.button1 = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.buyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // allMoviesListView
            // 
            this.allMoviesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Title,
            this.Description,
            this.Age_rating,
            this.release_year,
            this.length});
            this.allMoviesListView.Location = new System.Drawing.Point(12, 12);
            this.allMoviesListView.Name = "allMoviesListView";
            this.allMoviesListView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.allMoviesListView.Size = new System.Drawing.Size(530, 389);
            this.allMoviesListView.TabIndex = 0;
            this.allMoviesListView.UseCompatibleStateImageBehavior = false;
            this.allMoviesListView.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Tag = "ID";
            this.ID.Text = "ID";
            this.ID.Width = 30;
            // 
            // Title
            // 
            this.Title.Tag = "Title";
            this.Title.Text = "Title";
            this.Title.Width = 110;
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.Width = 200;
            // 
            // Age_rating
            // 
            this.Age_rating.Tag = "";
            this.Age_rating.Text = "Age Rating";
            this.Age_rating.Width = 80;
            // 
            // release_year
            // 
            this.release_year.Text = "Release Year";
            this.release_year.Width = 80;
            // 
            // length
            // 
            this.length.Text = "Length";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(463, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(98, 407);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(17, 407);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 3;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // buyButton
            // 
            this.buyButton.Enabled = false;
            this.buyButton.Location = new System.Drawing.Point(384, 407);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(73, 23);
            this.buyButton.TabIndex = 5;
            this.buyButton.Text = "Buy Movie";
            this.buyButton.UseVisualStyleBackColor = true;
            // 
            // AllMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 439);
            this.Controls.Add(this.buyButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.allMoviesListView);
            this.Name = "AllMovies";
            this.Text = "AllMovies";
            this.Load += new System.EventHandler(this.AllMovies_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ListView allMoviesListView;
        private ColumnHeader Title;
        private ColumnHeader Description;
        private ColumnHeader Age_rating;
        private ColumnHeader release_year;
        private ColumnHeader length;
        private Button button1;
        private Button deleteButton;
        private Button editButton;
        private Button buyButton;
        private ColumnHeader ID;
    }
}