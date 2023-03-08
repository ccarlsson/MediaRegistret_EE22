using MediaRegistret_EE22.Models;

namespace MediaRegistret_EE22;

public partial class Form1 : Form
{
    List<Media> _medias = new List<Media>();

    public Form1()
    {
        InitializeComponent();
        numBookPages.Maximum = 100000;
        numMovieLength.Maximum = 1000;
        rbAll.Checked = true;
    }

    private void btnAddBook_Click(object sender, EventArgs e)
    {
        string title = tbxBookTitle.Text;
        string author = tbxBookAuthor.Text;
        int pages = (int)numBookPages.Value;
        Book book = new Book(title, author, pages);
        _medias.Add(book);

        if (rbMovies.Checked)
        {
            rbAll.Checked = true;
        }

        UpdateListBox();

        tbxBookAuthor.Text = "";
        tbxBookTitle.Text = "";
        numBookPages.Value = 0;
    }
    private void btnAddMovie_Click(object sender, EventArgs e)
    {
        string title = tbxMovieTitle.Text;
        string director = tbxMovieDirector.Text;
        int length = (int)numMovieLength.Value;
        Movie movie = new Movie(title, director, length);
        _medias.Add(movie);

        if (rbBooks.Checked)
        {
            rbAll.Checked = true;
        }

        UpdateListBox();

        tbxMovieDirector.Text = "";
        tbxMovieTitle.Text = "";
        numMovieLength.Value = 0;
    }

    private void UpdateListBox()
    {
        listBox1.Items.Clear();
        foreach (Media media in _medias)
        {
            if (rbBooks.Checked && media is Book)
            {
                listBox1.Items.Add(media);
            }
            else if (rbMovies.Checked && media is Movie)
            {
                listBox1.Items.Add(media);
            }
            else if (rbAll.Checked)
            {
                listBox1.Items.Add(media);
            }
        }

    }

    private void RadioButtonChanged(object sender, EventArgs e)
    {
        UpdateListBox();
    }
}
