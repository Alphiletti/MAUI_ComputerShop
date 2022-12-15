

namespace AlpEren_180201074;

public static class Calculate
{
    public static int TotalPrice { get; set; }
    public static void CalculateTotal()
	{
        if (PerformProduct.CPU == "Core i3") PerformProduct.CPUPrice = 1500;
        else if (PerformProduct.CPU == "Core i5") PerformProduct.CPUPrice = 1700;
        else if (PerformProduct.CPU == "Core i7") PerformProduct.CPUPrice = 2000;
        else if (PerformProduct.CPU == "Core i9") PerformProduct.CPUPrice = 2500;

        if (PerformProduct.Storage == "HDD" && PerformSize.storageSize == "500GB") PerformProduct.StoragePrice = 300;
        else if (PerformProduct.Storage == "HDD" && PerformSize.storageSize == "1TB") PerformProduct.StoragePrice = 600;
        else if (PerformProduct.Storage == "SSD" && PerformSize.storageSize == "500GB") PerformProduct.StoragePrice = 500;
        else if (PerformProduct.Storage == "SSD" && PerformSize.storageSize == "1TB") PerformProduct.StoragePrice = 1000;

        if (PerformSize.memorySize == 4) PerformSize.memoryPrice = 150;
        else if(PerformSize.memorySize == 8) PerformSize.memoryPrice = 300;
        else if (PerformSize.memorySize == 12) PerformSize.memoryPrice = 450;
        else if (PerformSize.memorySize == 16) PerformSize.memoryPrice = 600;

        if (PerformSize.monitorSize == 17) PerformSize.monitorPrice = 450;
        else if (PerformSize.monitorSize == 20) PerformSize.monitorPrice = 900;
        else if (PerformSize.monitorSize == 23) PerformSize.monitorPrice = 1350;

        TotalPrice = PerformProduct.CPUPrice + PerformProduct.StoragePrice + PerformSize.memoryPrice + PerformSize.monitorPrice;
    }
}

public partial class Payment : ContentPage
{
    public static string TotalString { get; set; }
    public Payment()
	{
		InitializeComponent();
        DateTime dateTime = DateTime.Now;
        PerformSize.SectionCalculate();
        totalLbl.Text = "Total: " + TotalString;
    }

    private void btnPay_Clicked(object sender, EventArgs e)
    {
        Calculate.CalculateTotal();
        TotalString = Calculate.TotalPrice.ToString("C");
        totalLbl.Text = "Total: " + TotalString;
    }
}