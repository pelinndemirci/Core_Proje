using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ISkillDal:IGenericDal<Skill> //Generic yapıda oluşturulan interface skill ile kullanma
    {
        void Insert(Skill p);
        void Delete(Skill p);
        void Update(Skill p);
        List<Skill> GetList();
    }
}
