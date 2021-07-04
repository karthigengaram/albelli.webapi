namespace albelli.datacontract
{
    public interface IOrderDetails
    {

        /// <summary>
        /// Gets or sets the product type.
        /// </summary>
        ProductNames ProductsType { get; set; }

        /// <summary>
        /// Gets or sets the Quantity.
        /// </summary>
        short Quantity { get; set; }
    }
}