namespace Observer_Problem;

internal class Stock
{
    private int currentStock;
    public int CurrentStock
    {
        get => currentStock;
        set
        {
            currentStock = value;
            UpdateStock();
        }
    }

    public void UpdateStock()
    {
        StockList stockList = new();
        stockList.Display(currentStock);

        StatusBar statusBar = new();
        statusBar.Display(currentStock);
    }

}
