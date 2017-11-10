﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using NewBookingofmeetingrooms;

namespace NewBookingofmeetingrooms.ControllersApi
{
    public class UsersController : ApiController
    {
        
        private BookingOfMeetingRoomsDBEntities db = new BookingOfMeetingRoomsDBEntities();

        // GET: api/Users
        public IQueryable<Users> GetUsers()
        {
            return db.Users;
        }
//
//        // GET: api/Users/5
//        [ResponseType(typeof(Users))]
//        public IHttpActionResult GetUsers(int id)
//        {
//            Users users = db.Users.Find(id);
//            if (users == null)
//            {
//                return NotFound();
//            }
//
//            return Ok(users);
//        }

        // POST: api/Users/Authentication
        [ResponseType(typeof(Users))]
        public IHttpActionResult Authentication(Users users)
        {
            var userbase = db.Users.Where(p => p.UserName == users.UserName & p.Password == users.Password);

            if (userbase == null)
            {
                return NotFound();
            }

            return Ok(userbase);
        }

        // POST: api/Users/Registration
        [ResponseType(typeof(Users))]
        public IHttpActionResult Registration(Users users)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
           
            db.Users.Add(users);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = users.Id }, users);
        }

        

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool UsersExists(int id)
        {
            return db.Users.Count(e => e.Id == id) > 0;
        }
    }
}