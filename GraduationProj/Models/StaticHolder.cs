using GraduationProj.Data;
using Microsoft.EntityFrameworkCore;

namespace GraduationProj.Models
{
    public class StaticHolder
    {
       
        public async Task<UserItems> LoadUserItems (MainDataContext _db,int account_Id)
        {
            var UserItems = _db.UserItems.Include(ui => ui.Account)
                                           .Include(ui => ui.Cart)
                                           .Include(ui => ui.Wishlist)
                                           .ThenInclude(w => w.ProductWishlists)
                                           .ThenInclude(wl => wl.Product)
                                           .FirstOrDefault(ex => ex.AccountId == account_Id);

            if (UserItems == null)
            {
                UserItems userItems = new UserItems
                {
                    AccountId = account_Id,
                    Wishlist = new Wishlist(),
                    Address = new Address(),
                    Cart = new Cart()
                };

                UserItems = userItems;

                _db.Add(userItems);

                await _db.SaveChangesAsync();
            }

            return UserItems;

        }
    }
}
