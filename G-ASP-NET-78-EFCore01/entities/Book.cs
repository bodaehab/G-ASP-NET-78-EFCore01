using System;
using System.Collections.Generic;
using System.Text;

namespace G_ASP_NET_78_EFCore01.entities;

public  class Book
{
    public int Id { get; set; }

    public string Title { get; set; }

    public string ISBN { get; set; }

    public decimal Price { get; set; }

    public int NumberOfPages { get; set; }

    public int PublishedYear { get; set; }

    public bool IsInStock { get; set; }

    public int CategoryId { get; set; }

  
    public Category Category { get; set; }

    public ICollection<Author> Authors { get; set; }
}
