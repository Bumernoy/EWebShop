
using System.Collections.Generic;

namespace BuildSeller.Core.Model
{

    public class ProductCategories : Entity
    {

        public string CatName { get; set; }

        public IList<Product> Realties { get; set; }
    }
}
