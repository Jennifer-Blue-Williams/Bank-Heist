using System;

namespace BankHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            HeistCrew HeistCrew1 = new HeistCrew("Coolest Heist Crew Ever");

            Console.WriteLine("Plan your heist!!");

            bool run = true;
            while (run)
            {
                Console.Write("What is your team members name? ");
                string teamMemberName = Console.ReadLine();

                if (teamMemberName == "")
                {
                    run = false;
                }
                else
                {
                    Console.Write("What is your team members skill level? (1-50) ");
                    var teamMemberSkill = int.Parse(Console.ReadLine());

                    Console.Write("What is your team members courage level? (0.0-2.0) ");
                    var teamMemberCourage = double.Parse(Console.ReadLine());

                    TeamMember teamMemberNew = new TeamMember(teamMemberName, teamMemberSkill, teamMemberCourage);

                    HeistCrew1.addTeamMember(teamMemberNew);

                    HeistCrew1.displayHeistCrew();
                    Console.WriteLine($"Total number of team members: {HeistCrew1.HeistTeam.Count}");
                }

            }
        }
    }
}