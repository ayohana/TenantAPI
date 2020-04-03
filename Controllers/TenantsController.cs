using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        public ActionResult<IEnumerable<Tenant>> Get(string apartmentName, string apartmentNumber, string lastName)
        {
            var query = _db.Tenants.AsQueryable();
            if (apartmentName != null)
            {
                query = query.Where(tenant => tenant.ApartmentName.Contains(apartmentName) == true);
            }
            if (apartmentNumber != null)
            {
                query = query.Where(tenant => tenant.ApartmentNumber == apartmentNumber);
            }
            if (lastName != null)
            {
                query = query.Where(tenant => tenant.LastName == lastName);
            }
            return query.ToList();
        }

        // GET api/tenants/5
        [HttpGet("{id}")]
        public ActionResult<Tenant> Get(int id)
        {
            return _db.Tenants.FirstOrDefault(tenant => tenant.TenantId == id);
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
        public void Put(int id, [FromBody] Tenant tenant)
        {
            tenant.TenantId = id;
            _db.Entry(tenant).State = EntityState.Modified;
            _db.SaveChanges();
        }

        // DELETE api/tenants/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var tenantToDelete = _db.Tenants.FirstOrDefault(tenant => tenant.TenantId == id);
            _db.Tenants.Remove(tenantToDelete);
            _db.SaveChanges();
        }
    }
}
