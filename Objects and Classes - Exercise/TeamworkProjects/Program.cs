using System;
using System.Collections.Generic;
using System.Linq;

namespace TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();
            int teamsCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < teamsCount; i++)
            {
                string[] newTeam = Console.ReadLine().Split("-");

                if (teams.Any(team => team.Name == newTeam[1]))
                {
                    Console.WriteLine($"Team {newTeam[1]} was already created!");
                }
                else if (teams.Any(team => team.Creator == newTeam[0]))
                {
                    Console.WriteLine($"{newTeam[0]} cannot create another team!");
                }
                else
                {
                    var team = new Team();
                    team.Name = newTeam[1];
                    team.Creator = newTeam[0];
                    team.Members = new List<string>();
                    teams.Add(team);
                    Console.WriteLine($"Team {newTeam[1]} has been created by {newTeam[0]}!");
                }
            }

            var line = Console.ReadLine();
            while (line != "end of assignment")
            {
                var memberInfo = line.Split("->", StringSplitOptions.RemoveEmptyEntries);
                var memberName = memberInfo[0];
                var teamToJoin = memberInfo[1];

                if (teams.Any(team => team.Members.Contains(memberName)) || teams.Any(creator => creator.Creator == memberName))
                {
                    Console.WriteLine($"Member {memberName} cannot join team {teamToJoin}!");
                }
                else if (teams.All(team => team.Name != teamToJoin))
                {
                    Console.WriteLine($"Team {teamToJoin} does not exist!");
                }
                else
                {
                    var currentTeam = teams.Find(team => team.Name == teamToJoin);
                    currentTeam.Members.Add(memberName);
                }
                line = Console.ReadLine();
            }
            var completedTeams = teams.Where(x => x.Members.Count > 0).ToList();
            var disbandedTeams = teams.Where(x => x.Members.Count == 0).ToList();
            foreach (var item in completedTeams.OrderByDescending(x => x.Members.Count).ThenBy(y => y.Name))
            {
                Console.WriteLine($"{item.Name}");
                Console.WriteLine($"- {item.Creator}");
                foreach (var member in item.Members.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");
            if (disbandedTeams != null)
            {
                foreach (var disbandedTeam in disbandedTeams.OrderBy(x => x.Name))
                {
                    Console.WriteLine($"{disbandedTeam.Name}");
                }
            }
        }
    }
    class Team
    {
        public string Name { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }
    }
}
