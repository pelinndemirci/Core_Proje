﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EfSkillDal:GenericRepository<Skill>,ISkillDal
    {
    }
}
