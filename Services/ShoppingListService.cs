using LambdaShoppingList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LambdaShoppingList.Services
{
    public class ShoppingListService : IShoppingListService
    {
        public Dictionary<string, int> _shoppingListStorage = new Dictionary<string, int>();

        public void AddItemsToShoppingList(ShoppingListModel shoppingList)
        {
            _shoppingListStorage.Add(shoppingList.Name,shoppingList.Quantity);
        }

        public Dictionary<string, int> GetItemFromShoppingList() 
        {
            return _shoppingListStorage;
        }

        public void RemoveItem(string name)
        {
            _shoppingListStorage.Remove(name);
        }
    }
}
