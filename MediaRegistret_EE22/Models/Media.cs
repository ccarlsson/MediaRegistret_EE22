

namespace MediaRegistret_EE22.Models;

public class Media
{
    protected string _title;

    public Media(string title)
    { 
        _title = title; 
    }
    public string Title { get { return _title; } }
}
