using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using DoAtaApi.Models;
namespace DoAtaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoAtaController : ControllerBase
    {
        private readonly DoAtaContext _context;
        public DoAtaController(DoAtaContext context)
        {
            _context = context;
            // var item = _context.Types.Find(1);
            // _context.DoAtaItems.Add(
            //     new DoAtaItem
            //     {
            //         Name = "Item" + (_context.DoAtaItems.Count() + 1),
            //         Type = item,
            //         Description = "test"
            //     });
            // _context.SaveChanges();

        }
        [HttpGet]
        public ActionResult<List<DoAtaItem>> GetAll()
        {
            return _context.DoAtaItems.ToList();
        }

        [HttpGet("{id}", Name = "GetDoAta")]
        public ActionResult<DoAtaItem> GetById(long id)
        {
            var item = _context.DoAtaItems.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return item;
        }

        [HttpPost]
        public void Create([FromBody]DoAtaItem item)
        {
            _context.DoAtaItems.Add(item);
            _context.SaveChanges();
        }

        [HttpPut]
        public void Edit([FromBody]DoAtaItem item)
        {
            _context.DoAtaItems.Update(item);
            _context.SaveChanges();

        }

        [HttpDelete("{id}", Name = "DeleteDoAta")]
        [Route("api/DoAta/Delete/id")]
        public void Delete(long id)
        {
            var item = _context.DoAtaItems.Find(id);
            _context.DoAtaItems.Remove(item);
            _context.SaveChanges();
        }
    }
}
