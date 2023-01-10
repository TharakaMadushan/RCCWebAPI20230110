using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEBAPI.MODELS;

namespace WEBAPI.SERVICES.Interfaces
{
    public interface ISkillTypeServices
    {
        public SkillType SaveSkillType(SkillType skillType);
        public SkillType getSkillType(string Code);
        public void UpdateSkillType(SkillType skillType);

    }
}
