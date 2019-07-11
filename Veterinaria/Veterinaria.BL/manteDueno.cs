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
    public class manteDueno : CRUD<DAL.Dueno>
    {
        private static manteDueno Instancia;

        public static manteDueno _Instancia
        {
            get
            {
                if (Instancia == null)
                {
                    return new manteDueno();
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

        public void Delete(Dueno entity)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.manteDueno._Instancia.Delete(entity);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public List<Dueno> GetAll()
        {
            List<Dueno> lista = new List<Dueno>();
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    lista = DAL.manteDueno._Instancia.GetAll();
                    scope.Complete();
                }
                return lista;
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public Dueno GetOneById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Dueno entity)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.manteDueno._Instancia.Insert(entity);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Update(Dueno entity)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.manteDueno._Instancia.Update(entity);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }

        }

        List<Dueno> CRUD<Dueno>.GetAll()
        {
            throw new NotImplementedException();
        }
        Dueno CRUD<Dueno>.GetOneById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
