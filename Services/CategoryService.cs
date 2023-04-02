using AutoMapperMvc.Entites;
using AutoMapperMvc.interfaces;

namespace AutoMapperMvc.Service
{
    public class CategoryService : ICategoryService
    {
        List<Category> _categorys;

        public CategoryService()
        {
            _categorys = new List<Category>();
            _categorys.Add(new() { Id = 1, Name = "Category 1" });
            _categorys.Add(new() { Id = 2, Name = "Category 2" });
            _categorys.Add(new() { Id = 3, Name = "Category 3" });
            _categorys.Add(new() { Id = 4, Name = "Category 4" });
            _categorys.Add(new() { Id = 5, Name = "Category 5" });
            _categorys.Add(new() { Id = 6, Name = "Category 6" });
            _categorys.Add(new() { Id = 7, Name = "Category 7" });
            _categorys.Add(new() { Id = 8, Name = "Category 8" });
        }
        public List<Category> GetCategories()
        {
            return _categorys;
        }

        public Category GetCategory(int id)
        {
            return _categorys.Find(x => x.Id == id);
        }
    }
}