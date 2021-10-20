using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Guild
{
    public class Guild
    {
        private List<Player> roster;

        public Guild(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            roster = new List<Player>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count => roster.Count;

        public void AddPlayer(Player player)
        {
            if (!roster.Contains(player) && roster.Count < Capacity)
            {
                roster.Add(player);
            }
        }
        public bool RemovePlayer(string name)
        {
            Player currentPlayer = roster.FirstOrDefault(x => x.Name == name);
            if (currentPlayer != null)
            {
                roster.Remove(currentPlayer);
                return true;
            }
            return false;
        }
        public void PromotePlayer(string name)
        {
            if (roster.FirstOrDefault(x => x.Name == name).Rank != "Member")
            {
                roster.FirstOrDefault(x => x.Name == name).Rank = "Member";
            }
        }
        public void DemotePlayer(string name)
        {
            if (roster.FirstOrDefault(x => x.Name == name).Rank != "Trial")
            {
                roster.FirstOrDefault(x => x.Name == name).Rank = "Trial";
            }
        }
        public Player[] KickPlayersByClass(string @class)
        {
            Player[] tempRoster = roster.Where(x => x.Class == @class).ToArray();

            for (int i = 0; i < tempRoster.Length; i++)
            {
                roster.Remove(tempRoster[i]);
            }
            return tempRoster;
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Players in the guild: {this.Name}");
            foreach (var item in roster)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
