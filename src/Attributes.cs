namespace InitiativeTracker2;
public class Type
{
    public string type { get; set; }
    public List<string> tags { get; set; }
}

public class Hp
{
    public int average { get; set; }
    public string formula { get; set; }
}

public class Speed
{
    public int walk { get; set; }
    public int fly { get; set; }
    public int climb { get; set; }
}

public class Skill
{
    public string name { get; set; }
    public int mod { get; set; }
}

public class Trait
{
    public string name { get; set; }
    public List<string> entries { get; set; }
}

public class Action
{
    public string name { get; set; }
    public List<string> entries { get; set; }
}