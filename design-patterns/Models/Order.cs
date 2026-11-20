class Order
{
    private static int count=0;
    public int Id;
    public string CustomerName;
    public decimal TotalAmount;
    public bool IsCompleted=false;

    public Order(string customerName,decimal totalAmount)
    {
        Id=count+1;
        CustomerName=customerName;
        TotalAmount=totalAmount;
        count++;
    }
}