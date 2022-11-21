using Library.Models;
using Library.Requests.BookRequests;
using Library.Requests.ShelfRequests;
using Library.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private ShelfService _shelfService;
        public BookController()
        {
            _shelfService = new ShelfService();
        }
        [HttpPost]
        [Route("addToShelf")]
        public Book AddToShelf(AddToShelfRequest request)
        {
            return _shelfService.AddToShelf(request);
        }
        [HttpPost]
        [Route("Remove Book")]
        public void Remove(RemoveBookRequest request)
        {
            _shelfService.Remove(request);
        }
        [HttpPost]
        [Route("Move Book")]
        public void MoveToShelf(MoveToShelfRequest request)
        {
             _shelfService.MoveToShelf(request);
        }
    }
}
