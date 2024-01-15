namespace DilarOdev;

public partial class ayarlar : ContentPage
{
	public ayarlar()
	{
		InitializeComponent();
	}


    void Switch_Toggled(System.Object sender, Microsoft.Maui.Controls.ToggledEventArgs e)
    {
        if (e.Value)
        {
            Application.Current.UserAppTheme = AppTheme.Dark;
        }
        else
            Application.Current.UserAppTheme = AppTheme.Light;

    }
}