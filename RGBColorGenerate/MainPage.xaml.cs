namespace RGBColorGenerate;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	public void GenerateColor_Clicked(object sender, EventArgs e)
	{

	}

    private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
		double colorRed = Slider_Red.Value;
        double colorBlue = Slider_Blue.Value;
        double colorGreen = Slider_Green.Value;

		Color color = Color.FromRgb(colorRed, colorGreen, colorBlue);
        SetColor(color);
    }

    private void SetColor(Color color)
    {
        Grid_Color.Background = color;
        BtnGenerateColor.BackgroundColor = color;
        ResultColor.Text = color.ToHex();
    }

}

