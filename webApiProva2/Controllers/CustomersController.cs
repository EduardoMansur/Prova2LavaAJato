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
    public class CustomersController : ApiController
    {
        private Conexao db = new Conexao();

        // GET: api/Customers
        /// <summary>
        /// Recupera todos os clientes.
        /// </summary>
        /// <returns>XML com clientes.</returns>
        public IQueryable<Customer> GetCustomer()
        {
            return db.Customer;
        }


        // GET: api/Customers/5
        /// <summary>
        /// Recupera cliente por id.
        /// </summary>
        /// <returns>XML com cliente.</returns>
        [ResponseType(typeof(Customer))]
        public IHttpActionResult GetCustomer(int id)
        {
            Customer customer = db.Customer.Find(id);
            if (customer == null)
            {
                return NotFound();
            }

            return Ok(customer);
        }

        // PUT: api/Customers/5
        /// <summary>
        /// Atualiza cliente por id.
        /// </summary>
        /// <returns></returns>
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCustomer(int id, Customer customer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != customer.idCustomer)
            {
                return BadRequest();
            }

            db.Entry(customer).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CustomerExists(id))
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
        
        // POST: api/Customers
        /// <summary>
        /// Insere novo Cliente.
        /// </summary>
        /// <param name="customer">Cliente a ser adicionado.</param>
        /// <returns></returns>
        [ResponseType(typeof(Customer))]
        public IHttpActionResult PostCustomer(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Customer.Add(customer);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = customer.idCustomer }, customer);
        }

        /// <summary>
        /// Recupera cliente pelo nome.
        /// </summary>
        /// <param name="nome">Nome a ser pesquisado.</param>
        /// <returns>XML com resultados</returns>
        [Route("api/Customer/search/{nome}")]
        public IQueryable<Customer> GetCustomer(string nome)
        {
            return db.Customer.Where(e => e.nome.Contains(nome));
        }
        // DELETE: api/Customers/5
        /// <summary>
        /// Deleta cliente pelo id.
        /// </summary>
        /// <param name="id">Id do cliente a ser deletado.</param>
        /// <returns></returns>
        [ResponseType(typeof(Customer))]
        public IHttpActionResult DeleteCustomer(int id)
        {
            Customer customer = db.Customer.Find(id);
            if (customer == null)
            {
                return NotFound();
            }

            db.Customer.Remove(customer);
            db.SaveChanges();

            return Ok(customer);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CustomerExists(int id)
        {
            return db.Customer.Count(e => e.idCustomer == id) > 0;
        }
    }
}