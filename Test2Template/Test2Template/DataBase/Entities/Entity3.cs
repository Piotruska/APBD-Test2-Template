namespace Test2Template.DataBase.Entities;

public class Entity3
{
    public int IdEntity3 { get; set; }
    public string Attribute1 { get; set; }
    public string Attribute2 { get; set; }
    public string Attribute3 { get; set; }
    
    public virtual ICollection<Entity1> Entity1S { get; }
    public virtual Entity1 Entity1 { get; }
}