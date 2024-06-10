namespace Test2Template.DataBase.Entities;

public class Entity2
{
    public int IdEntity2 { get; set; }
    public string Attribute1 { get; set; }
    public string Attribute2 { get; set; }
    public string Attribute3 { get; set; }

    public virtual ICollection<Entity1Entity2> Entity1Entity2S { get; }
}