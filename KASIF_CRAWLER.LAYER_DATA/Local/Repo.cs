using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KASIF_CRAWLER.LAYER_DATA.Local
{
    public class Repo<T> : IRepo<T>
    {
        public LiteDatabase db { get; set; }

        private LiteCollection<T> table { get; set; }
        public Repo(T model, LiteDatabase database)
        {
            this.db = database;
            table = db.GetCollection<T>(model.GetType().Name.ToString());

        }
        public void Add(T Model, out bool result)
        {
            try
            {
                table.Insert(Model);
                result = true;
            }
            catch (LiteDB.LiteException)
            {

                result = false;
            }

        }

        public void Delete(Guid id, out bool result)
        {
            table.Delete(id);
            result = true;
        }

        public List<T> GetList()
        {
            return table.FindAll().ToList();
        }

        public void Update(T Model, out bool result)
        {
            table.Update(Model);
            result = true;
        }

        public T Find(Guid id)
        {
            return table.FindById(id);
        }
    }
}
