using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

public class TeamMembers2311104073
{
    public static void ReadJSON()
    {
        string fileName = "jurnal7_2_2311104073.json";

        if (!File.Exists(fileName))
        {
            Console.WriteLine("File tidak ditemukan.");
            return;
        }

        string jsonString = File.ReadAllText(fileName);
        var data = JsonSerializer.Deserialize<List<TeamMember>>(jsonString);

        Console.WriteLine("Team member list:");
        foreach (var member in data)
        {
            Console.WriteLine($"{member.NIM} {member.FirstName} {member.LastName} ({member.Age} {member.Gender})");
        }
    }
}

public class TeamMember
{
    public string NIM { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
}  
