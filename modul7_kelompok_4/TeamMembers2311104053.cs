using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

public class TeamMembers2311104053
{
    public List<Member> members { get; set; }

    public class Member
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public string nim { get; set; }
    }

    public static void ReadJSON()
    {
        string json = File.ReadAllText("jurnal7_2_2311104053.json");
        var team = JsonSerializer.Deserialize<TeamMembers2311104053>(json);
        Console.WriteLine("Team member list:");
        foreach (var member in team.members)
        {
            Console.WriteLine($"{member.nim} {member.firstName} {member.lastName} ({member.age} {member.gender})");
        }
    }
}