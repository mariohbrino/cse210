using System;

class Order
{
    private Customer _customer;
    private List<Product> _products = [];

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public Customer GetCustomer()
    {
        return _customer;
    }

    public void SetProduct(Product product)
    {
        _products.Add(product);
    }

    public List<Product> GetProducts()
    {
        return _products;
    }

    public string GetPackingLabel()
    {
        string label = "Products List\n";

        foreach (Product product in _products)
        {
            label += $"  - [ID] {product.GetProductId()}: [NAME] {product.GetName()}\n";
        }

        return label;
    }

    public string GetShippingLabel()
    {
        Address customerAddress = _customer.GetAddress();
        string label = "Shipping To\n";
        label += $"  - Recipient's Name:\n    {_customer.GetName()}\n";
        label += $"  - Recipient's Address:\n    {customerAddress.GetFullAddress()}";
        return label;
    }

    public double GetTotalAmount()
    {
        return _products.Aggregate(0.0, (accumulator, current) => accumulator + current.GetPrice());
    }

    public string GetOrderCosts()
    {
        string label = "\nOrder Costs\n";
        double shippingAmount = 5.00;
        if (!_customer.IsCustomerLocatedOnUSA())
        {
            shippingAmount += 30.00;
        }

        double subtotalAmount = GetTotalAmount();
        double totalAmount = shippingAmount + subtotalAmount;

        label += $"  - Shipping amount: ${shippingAmount.ToString("F2")}\n";
        label += $"  - Order subtotal amount: ${subtotalAmount.ToString("F2")}\n";
        label += $"  - Order total amount: ${totalAmount.ToString("F2")}";

        return label;
    }
}
