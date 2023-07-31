namespace PropertyStore.Models
{
    public class Item : EntityBase
    {
        public int Id { get; set; }
        public string ItemCode { get; set; }
        public string Description1 { get; set; }
        public string? Description2 { get; set; }
        public string Inventory { get; set; }
        public string? GLCOSG { get; set; }
        public string ItemType { get; set; }
        public string ItemClass { get; set; }
        public string ItemGroup { get; set; }
        public string BaseUnit { get; set; }
        public string CostUnit { get; set; }
    }
}
