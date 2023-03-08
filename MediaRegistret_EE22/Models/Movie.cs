

namespace MediaRegistret_EE22.Models;

public class Movie : Media
{
    private string _director;
    private int _length;

    public Movie(string title, string director, int length) : base(title)
    {
        _director = director;
        _length = length;
    }

    public string Director { get { return _director; } }
    public int Length { get { return _length; } }

    public override string ToString()
    {
        return $"{Title} ({Director}, {Length} minuter)";
    }
}
