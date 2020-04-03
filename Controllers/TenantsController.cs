using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TenantAPI.Models;

namespace TenantAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TenantsController : ControllerBase
    {
        private TenantAPIContext _db;

        public TenantsController(TenantAPIContext db)
        {
            _db = db;
        }

        // GET api/tenants
        [HttpGet]
        public ActionResult<IEnumerable<Tenant>> Get()
        {
            return _db.Tenants.ToList();
        }

        // GET api/tenants/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/tenants
        [HttpPost]
        public void Post([FromBody] Tenant tenant)
        {
            _db.Tenants.Add(tenant);
            _db.SaveChanges();
        }

        // PUT api/tenants/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/tenants/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
