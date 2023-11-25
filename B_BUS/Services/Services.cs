using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Respositories;
using A_DAL.IRespositories;
using A_DAL.Models;

namespace B_BUS.Services
{
    public class Services
    {
        static IRespository respository;
        static Services()
        {
            respository = new Respository();
        }
        public static List<Cuahang> GetAll()
        {
            return respository.GetAll();
        }
        public static Cuahang GetByID(int id)
        {
            return respository.GetByID(id);
        }
        public static Cuahang Insert(Cuahang obj)
        {
            return respository.Insert(obj);
        }
        public void Update(Cuahang obj)
        {
            respository.Update(obj);
        }
        public static void Delete(Cuahang obj)
        {
            respository.Delete(obj);
        }
    }
}
