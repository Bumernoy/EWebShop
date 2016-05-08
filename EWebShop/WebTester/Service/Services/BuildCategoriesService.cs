
using System.Linq;
using BuildSeller.Core.Model;
using BuildSeller.Core.Repository;

namespace BuildSeller.Service
{

    public class BuildCategoriesService : CrudService<ProductCategories>, IBuildCategoriesService
    {

        public BuildCategoriesService(IRepo<ProductCategories> repo)
            : base(repo)
        {
        }

        public bool IsUnique(ProductCategories cat)
        {
            return !this.Repo.Where(o => o.CatName == cat.CatName).Any();
        }
    }
}
