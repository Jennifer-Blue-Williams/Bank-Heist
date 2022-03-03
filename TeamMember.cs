using System;
using System.Collections.Generic;

namespace BankHeist
{
    public class TeamMember
    {
        public string Name { get; set; }

        public int SkillLevel { get; set; }

        public double Courage { get; set; }

        public TeamMember(string name, int skillLevel, double courage)
        {
            Name = name;
            SkillLevel = skillLevel;
            Courage = courage;

        }
    }
}