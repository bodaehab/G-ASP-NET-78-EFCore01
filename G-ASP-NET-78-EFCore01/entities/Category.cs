namespace G_ASP_NET_78_EFCore01.entities;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public bool IsActive { get; set; }
   
    public ICollection<Book> Books { get; set; }
}
