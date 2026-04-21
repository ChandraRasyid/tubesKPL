using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Address
{
    public string streetAddress { get; set; }
    public string city { get; set; }
    public string state { get; set; }
}
public class Course
{
    public string code { get; set; }
    public string name { get; set; }
}
public class DataMahasiswa103082400008
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string gender { get; set; }
    public int age { get; set; }
    public Address address { get; set; }
    public List<Course> courses { get; set; }

    public void ReadJSON()
    {
        string filepath = "jurnal7_1_103082400008.json";
        try
        {
            string jsonString = File.ReadAllText(filepath);
            DataMahasiswa103082400008 mahasiswa = JsonSerializer.Deserialize<DataMahasiswa103082400008>(jsonString);
            Console.WriteLine(" HASIL JSON 1 ");
            Console.WriteLine($"Nama: {mahasiswa.firstName} {mahasiswa.lastName}");
            Console.WriteLine($"Gender: {mahasiswa.gender}, Umur: {mahasiswa.age}");
            Console.WriteLine($"Alamat: {mahasiswa.address.streetAddress}, {mahasiswa.address.city}, {mahasiswa.address.state}");
            foreach (var course in mahasiswa.courses)
            {
                Console.WriteLine($"- {course.code}: {course.name}");
            }
            Console.WriteLine();
        }
        catch (Exception e) { Console.WriteLine("Error JSON 1: " + e.Message); }
    }
}

public class Member
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string gender { get; set; }
    public int age { get; set; }
    public string nim { get; set; }
}
public class TeamMembers103082400008
{
    public List<Member> members { get; set; }
    public void ReadJSON()
    {
        string filepath = "jurnal7_2_103082400008.json";
        try
        {
            string jsonString = File.ReadAllText(filepath);
            TeamMembers103082400008 team = JsonSerializer.Deserialize<TeamMembers103082400008>(jsonString);
            Console.WriteLine(" HASIL JSON 2 ");
            Console.WriteLine("Team member list:");
            foreach (var member in team.members)
            {
                Console.WriteLine($"{member.nim} {member.firstName} {member.lastName} ({member.age} {member.gender})");
            }
            Console.WriteLine();
        }
        catch (Exception e) { Console.WriteLine("Error JSON 2: " + e.Message); }
    }
}

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
public class GlossList { public GlossEntry GlossEntry { get; set; } }
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
public class GlossaryRoot { public Glossary glossary { get; set; } }

public class GlossaryItem103082400008
{
    public void ReadJSON()
    {
        string filepath = "jurnal7_3_103082400008.json";
        try
        {
            string jsonString = File.ReadAllText(filepath);
            GlossaryRoot root = JsonSerializer.Deserialize<GlossaryRoot>(jsonString);
            var entry = root.glossary.GlossDiv.GlossList.GlossEntry;
            Console.WriteLine("=== HASIL JSON 3 ===");
            Console.WriteLine($"Term: {entry.GlossTerm}");
            Console.WriteLine($"Acronym: {entry.Acronym}");
            Console.WriteLine($"Definition: {entry.GlossDef.para}");
            Console.WriteLine();
        }
        catch (Exception e) { Console.WriteLine("Error JSON 3: " + e.Message); }
    }
}


public class Program
{
    public static void Main(string[] args)
    {
        new DataMahasiswa103082400008().ReadJSON();
        new TeamMembers103082400008().ReadJSON();
        new GlossaryItem103082400008().ReadJSON();
    }
}