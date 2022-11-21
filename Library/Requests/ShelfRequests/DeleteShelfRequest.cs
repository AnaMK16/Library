using Library.Models;

namespace Library.Requests.ShelfRequests
{
    public class DeleteShelfRequest
    {
        public int ShelfId { get; set; }
        public Shelf Shelf { get; set; }
    }
}
