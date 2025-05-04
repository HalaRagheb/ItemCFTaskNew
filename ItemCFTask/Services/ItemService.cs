using ItemCFTask.Context;
using Items.DTOs;
using Items.Entities;
using Items.Interfaces;
using Microsoft.EntityFrameworkCore;


namespace Items.Services
{
    public class ItemService : IItem
    {
        MyItems items = new MyItems();
        private readonly DbContextItems _dbContextItems;
        public ItemService(DbContextItems dbContext)
        {

            _dbContextItems = dbContext;

        }

        public async Task<string> CreateItem(ItemDTO itemDTO)
        {


            items.ItemName = itemDTO.ItemName;
            items.Price = itemDTO.Price;
            items.Quantity = itemDTO.Quantity;
            items.Category = itemDTO.Category;
            items.Description = itemDTO.Description;
            items.Image = itemDTO.ImageURL;
            _dbContextItems.Add(items);
            _dbContextItems.SaveChanges();
            return "Item Created successfuly";
        }

        public async Task<string> DeleteItem(int id)
        {
            var item = await _dbContextItems.Items.FindAsync(id);
            if (item == null)
                throw new Exception("Item not found");
            _dbContextItems.Remove(item);
            _dbContextItems.SaveChanges();
            return "Item deleted Successfully";

        }

        public async Task<List<ItemDTO>> GetAllItems()
        {

            var Items = _dbContextItems.Items.ToList();

            var ItemDTOs = Items.Select(d => new ItemDTO
            {

                ItemName = d.ItemName,

                Price = d.Price,
                Quantity = d.Quantity,
                Description = d.Description,
                ImageURL = d.Image,
                Category = d.Category

            }).ToList();




            return ItemDTOs;



        }

        public async Task<ItemDTO> GetOneItemById(int id)
        {
            var item = await _dbContextItems.Items.SingleOrDefaultAsync(x => x.Id == id);
            if (item == null)
                throw new Exception("Item not found");

            var itemDto = new ItemDTO
            {
                ItemName = item.ItemName,
                Price = item.Price,
                Quantity = item.Quantity,
                Description = item.Description,
                ImageURL = item.Image,
                Category = item.Category
            };

            return itemDto;
        }
        public async Task<string> UpdateItem(int id, ItemDTO input)
        {
            var itemy = await _dbContextItems.Items.FindAsync(id);
            if (itemy == null)
                throw new Exception("Item not found");

            itemy.Price = input.Price;
            itemy.Quantity = input.Quantity;
            itemy.Category = input.Category;
            itemy.Description = input.Description;
            itemy.Image = input.ImageURL;
            itemy.ItemName = input.ItemName;

            await _dbContextItems.SaveChangesAsync();

            return "Item updated successfully";
        }

    }
}
