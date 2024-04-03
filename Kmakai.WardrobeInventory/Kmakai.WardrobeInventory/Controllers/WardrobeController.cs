﻿using Microsoft.AspNetCore.Http;
using Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Components.Forms;

namespace Kmakai.WardrobeInventory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WardrobeController : ControllerBase
    {
        private readonly WardrobeService _wardrobeService;

        public WardrobeController(WardrobeService wardrobeService)
        {
            _wardrobeService = wardrobeService;
        }

        // Item CRUD
        [HttpPost]
        [Route("item")]
        public async Task<ActionResult<WardrobeItem>> AddItem(WardrobeItem item)
        {
            var result = await _wardrobeService.AddItem(item);
            return Ok(result);
        }

        [HttpPost]
        [Route("item/{id:int}/image")]
        public async Task<ActionResult<WardrobeItem>> AddImage(int id)
        {
            var file = Request.Form.Files[0];
            var result = await _wardrobeService.UploadImage(file, id);
            return Ok(result);
        }

        [HttpPost]
        [Route("image")]
        public async Task<ActionResult<WardrobeItem>> AddImage()
        {
            var file = Request.Form.Files[0];

            Console.WriteLine("File uploaded: " + file+  $" the form size is : {Request.Form.Files.Count}");

            var extension = Path.GetExtension(file.Name);
            Console.WriteLine($"The extension is: {extension} ----------");
            var fileName = Path.GetFileName(file.Name);
            Console.WriteLine($"The file name is: {fileName} ----------");
            var path = Path.Combine("wwwroot", "images", fileName);
            await using var stream = new FileStream(path, FileMode.Create);
            await file.OpenReadStream().CopyToAsync(stream);


            //var result = await _wardrobeService.HandleImageUpload(file);
            return Ok();
        }

        [HttpGet]
        [Route("item/{id:int}")]
        public async Task<ActionResult<WardrobeItem>> GetItem(int id)
        {
            var result = await _wardrobeService.GetItem(id);
           
            return Ok(result);
           
        }

        [HttpGet]
        [Route("items")]
        public async Task<ActionResult<List<WardrobeItem>>> GetItems()
        {
            var result = await _wardrobeService.GetItems();
            return Ok(result);
        }

    }
}
