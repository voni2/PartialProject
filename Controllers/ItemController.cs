using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PartialProject.Models;

namespace PartialProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
            private static readonly List<Item> Items = new List<Item>
        {
            new Item { Id = 1, Name = "Item 1", Code = "CODE001", Brand = "Brand 1", UnitPrice = 10.99m },
            new Item { Id = 2, Name = "Item 2", Code = "CODE002", Brand = "Brand 2", UnitPrice = 20.99m }
        };

            [HttpGet]
            public IEnumerable<Item> Get()
            {
                return Items;
            }

            [HttpGet("{id}")]
            public Item Get(int id)
            {
                return Items.Find(i => i.Id == id);
            }
        }
    
}
