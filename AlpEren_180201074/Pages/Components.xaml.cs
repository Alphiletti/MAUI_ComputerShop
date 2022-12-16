using Windows.ApplicationModel.Store;

namespace AlpEren_180201074;

public static class PerformProduct
{
	public static string CPU { get; set; }
	public static string Storage { get; set; }
	public static int CPUPrice { get; set; }
	public static int StoragePrice { get; set; }
    public static string MonitorBrand { get; set; }
}

public partial class Components : ContentPage
{
	public Components()
	{
		InitializeComponent();
        Application.Current.UserAppTheme = AppTheme.Light;
	}

    private void RadioCPU_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
		RadioButton rb = (RadioButton)sender;
		PerformProduct.CPU = rb.Content.ToString();
    }

    private void RadioStorage_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        RadioButton rb = (RadioButton)sender;
		PerformProduct.Storage = rb.Content.ToString();
    }

    private void RadioBrand_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        RadioButton rb = (RadioButton)sender;
        PerformProduct.MonitorBrand = rb.Content.ToString();
    }
}