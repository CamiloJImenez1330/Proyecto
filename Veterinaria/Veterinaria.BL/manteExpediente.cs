using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Veterinaria.DAL;
using Veterinaria.DO.Interfaces;

namespace Veterinaria.BL
{
    public class manteExpendiente : CRUD<DAL.Expediente>
    {
        private static manteExpendiente Instancia;

        public static manteExpendiente _Instancia
        {
            get
            {
                if (Instancia == null)
                {
                    return new manteExpendiente();
                }
                return Instancia;
            }
            set
            {
                if (Instancia == null)
                {
                    Instancia = value;
                }
            }
        }

        public void Delete(Expediente entity)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.manteExpediente._Instancia.Delete(entity);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public List<Expediente> GetAll()
        {
            List<Expediente> lista = new List<Expediente>();
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    lista = DAL.manteExpediente._Instancia.GetAll();
                    scope.Complete();
                }
                return lista;
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public Expediente GetOneById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Expediente entity)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.manteExpediente._Instancia.Insert(entity);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Update(Expediente entity)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.manteExpediente._Instancia.Update(entity);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }

        }

        List<Expediente> CRUD<Expediente>.GetAll()
        {
            throw new NotImplementedException();
        }
        Expediente CRUD<Expediente>.GetOneById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
