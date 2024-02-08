using System.Diagnostics;

namespace OnePage;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }
    private DateOnly date = DateOnly.MinValue;

    public DateOnly Date
    {
        get => date; 
        set
        {
            date = value;
            Debug.WriteLine("Date set to "+date.ToString());
        }
    }
}
