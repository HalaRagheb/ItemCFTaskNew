using Microsoft.AspNetCore.Mvc;
using Items.DTOs;
using Items.Entities;
using Items.Interfaces;
using Microsoft.EntityFrameworkCore;
using Items.Interfaces;
using Items.Services;
using Microsoft.EntityFrameworkCore.Internal;
namespace Items.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemController :ControllerBase
    {

        private readonly IItem _itemService;

        public ItemController(IItem itemService)
        {
            _itemService = itemService;
        }

        [HttpPost("Create-Item")]
        public async Task<IActionResult> CreateItem([FromBody] ItemDTO input)
        {
            var result = await _itemService.CreateItem(input) ;
            return Ok(result);
        }

        [HttpGet("Get-All-Items")]
        public async Task<IActionResult> GetAllItems()
        {
            var items = await _itemService.GetAllItems();
            return Ok(items);
        }
        [HttpGet("Get-One-Item/{id}")]
        public async Task<IActionResult> GetOneItem(int id)
        {
            var items = await _itemService.GetOneItemById(id);
            return Ok(items);
        }
        [HttpPut("Update Discount/{id}")]
        public async Task<IActionResult> UpdateItem(int id, [FromBody] ItemDTO input)
        {
            var result = await _itemService.UpdateItem(id, input);
            return Ok(result);
        }

        [HttpDelete("Delete-Item/{id}")]

        public async Task<IActionResult> DeleteItem(int id)
        {
            var result = await _itemService.DeleteItem(id);
            return Ok(result);
        }







    }
}
