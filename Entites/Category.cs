namespace AutoMapperMvc.Entites
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
    }
}