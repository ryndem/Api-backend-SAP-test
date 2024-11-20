namespace Core.VentaDigitalPQF.Dto.General
{
    public class Item
    {
        public int? Number { get; set; }
        public string? CAS { get; set; }
        public string? Catalog { get; set; }
        public string? Type { get; set; }
        public string? Description { get; set; }
        public string? UnitMeasure { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal WebPrice { get; set; }
        public int TEE { get; set; }
        public bool AppliesExpressFreight { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
