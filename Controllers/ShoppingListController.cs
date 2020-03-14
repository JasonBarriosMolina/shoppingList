using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LambdaShoppingList.Models;
using LambdaShoppingList.Services;
using Microsoft.AspNetCore.Mvc;

namespace LambdaShoppingList.Controllers
{
    [Route("v1/productList")]
    public class ProductListController : Controller 
    {
        [HttpGet]
        public IActionResult GetProductList()
        {
            return Ok("Testing...");
        }

    }
}