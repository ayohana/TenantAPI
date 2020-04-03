using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TenantAPI.Models;

namespace TenantAPI.Controllers
{
    // Version 1.0 ==================================
    [ApiVersion("1.0")]
    [Route("api/tenants")]
    [ApiController]
    public class TenantsV1Controller : ControllerBase
    {
        private TenantAPIContext _db;

        public TenantsV1Controller(TenantAPIContext db)
        {
            _db = db;
        }

        // GET api/tenants/?api-version=1.0
        [HttpGet]
        public ActionResult<IEnumerable<Tenant>> Get(string apartmentName, string apartmentNumber, string lastName)
        {
            var query = _db.Tenants.AsQueryable();
            if (apartmentName != null)
            {
                query = query.Where(tenant => tenant.ApartmentName == apartmentName);
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

        // GET api/tenants/5/?api-version=1.0
        [HttpGet("{id}")]
        public ActionResult<Tenant> Get(int id)
        {
            return _db.Tenants.FirstOrDefault(tenant => tenant.TenantId == id);
        }

        // POST api/tenants/?api-version=1.0
        [HttpPost]
        public void Post([FromBody] Tenant tenant)
        {
            _db.Tenants.Add(tenant);
            _db.SaveChanges();
        }

        // PUT api/tenants/5/?api-version=1.0
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Tenant tenant)
        {
            tenant.TenantId = id;
            _db.Entry(tenant).State = EntityState.Modified;
            _db.SaveChanges();
        }

        // DELETE api/tenants/5/?api-version=1.0
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var tenantToDelete = _db.Tenants.FirstOrDefault(tenant => tenant.TenantId == id);
            _db.Tenants.Remove(tenantToDelete);
            _db.SaveChanges();
        }
    }

    // Version 2.0 ==================================
    [ApiVersion("2.0")]
    [Route("api/tenants")]
    [ApiController]
    public class TenantsV2Controller : ControllerBase
    {
        private TenantAPIContext _db;

        public TenantsV2Controller(TenantAPIContext db)
        {
            _db = db;
        }

        // GET api/tenants
        [HttpGet]
        public ActionResult<IEnumerable<Tenant>> Get(string apartmentName, string apartmentNumber, string name)
        {
            var query = _db.Tenants.AsQueryable();
            if (apartmentName != null)
            {
                query = query.Where(tenant => tenant.ApartmentName.Contains(apartmentName) == true);
            }
            if (apartmentNumber != null)
            {
                query = query.Where(tenant => tenant.ApartmentNumber.Contains(apartmentNumber) == true);
            }
            if (name != null)
            {
                query = query.Where(tenant => tenant.LastName.Contains(name) == true || tenant.FirstName.Contains(name) == true);
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
