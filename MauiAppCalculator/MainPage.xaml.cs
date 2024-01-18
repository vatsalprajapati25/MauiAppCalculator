namespace MauiAppCalculator;

public partial class MainPage : ContentPage
{
	const double underWeight = 18.5;
	const double normalWeight = 24.9;
	const double overWeight = 29.9;

    public MainPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		var weight = double.Parse(Weight.Text == null ? "0" : Weight.Text);
		var height = double.Parse(Height.Text == null ? "0" : Height.Text) / 100;
		if( weight < 10)
		{
            DisplayAlert("Error", "Weight must be greater than 10", "Okay");
        }
		else if (height < 0 || height > 3)
        {
            DisplayAlert("Error", "Height must be greater than 0 & less than 3", "Okay");
        }
		else
		{
            var bmi = weight / (height * weight);
            BMI.Text = bmi.ToString("F2");
            string bmiResult = GetResponse(bmi);
            DisplayAlert("BMI Status", bmiResult, "Okay");
        }
    }

	private string GetResponse(double bmi)
	{
		if(bmi < underWeight)
		{
			return "You have low weight";
		}
		else if (bmi == normalWeight)
		{
            return "You have low weight";
        }
		else if( bmi > overWeight)
		{
            return "You have low weight";
        }
		else
		{
			return "You have obbesity take care your self";
		}
	}
}

