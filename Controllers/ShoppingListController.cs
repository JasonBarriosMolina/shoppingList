﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LambdaShoppingList.Models;
using LambdaShoppingList.Services;
using Microsoft.AspNetCore.Mvc;

namespace LambdaShoppingList.Controllers
{
    [Route("v1/shoppingList")]
    public class ShoppingListController : Controller
    {
        private readonly IShoppingListService _shoppingListService;

        public ShoppingListController(IShoppingListService shoppingListService)
        {
            _shoppingListService = shoppingListService;
        }

        [HttpGet]
        public IActionResult GetShoppingList()
        {
            var result = _shoppingListService.GetItemFromShoppingList();
            return Ok(result);
        }
        [HttpPost]
        public IActionResult AddItemToShoppingList([FromBody] ShoppingListModel shoppingList)
        {
            _shoppingListService.AddItemsToShoppingList(shoppingList);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteItemsFromShoppingList([FromBody] ShoppingListModel shoppingList)
        {
            _shoppingListService.RemoveItem(shoppingList.Name);

            return Ok();
        }
    }
}