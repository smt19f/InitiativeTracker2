namespace InitiativeTracker2;

// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
public class Monster
{
    public string name { get; set; }
    public string source { get; set; }
    public int page { get; set; }
    public List<string> otherSources { get; set; }
    public string size { get; set; }
    public Type type { get; set; }
    public List<string> alignment { get; set; }
    public int ac { get; set; }
    public Hp hp { get; set; }
    public Speed speed { get; set; }
    public int str { get; set; }
    public int dex { get; set; }
    public int con { get; set; }
    public int intell { get; set; }
    public int wis { get; set; }
    public int cha { get; set; }
    public List<Skill> skills { get; set; }
    public int passive { get; set; }
    public List<string> languages { get; set; }
    public string cr { get; set; }
    public List<Trait> traits { get; set; }
    public List<Action> actions { get; set; }
    public List<string> environments { get; set; }
    public bool hasToken { get; set; }
    public List<string> languageTags { get; set; }
    public List<string> damageTags { get; set; }
    public List<string> miscTags { get; set; }
    public bool hasFluff { get; set; }
    public bool hasFluffImages { get; set; }
}

public class Root
{
    public List<Monster> monster { get; set; }
}