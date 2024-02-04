namespace MMC.WEB.Entities;

public class Role
{
    public Guid ID { get;  set; }
    public string Name { get; set; }

    public ICollection<UserRole> UserRoles { get; set; }

}