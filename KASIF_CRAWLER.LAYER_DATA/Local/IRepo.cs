using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KASIF_CRAWLER.LAYER_DATA.Local
{
    public interface IRepo<T>
    {
        void Add(T Model, out bool result);
        void Delete(Guid id, out bool result);
        List<T> GetList();
        void Update(T Model, out bool result);
        T Find(Guid id);
    }
}
