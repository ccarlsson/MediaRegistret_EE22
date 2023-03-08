

namespace MediaRegistret_EE22.Models;

public class Book : Media
{
    private string _author;
    private int _nrOfPages;

    public Book(string title, string author, int nrOfPages) : base(title) 
    {
        _author = author;
        _nrOfPages = nrOfPages;

    }

    public string Author  {  get { return _author; } }
    public int NrOfPages { get { return _nrOfPages; } }

    public override string ToString()
    {
        return $"{Title} ({Author}, {NrOfPages} sidor)";
    }
}
