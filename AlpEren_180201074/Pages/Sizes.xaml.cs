namespace AlpEren_180201074;

public static class PerformSize
{
    public static int memorySize { get; set; } = 4;
    public static int memoryPrice { get; set; }
    public static string storageSize { get; set; } = "500GB";
    public static int monitorSize { get; set; } = 17; 
    public static int monitorPrice { get; set; }

    public static void SectionCalculate()
    {
        Calculate.CalculateTotal();
        Payment.TotalString = Calculate.TotalPrice.ToString("C");
    }
}

public partial class Sizes : ContentPage
{
	public Sizes()
	{
		InitializeComponent();
        PerformSize.SectionCalculate();
        totalLbl.Text = "Total: " + Payment.TotalString;
    }

    private void btnMinusMemory_Clicked(object sender, EventArgs e)
    {
        PerformSize.memorySize -= 4;
        if (PerformSize.memorySize < 4) PerformSize.memorySize = 4;
        memorySizeLbl.Text = PerformSize.memorySize.ToString();
        PerformSize.SectionCalculate();
        totalLbl.Text = "Total: " + Payment.TotalString;
    }

    private void btnPlusMemory_Clicked(object sender, EventArgs e)
    {
        PerformSize.memorySize += 4;
        if (PerformSize.memorySize > 16) PerformSize.memorySize = 16;
        memorySizeLbl.Text = PerformSize.memorySize.ToString();
        PerformSize.SectionCalculate();
        totalLbl.Text = "Total: " + Payment.TotalString;
    }

    private void btnMinusStorage_Clicked(object sender, EventArgs e)
    {
        PerformSize.storageSize = "500GB";
        storageSizeLbl.Text = PerformSize.storageSize.ToString();
        PerformSize.SectionCalculate();
        totalLbl.Text = "Total: " + Payment.TotalString;
    }

    private void btnPlusStorage_Clicked(object sender, EventArgs e)
    {
        PerformSize.storageSize = "1TB";
        storageSizeLbl.Text = PerformSize.storageSize.ToString();
        PerformSize.SectionCalculate();
        totalLbl.Text = "Total: " + Payment.TotalString;
    }

    private void btnMinusMonitor_Clicked(object sender, EventArgs e)
    {
        PerformSize.monitorSize -= 3;
        if (PerformSize.monitorSize < 17) PerformSize.monitorSize = 17;
        monitorSizeLbl.Text = PerformSize.monitorSize.ToString();
        PerformSize.SectionCalculate();
        totalLbl.Text = "Total: " + Payment.TotalString;
    }

    private void btnPlusMonitor_Clicked(object sender, EventArgs e)
    {
        PerformSize.monitorSize += 3;
        if (PerformSize.monitorSize > 23) PerformSize.monitorSize = 23;
        monitorSizeLbl.Text = PerformSize.monitorSize.ToString();
        PerformSize.SectionCalculate();
        totalLbl.Text = "Total: " + Payment.TotalString;
    }

    
}