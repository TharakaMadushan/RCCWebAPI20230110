using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEBAPI.MODELS;
using WEBAPI.PERSISTANCE;
using WEBAPI.SERVICES.Interfaces;

namespace WEBAPI.SERVICES
{
    public class SkillTypeServices : ISkillTypeServices
    {
        private readonly DataAccess _dataAccess;

        public SkillTypeServices(DataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }


        public SkillType getSkillType(string Code)
        {
            var st = _dataAccess.tblRefSkillType.AsNoTracking().FirstOrDefault(t => t.Code == Code);
            return st;
        }

        public SkillType SaveSkillType(SkillType skillType)
        {
            _dataAccess.tblRefSkillType.Add(skillType);
            _dataAccess.SaveChanges();
            return skillType;
        }

        public void UpdateSkillType(SkillType skillType)
        {
            _dataAccess.tblRefSkillType.Update(skillType);
            _dataAccess.SaveChanges();
        }

    }
}
