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
    public class manteVisita : CRUD<DAL.Visita>
    {
        private static manteVisita Instancia;

        public static manteVisita _Instancia
        {
            get
            {
                if (Instancia == null)
                {
                    return new manteVisita();
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

        public void Delete(Visita entity)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.manteVisita._Instancia.Delete(entity);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public List<Visita> GetAll()
        {
            List<Visita> lista = new List<Visita>();
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    lista = DAL.manteVisita._Instancia.GetAll();
                    scope.Complete();
                }
                return lista;
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public Visita GetOneById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Visita entity)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.manteVisita._Instancia.Insert(entity);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Update(Visita entity)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.manteVisita._Instancia.Update(entity);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }

        }

        List<Visita> CRUD<Visita>.GetAll()
        {
            throw new NotImplementedException();
        }
        Visita CRUD<Visita>.GetOneById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
