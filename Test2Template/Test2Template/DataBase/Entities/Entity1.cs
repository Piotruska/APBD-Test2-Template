namespace Test2Template.DataBase.Entities;

public class Entity1
{
    public int IdEntity1 { get; set; }
    public string Attribute1 { get; set; }
    public string Attribute2 { get; set; }
    public string Attribute3 { get; set; }
    
    public int IdEntity1Entity2 { get; set; }
    public int IdEntity3 { get; set; }

    public virtual Entity3 entity3 { get; }
    public virtual ICollection<Entity1Entity2> Entity1Entity2S { get; }
}