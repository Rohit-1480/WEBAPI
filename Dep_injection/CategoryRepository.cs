
namespace Dep_injection
{
    public class CategoryRepository: ICategoryRepository
    {
       public  List<Category> GetCategories()
        {
            List<Category> categories = new List<Category>();
            Category ctry=new Category()
            { Catid=123,name="Shoes"};
            categories.Add(ctry);
            return categories;
        }
    }
}
