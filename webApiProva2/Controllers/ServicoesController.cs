﻿using System;
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
        /// <summary>
        /// Recupera todos os Serviços.
        /// </summary>
        /// <returns></returns>
        public IQueryable<Servico> GetServico()
        {
            return db.Servico;
        }

        // GET: api/Servicoes/5
        /// <summary>
        /// Recupera serviço por Id.
        /// </summary>
        /// <param name="id">Id a ser recuperado.</param>
        /// <returns></returns>
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
        /// <summary>
        /// Pesquisa Serviço por Id do cliente.
        /// </summary>
        /// <param name="idClient">id a ser pesqusiado.</param>
        /// <returns></returns>
        [Route("api/Servico/search/{nome}")]
        public IQueryable<Servico> SearchServico(int idClient)
        {
            return db.Servico.Where(e => e.idCliente == idClient);
        }

        // PUT: api/Servicoes/5
        /// <summary>
        /// Atualiza Serviço por id.
        /// </summary>
        /// <param name="id">id a ser atualizado.</param>
        /// <param name="servico">Serviço atualizado.</param>
        /// <returns></returns>
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
        /// <summary>
        /// Insere novo Serviço.
        /// </summary>
        /// <param name="servico">Serviço a ser inserido.</param>
        /// <returns></returns>
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
        


        // DELETE: api/Servicoes/5
        /// <summary>
        /// Deleta serviço por Id.
        /// </summary>
        /// <param name="id">Id a ser deletad.o</param>
        /// <returns></returns>
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