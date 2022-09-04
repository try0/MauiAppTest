namespace MauiAppTest;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();

        RenderImageAsync();

    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;

        if (count == 1)
            CounterBtn.Text = $"Clicked {count} time";
        else
            CounterBtn.Text = $"Clicked {count} times";

        SemanticScreenReader.Announce(CounterBtn.Text);

        RenderImageAsync();

    }

    private async void RenderImageAsync()
    {
        // Resources/Raw/test_dotnet_bot.png
        Stream stream = await FileSystem.Current.OpenAppPackageFileAsync("test_dotnet_bot.png");

        img.Source = ImageSource.FromStream(() => stream);
    }
}

