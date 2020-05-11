﻿using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using TMS.Client.Domain.Interfaces;
using TMS.Client.Domain.Model;

namespace TMS.Clientes.Repository.Repository
{
    public class ClientRepository : IClientRepository
    {
        public bool Post(ClientModel obj)
        {
            try
            {
                using (var db = new LiteDatabase("Database.db"))
                {
                    var col = db.GetCollection<ClientModel>("cliente");
                    Guid id = col.Insert(obj);
                }
            }
            catch
            {
                return false;
            }
            return true;
        }
        public bool Delete(Guid id)
        {
            try
            {
                using (var db = new LiteDatabase("Database.db"))
                {
                    var col = db.GetCollection<ClientModel>("cliente");
                    if (col.FindById(id) != null)
                        return col.Delete(id);
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public ClientModel Get(Guid id)
        {
            try
            {
                using (var db = new LiteDatabase("Database.db"))
                {
                    var col = db.GetCollection<ClientModel>("cliente");
                    return col.FindById(id);
                }
            }
            catch
            {
                return new ClientModel();
            }
        }

        public IList<ClientModel> GetAll()
        {
            try
            {
                using (var db = new LiteDatabase("Database.db"))
                {
                    var col = db.GetCollection<ClientModel>("cliente");
                    return col.FindAll().ToList();
                }
            }
            catch
            {
                return new List<ClientModel>();
            }
        }

        public bool Put(ClientModel obj)
        {
            try
            {
                using (var db = new LiteDatabase("Database.db"))
                {
                    var col = db.GetCollection<ClientModel>("cliente");
                    return col.Update(obj);
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
