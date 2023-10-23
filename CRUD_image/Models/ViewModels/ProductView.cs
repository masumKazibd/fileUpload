namespace CRUD_image.Models.ViewModels
{
    public class ProductView
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string Unit { get; set; } = default!;
        public string Price { get; set; } = default!;
        public IFormFile Image { get; set; } = default!;
    }
}
