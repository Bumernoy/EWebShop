
using BuildSeller.Core.Model;
using BuildSeller.Core.Repository;

namespace BuildSeller.Service
{

    public class RealtyService : CrudService<Product>, IRealtyService
    {

        public RealtyService(IRepo<Product> repo)
            : base(repo)
        {
        }
    }
}
