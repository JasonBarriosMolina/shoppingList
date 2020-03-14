using LambdaShoppingList.Models;
using System.Collections.Generic;

namespace LambdaShoppingList.Services
{
    public interface IShoppingListService
    {

        Dictionary<string, int> GetItemFromShoppingList();
        void AddItemsToShoppingList(ShoppingListModel shoppingList);
        void RemoveItem(string name);
    }
}