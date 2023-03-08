namespace MediaRegistret_EE22;

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
        tabControl1 = new TabControl();
        tabPage1 = new TabPage();
        btnAddBook = new Button();
        numBookPages = new NumericUpDown();
        tbxBookAuthor = new TextBox();
        tbxBookTitle = new TextBox();
        label3 = new Label();
        label2 = new Label();
        label1 = new Label();
        tabPage2 = new TabPage();
        btnAddMovie = new Button();
        numMovieLength = new NumericUpDown();
        tbxMovieDirector = new TextBox();
        tbxMovieTitle = new TextBox();
        label4 = new Label();
        label5 = new Label();
        label6 = new Label();
        listBox1 = new ListBox();
        groupBox1 = new GroupBox();
        rbMovies = new RadioButton();
        rbBooks = new RadioButton();
        rbAll = new RadioButton();
        tabControl1.SuspendLayout();
        tabPage1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numBookPages).BeginInit();
        tabPage2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numMovieLength).BeginInit();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // tabControl1
        // 
        tabControl1.Controls.Add(tabPage1);
        tabControl1.Controls.Add(tabPage2);
        tabControl1.Location = new Point(18, 21);
        tabControl1.Name = "tabControl1";
        tabControl1.SelectedIndex = 0;
        tabControl1.Size = new Size(370, 313);
        tabControl1.TabIndex = 0;
        // 
        // tabPage1
        // 
        tabPage1.Controls.Add(btnAddBook);
        tabPage1.Controls.Add(numBookPages);
        tabPage1.Controls.Add(tbxBookAuthor);
        tabPage1.Controls.Add(tbxBookTitle);
        tabPage1.Controls.Add(label3);
        tabPage1.Controls.Add(label2);
        tabPage1.Controls.Add(label1);
        tabPage1.Location = new Point(4, 29);
        tabPage1.Name = "tabPage1";
        tabPage1.Padding = new Padding(3);
        tabPage1.Size = new Size(362, 280);
        tabPage1.TabIndex = 0;
        tabPage1.Text = "Lägg till Bok";
        tabPage1.UseVisualStyleBackColor = true;
        // 
        // btnAddBook
        // 
        btnAddBook.Location = new Point(17, 198);
        btnAddBook.Name = "btnAddBook";
        btnAddBook.Size = new Size(318, 47);
        btnAddBook.TabIndex = 6;
        btnAddBook.Text = "Lägg till Bok";
        btnAddBook.UseVisualStyleBackColor = true;
        btnAddBook.Click += btnAddBook_Click;
        // 
        // numBookPages
        // 
        numBookPages.Location = new Point(120, 114);
        numBookPages.Name = "numBookPages";
        numBookPages.Size = new Size(215, 27);
        numBookPages.TabIndex = 5;
        // 
        // tbxBookAuthor
        // 
        tbxBookAuthor.Location = new Point(120, 68);
        tbxBookAuthor.Name = "tbxBookAuthor";
        tbxBookAuthor.Size = new Size(215, 27);
        tbxBookAuthor.TabIndex = 4;
        // 
        // tbxBookTitle
        // 
        tbxBookTitle.Location = new Point(120, 22);
        tbxBookTitle.Name = "tbxBookTitle";
        tbxBookTitle.Size = new Size(215, 27);
        tbxBookTitle.TabIndex = 3;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(17, 116);
        label3.Name = "label3";
        label3.Size = new Size(83, 20);
        label3.TabIndex = 2;
        label3.Text = "Antal Sidor";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(17, 68);
        label2.Name = "label2";
        label2.Size = new Size(74, 20);
        label2.TabIndex = 1;
        label2.Text = "Författare";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(17, 22);
        label1.Name = "label1";
        label1.Size = new Size(38, 20);
        label1.TabIndex = 0;
        label1.Text = "Titel";
        // 
        // tabPage2
        // 
        tabPage2.Controls.Add(btnAddMovie);
        tabPage2.Controls.Add(numMovieLength);
        tabPage2.Controls.Add(tbxMovieDirector);
        tabPage2.Controls.Add(tbxMovieTitle);
        tabPage2.Controls.Add(label4);
        tabPage2.Controls.Add(label5);
        tabPage2.Controls.Add(label6);
        tabPage2.Location = new Point(4, 29);
        tabPage2.Name = "tabPage2";
        tabPage2.Padding = new Padding(3);
        tabPage2.Size = new Size(362, 280);
        tabPage2.TabIndex = 1;
        tabPage2.Text = "Lägg till FIlm";
        tabPage2.UseVisualStyleBackColor = true;
        // 
        // btnAddMovie
        // 
        btnAddMovie.Location = new Point(22, 205);
        btnAddMovie.Name = "btnAddMovie";
        btnAddMovie.Size = new Size(318, 47);
        btnAddMovie.TabIndex = 13;
        btnAddMovie.Text = "Lägg till Film";
        btnAddMovie.UseVisualStyleBackColor = true;
        btnAddMovie.Click += btnAddMovie_Click;
        // 
        // numMovieLength
        // 
        numMovieLength.Location = new Point(125, 121);
        numMovieLength.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
        numMovieLength.Name = "numMovieLength";
        numMovieLength.Size = new Size(215, 27);
        numMovieLength.TabIndex = 12;
        // 
        // tbxMovieDirector
        // 
        tbxMovieDirector.Location = new Point(125, 75);
        tbxMovieDirector.Name = "tbxMovieDirector";
        tbxMovieDirector.Size = new Size(215, 27);
        tbxMovieDirector.TabIndex = 11;
        // 
        // tbxMovieTitle
        // 
        tbxMovieTitle.Location = new Point(125, 29);
        tbxMovieTitle.Name = "tbxMovieTitle";
        tbxMovieTitle.Size = new Size(215, 27);
        tbxMovieTitle.TabIndex = 10;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(22, 123);
        label4.Name = "label4";
        label4.Size = new Size(76, 20);
        label4.TabIndex = 9;
        label4.Text = "Spellängd";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(22, 75);
        label5.Name = "label5";
        label5.Size = new Size(59, 20);
        label5.TabIndex = 8;
        label5.Text = "Regisör";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(22, 29);
        label6.Name = "label6";
        label6.Size = new Size(38, 20);
        label6.TabIndex = 7;
        label6.Text = "Titel";
        // 
        // listBox1
        // 
        listBox1.FormattingEnabled = true;
        listBox1.ItemHeight = 20;
        listBox1.Location = new Point(412, 50);
        listBox1.Name = "listBox1";
        listBox1.Size = new Size(363, 284);
        listBox1.TabIndex = 1;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(rbMovies);
        groupBox1.Controls.Add(rbBooks);
        groupBox1.Controls.Add(rbAll);
        groupBox1.Location = new Point(412, 351);
        groupBox1.Name = "groupBox1";
        groupBox1.RightToLeft = RightToLeft.No;
        groupBox1.Size = new Size(363, 87);
        groupBox1.TabIndex = 2;
        groupBox1.TabStop = false;
        groupBox1.Text = "Visa";
        // 
        // rbMovies
        // 
        rbMovies.AutoSize = true;
        rbMovies.Location = new Point(241, 31);
        rbMovies.Name = "rbMovies";
        rbMovies.Size = new Size(71, 24);
        rbMovies.TabIndex = 2;
        rbMovies.TabStop = true;
        rbMovies.Text = "Filmer";
        rbMovies.UseVisualStyleBackColor = true;
        rbMovies.CheckedChanged += RadioButtonChanged;
        // 
        // rbBooks
        // 
        rbBooks.AutoSize = true;
        rbBooks.Location = new Point(123, 31);
        rbBooks.Name = "rbBooks";
        rbBooks.Size = new Size(75, 24);
        rbBooks.TabIndex = 1;
        rbBooks.TabStop = true;
        rbBooks.Text = "Böcker";
        rbBooks.UseVisualStyleBackColor = true;
        rbBooks.CheckedChanged += RadioButtonChanged;
        // 
        // rbAll
        // 
        rbAll.AutoSize = true;
        rbAll.Location = new Point(22, 31);
        rbAll.Name = "rbAll";
        rbAll.Size = new Size(56, 24);
        rbAll.TabIndex = 0;
        rbAll.TabStop = true;
        rbAll.Text = "Alla";
        rbAll.UseVisualStyleBackColor = true;
        rbAll.CheckedChanged += RadioButtonChanged;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(groupBox1);
        Controls.Add(listBox1);
        Controls.Add(tabControl1);
        Name = "Form1";
        Text = "The Media Register!";
        tabControl1.ResumeLayout(false);
        tabPage1.ResumeLayout(false);
        tabPage1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numBookPages).EndInit();
        tabPage2.ResumeLayout(false);
        tabPage2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numMovieLength).EndInit();
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private TabControl tabControl1;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private ListBox listBox1;
    private GroupBox groupBox1;
    private RadioButton rbMovies;
    private RadioButton rbBooks;
    private RadioButton rbAll;
    private Button btnAddBook;
    private NumericUpDown numBookPages;
    private TextBox tbxBookAuthor;
    private TextBox tbxBookTitle;
    private Label label3;
    private Label label2;
    private Label label1;
    private Button btnAddMovie;
    private NumericUpDown numMovieLength;
    private TextBox tbxMovieDirector;
    private TextBox tbxMovieTitle;
    private Label label4;
    private Label label5;
    private Label label6;
}
