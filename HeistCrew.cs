using System;
using System.Collections.Generic;

namespace BankHeist
{
    public class HeistCrew
    {
        public string Name { get; }
        public List<TeamMember> HeistTeam = new List<TeamMember>();

        public HeistCrew(string name)
        {
            Name = name;
        }
        public void addTeamMember(TeamMember teamMember)
        {
            HeistTeam.Add(teamMember);
        }
        public void displayHeistCrew()
        {
            foreach (TeamMember person in HeistTeam)
            {
                Console.WriteLine($"Team member's name: {person.Name} \n skill level: {person.SkillLevel} \n courage level: {person.Courage}");

            }
        }
    }
}