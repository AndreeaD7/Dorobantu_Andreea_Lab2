using Dorobantu_Andreea_Lab2.Models;
namespace Dorobantu_Andreea_Lab2.Models.ViewModels
{
    public class PublisherIndexData
    {
        public IEnumerable<Publisher> Publishers { get; set; }
        public IEnumerable<Book> Books { get; set; }
    }
}
