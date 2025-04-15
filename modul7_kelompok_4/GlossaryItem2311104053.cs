using System;
using System.IO;
using System.Text.Json;

public class GlossaryItem2311104053
{
    public Glossary glossary { get; set; }

    public class Glossary
    {
        public string title { get; set; }
        public GlossDiv GlossDiv { get; set; }
    }

    public class GlossDiv
    {
        public string title { get; set; }
        public GlossList GlossList { get; set; }
    }

    public class GlossList
    {
        public GlossEntry GlossEntry { get; set; }
    }

    public class GlossEntry
    {
        public string ID { get; set; }
        public string SortAs { get; set; }
        public string GlossTerm { get; set; }
        public string Acronym { get; set; }
        public string Abbrev { get; set; }
        public GlossDef GlossDef { get; set; }
        public string GlossSee { get; set; }
    }

    public class GlossDef
    {
        public string para { get; set; }
        public string[] GlossSeeAlso { get; set; }
    }

    public static void ReadJSON()
    {
        string json = File.ReadAllText("jurnal7_3_2311104053.json");
        var data = JsonSerializer.Deserialize<GlossaryItem2311104053>(json);
        var entry = data.glossary.GlossDiv.GlossList.GlossEntry;

        Console.WriteLine("Glossary Entry:");
        Console.WriteLine($"ID: {entry.ID}");
        Console.WriteLine($"Gloss Term: {entry.GlossTerm}");
        Console.WriteLine($"Acronym: {entry.Acronym}");
        Console.WriteLine($"Abbrev: {entry.Abbrev}");
        Console.WriteLine($"Definition: {entry.GlossDef.para}");
        Console.WriteLine("See Also: " + string.Join(", ", entry.GlossDef.GlossSeeAlso));
        Console.WriteLine($"Gloss See: {entry.GlossSee}");
    }
}
