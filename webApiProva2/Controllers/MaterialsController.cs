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
    public class MaterialsController : ApiController
    {
        private Conexao db = new Conexao();

        // GET: api/Materials
        /// <summary>
        /// Recupera todos os materiais.
        /// </summary>
        /// <returns></returns>
        public IQueryable<Material> GetMaterial()
        {
            return db.Material;
        }
 

        // GET: api/Materials/5
        /// <summary>
        /// Recupera material por Id.
        /// </summary>
        /// <param name="id">id a ser recuperado.</param>
        /// <returns></returns>
        [ResponseType(typeof(Material))]
        public IHttpActionResult GetMaterial(int id)
        {
            Material material = db.Material.Find(id);
            if (material == null)
            {
                return NotFound();
            }

            return Ok(material);
        }
        /// <summary>
        /// Perquisa material pelo nome.
        /// </summary>
        /// <param name="nome">Nome a ser pesquisado.</param>
        /// <returns></returns>
        [Route("api/Material/search/{nome}")]
        public IQueryable<Material> GetMaterialbyName(string nome)
        {
            return db.Material.Where(e => e.nome.Contains(nome));
        }

        // PUT: api/Materials/5
        /// <summary>
        /// Atualiza material.
        /// </summary>
        /// <param name="id">id para atualização.</param>
        /// <param name="material">Material ja atualizado.</param>
        /// <returns></returns>
        [ResponseType(typeof(void))]
        public IHttpActionResult PutMaterial(int id, Material material)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != material.id)
            {
                return BadRequest();
            }

            db.Entry(material).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MaterialExists(id))
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

        // POST: api/Materials
        /// <summary>
        /// Insere novo material.
        /// </summary>
        /// <param name="material">Material a ser inserido.</param>
        /// <returns></returns>
        [ResponseType(typeof(Material))]
        public IHttpActionResult PostMaterial(Material material)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Material.Add(material);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = material.id }, material);
        }

        // DELETE: api/Materials/5
        /// <summary>
        /// Deleta material por Id.
        /// </summary>
        /// <param name="id">Id a ser deletado.</param>
        /// <returns></returns>
        [ResponseType(typeof(Material))]
        public IHttpActionResult DeleteMaterial(int id)
        {
            Material material = db.Material.Find(id);
            if (material == null)
            {
                return NotFound();
            }

            db.Material.Remove(material);
            db.SaveChanges();

            return Ok(material);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool MaterialExists(int id)
        {
            return db.Material.Count(e => e.id == id) > 0;
        }
    }
}