using AutoMapperMvc.Entites;

namespace AutoMapperMvc.interfaces
{
    public interface ICategoryService
    {
        List<Category> GetCategories();
        Category GetCategory(int id);
    }
}