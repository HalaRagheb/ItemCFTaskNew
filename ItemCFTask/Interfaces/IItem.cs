using Items.DTOs;

namespace Items.Interfaces
{
    public interface IItem
    {
        Task<List<ItemDTO>> GetAllItems();

        Task<ItemDTO> GetOneItemById(int id);
        Task<string> CreateItem(ItemDTO itemDTO);
        Task<string> UpdateItem(int id, ItemDTO input);
        Task<string> DeleteItem(int id);
    }
}
