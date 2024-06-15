namespace Test2Template.DataBase.Entities;

public class Entity1Entity2
{
    public string Attribute1 { get; set; }
    public string Attribute2 { get; set; }
    
    public int IdEntity1 { get; set; }
    public int IdEntity2 { get; set; }

    public virtual Entity1 Entity1 { get; }
    public virtual Entity2 Entity2 { get; }
}