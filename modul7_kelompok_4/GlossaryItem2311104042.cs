using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class GlossaryItem2311104042
{
    public class GlossDef
    {
        public string para { get; set; }
        public List<string> GlossSeeAlso { get; set; }
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

    public class GlossList
    {
        public GlossEntry GlossEntry { get; set; }
    }

    public class GlossDiv
    {
        public string title { get; set; }
        public GlossList GlossList { get; set; }
    }

    public class Glossary
    {
        public string title { get; set; }
        public GlossDiv GlossDiv { get; set; }
    }

    public class Root
    {
        public Glossary glossary { get; set; }
    }

    public static void ReadJSON()
    {
        try
        {
            string filePath = "jurnal7_3_2311104042.json";
            string jsonString = File.ReadAllText(filePath);
            Root data = JsonSerializer.Deserialize<Root>(jsonString);

            var entry = data.glossary.GlossDiv.GlossList.GlossEntry;

            Console.WriteLine("=== GLOSS ENTRY ===");
            Console.WriteLine($"ID        : {entry.ID}");
            Console.WriteLine($"SortAs    : {entry.SortAs}");
            Console.WriteLine($"Term      : {entry.GlossTerm}");
            Console.WriteLine($"Acronym   : {entry.Acronym}");
            Console.WriteLine($"Abbrev    : {entry.Abbrev}");
            Console.WriteLine($"Def       : {entry.GlossDef.para}");
            Console.WriteLine("See Also  : " + string.Join(", ", entry.GlossDef.GlossSeeAlso));
            Console.WriteLine($"See       : {entry.GlossSee}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Gagal membaca file JSON: " + ex.Message);
        }

        Console.ReadLine();     
    }
}
