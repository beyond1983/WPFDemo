﻿using System;
using System.Collections;
using System.Data.Entity.Validation;
using System.Text;

namespace Zeor.Repository.Base
{
    public class UnitOfWork:IDisposable
    {
        private DataContext context = new DataContext();
        private Stack saveList = new Stack();

        public GenericRepository<T> GetRepository<T>() where T : class
        {
            return new GenericRepository<T>(context);
        }

        public void BeginTransaction()
        {
            this.saveList.Push(null);
        }

        public void Commit()
        {
            if (this.saveList.Count > 0)
            {
                this.saveList.Pop();
            }
            this.Save();
        }

        public void Save()
        {
            try
            {
                if (this.saveList.Count == 0)
                {
                    this.context.SaveChanges();
                }
            }
            catch (DbEntityValidationException dbEve)
            {
                StringBuilder exMsg = new StringBuilder();
                exMsg.AppendLine("");
                foreach (var item in dbEve.EntityValidationErrors)
                {
                    exMsg.AppendLine(item.Entry.Entity.ToString());
                    foreach (var v in item.ValidationErrors)
                    {
                        exMsg.AppendLine(v.ErrorMessage);
                    }
                }
                throw new Exception(exMsg.ToString());
            }
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
