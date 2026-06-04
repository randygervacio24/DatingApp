using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/fixedassets")] //localhost:5001/api/fixedassets (FxiedAssetController -> fixedasset)
    [ApiController]

    public class FixedAssetController(AppDbContext context) : ControllerBase
    {
        [HttpGet]

        public async Task<ActionResult<IReadOnlyList<FixedAsset>>> GetFixedAssets() //plural
        {
            var assets = await context.FixedAssets.ToListAsync();

            return assets;
        }

        [HttpGet("{id}")] //localhost:5001/api/randy-id
        public async Task<ActionResult<FixedAsset>> GetFixedAsset (string id) //singular
        {
            var asset = await context.FixedAssets.FindAsync(id);

           if (asset == null) return NotFound();

           return asset;
        }
    }
}