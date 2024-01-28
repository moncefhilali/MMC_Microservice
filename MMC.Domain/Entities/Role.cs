namespace MMC.Domain.Entities;

public class Role
{
    public Guid ID { get; private set; }
    public string Name { get; private set; }

    public ICollection<UserRole> UserRoles { get; private set; }




    public Role(string name)
    {
        ID = Guid.NewGuid();
        Name = name;
    }
}