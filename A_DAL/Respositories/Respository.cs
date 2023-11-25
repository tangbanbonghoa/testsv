using A_DAL.Models;
using A_DAL.IRespositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Respositories
{
    public class Respository : IRespository
    {
        public void Delete(Cuahang cuahang)
        {
            using (Sof205FinalTestContext db = new Sof205FinalTestContext())
            {
                db.Cuahangs.Attach(cuahang);
                db.Cuahangs.Remove(cuahang);
                db.SaveChanges();
            }
        }
        public List<Cuahang> GetAll()
        {
            using (Sof205FinalTestContext db = new Sof205FinalTestContext())
            {
                return db.Cuahangs.ToList();
            }
        }
        public Cuahang GetByID(int id)
        {
            throw new NotImplementedException();
        }
        public Cuahang Insert(Cuahang cuahang)
        {
            using (Sof205FinalTestContext db = new Sof205FinalTestContext())
            {
                db.Cuahangs.Add(cuahang);
                db.SaveChanges();
                return cuahang;
            }
        }
        public void Update(Cuahang cuahang)
        {
            throw new NotImplementedException();
        }
    }
}
