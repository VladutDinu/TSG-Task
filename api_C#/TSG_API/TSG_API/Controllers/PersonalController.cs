using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TSG_API.Models;
namespace TSG_API.Controllers
{
 
    public class PersonalController : ApiController
    {
        // GET api/personal

        public IEnumerable<string> Get()
        {
            using (var context = new TSGEntities())
            {
                string result = "";
                foreach (var data in context.SelectPersonal_TSG())
                {
                    result +=  "ID: " + data.ID.ToString() + " Nume: " + data.Nume.ToString() + " ID_Proiect: " + data.ID_Proiect.ToString() + "\r\n";
                }
                return new string[] { result };
            }
        }

        // POST api/personal
        public void Post(string nume, int id_proiect)
        {
            using (var context = new TSGEntities())
            {
                context.CreatePersonal_TSG(nume, id_proiect);
            }
        }

        // PUT api/personal/
        public void Put(int id_proiect, string nume)
        {
            using (var context = new TSGEntities())
            {
                context.UpdatePersonal_TSG(id_proiect, nume);
            }
        }

        // DELETE api/personal
        public void Delete(string nume)
        {
            using (var context = new TSGEntities())
            {
                context.DeletePersonal_TSG(nume);
            }
        }
    }
}