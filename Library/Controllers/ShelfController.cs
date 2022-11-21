using Library.Models;
using Library.Requests.ShelfRequests;
using Library.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShelfController : ControllerBase
    {
        private ShelfService _shelfService;
        public ShelfController()
        {
            _shelfService = new ShelfService();
        }

        [HttpGet]
        [Route("get/{shelfId}")]
        public Shelf? Get(int shelfId)
        {
            return _shelfService.Get(shelfId);
        }


        [HttpGet]
        [Route("get-all")]
        public List<Shelf> GetAll()
        {
            return _shelfService.GetAll();
        }

        [HttpPost]
        [Route("create")]
        public Shelf Create(CreateShelfRequest request)
        {
            return _shelfService.Create(request);
        }

        [HttpPost]
        [Route("rename")]
        public Shelf? Rename(RenameShelfRequest request)
        {
            return _shelfService.Rename(request);
        }
        [HttpPost]
        [Route("Delete")]
        public List<Shelf> Delete(DeleteShelfRequest request)
        {
            return _shelfService.Delete(request);
        }
    }
}
