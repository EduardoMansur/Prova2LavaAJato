using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using webApiProva2.Connect;
using webApiProva2.Models;

namespace webApiProva2.Controllers
{
    public class ServicoesController : ApiController
    {
        private Conexao db = new Conexao();

        // GET: api/Servicoes
        public IQueryable<Servico> GetServico()
        {
            return db.Servico;
        }

        // GET: api/Servicoes/5
        [ResponseType(typeof(Servico))]
        public IHttpActionResult GetServico(int id)
        {
            Servico servico = db.Servico.Find(id);
            if (servico == null)
            {
                return NotFound();
            }

            return Ok(servico);
        }

        // PUT: api/Servicoes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutServico(int id, Servico servico)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != servico.idServico)
            {
                return BadRequest();
            }

            db.Entry(servico).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ServicoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Servicoes
        [ResponseType(typeof(Servico))]
        public IHttpActionResult PostServico(Servico servico)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Servico.Add(servico);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = servico.idServico }, servico);
        }
        [Route("api/Servico/search/{nome}")]
        public IQueryable<Servico> SearchServico(int idClient)
        {
            return db.Servico.Where(e => e.idCliente == idClient);
        }


        // DELETE: api/Servicoes/5
        [ResponseType(typeof(Servico))]
        public IHttpActionResult DeleteServico(int id)
        {
            Servico servico = db.Servico.Find(id);
            if (servico == null)
            {
                return NotFound();
            }

            db.Servico.Remove(servico);
            db.SaveChanges();

            return Ok(servico);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ServicoExists(int id)
        {
            return db.Servico.Count(e => e.idServico == id) > 0;
        }
    }
}