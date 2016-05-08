
using BuildSeller.Core.Model;
using BuildSeller.Core.Service;

namespace BuildSeller.Service
{

    public interface IBuildCategoriesService : ICrudService<ProductCategories>
    {

        bool IsUnique(ProductCategories cat);
    }
}
