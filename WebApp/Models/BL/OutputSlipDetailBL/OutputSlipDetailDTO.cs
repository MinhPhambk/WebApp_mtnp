
namespace WebApp.Models.BL.OutputSlipDetailBL
{
    public class OutputSlipDetailDTO
    {
        public OutputSlipDetailDTO() { }
        public OutputSlipDetailDTO(string id, string outputSlipId, string productId, int quantity, decimal price)
        {
            this.Id = id;
            this.OutputSlipId = outputSlipId;
            this.ProductId = productId;
            this.Quantity = quantity;
            this.Price = price;
        }
        public string Id { get; set; }
        public string OutputSlipId { get; set; }
        public string ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
