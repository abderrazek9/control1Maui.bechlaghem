namespace control1;

public partial class NewPage1 : ContentPage
{
    private const string mdpt = "DAM2024";
    public static int nf = 0;
    public NewPage1()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {

    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        string m = mdp.Text;

        if (m == mdpt)
        {
            nf++;
            this.Navigation.PushAsync(new bravo());

        }
        else
        {
            DisplayAlert("errur", "try again ...!", "ok");
        }
    }
}