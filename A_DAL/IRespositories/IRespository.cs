using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRespositories
{
    public interface IRespository
    {
        List<Cuahang> GetAll();
        Cuahang GetByID(int id);
        Cuahang Insert(Cuahang cuahang);
        void Delete(Cuahang cuahang);
        void Update(Cuahang cuahang);

    }
}
