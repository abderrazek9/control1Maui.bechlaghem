namespace control1;

public partial class bravo : ContentPage
{
	public bravo()
	{
		InitializeComponent();
        l.Text = $"nombre de MDP correct est {NewPage1.nf} fois.";

    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        this.Navigation.PopAsync(true);

    }
}