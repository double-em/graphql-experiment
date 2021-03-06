using GraphqlExperiment.Models;

namespace GraphqlExperiment.Queries;

public class Query
{
   public Book GetBook() =>
       new Book
       {
           Title = "C# in depth.",
           Author = new Author
           {
               Name = "Jon Skeet"
           }
       };
}
