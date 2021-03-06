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
    public class GastosController : ApiController
    {
        private Conexao db = new Conexao();

        // GET: api/Gastos
        /// <summary>
        /// Recupera todos os gastos.
        /// </summary>
        /// <returns></returns>
        public IQueryable<Gasto> GetGasto()
        {
            return db.Gasto;
        }

        // GET: api/Gastos/5
        /// <summary>
        /// Recupera gasto por id.
        /// </summary>
        /// <returns></returns>
        [ResponseType(typeof(Gasto))]
        public IHttpActionResult GetGasto(int id)
        {
            Gasto gasto = db.Gasto.Find(id);
            if (gasto == null)
            {
                return NotFound();
            }

            return Ok(gasto);
        }
        
        // PUT: api/Gastos/5
        /// <summary>
        /// Atualiza gasto.
        /// </summary>
        /// <param name="id">id para atualizar.</param>
        /// <param name="gasto">gasto atualizado.</param>
        /// <returns></returns>
        [ResponseType(typeof(void))]
        public IHttpActionResult PutGasto(int id, Gasto gasto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != gasto.idGasto)
            {
                return BadRequest();
            }

            db.Entry(gasto).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GastoExists(id))
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

        // POST: api/Gastos
        /// <summary>
        /// Insere novo gasto.
        /// </summary>
        /// <param name="gasto">Gasto a aser inserido.</param>
        /// <returns></returns>
        [ResponseType(typeof(Gasto))]
        public IHttpActionResult PostGasto(Gasto gasto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Gasto.Add(gasto);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = gasto.idGasto }, gasto);
        }

        // DELETE: api/Gastos/5
        /// <summary>
        /// Deleta gasto por id.
        /// </summary>
        /// <param name="id">id a ser deletado.</param>
        /// <returns></returns>
        [ResponseType(typeof(Gasto))]
        public IHttpActionResult DeleteGasto(int id)
        {
            Gasto gasto = db.Gasto.Find(id);
            if (gasto == null)
            {
                return NotFound();
            }

            db.Gasto.Remove(gasto);
            db.SaveChanges();

            return Ok(gasto);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool GastoExists(int id)
        {
            return db.Gasto.Count(e => e.idGasto == id) > 0;
        }
    }
}