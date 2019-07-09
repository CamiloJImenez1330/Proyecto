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
    public class manteRaza : CRUD<DAL.Raza>
    {
        private static manteRaza Instancia;

        public static manteRaza _Instancia
        {
            get
            {
                if (Instancia == null)
                {
                    return new manteRaza();
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

        public void Delete(Raza entity)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.manteRaza._Instancia.Delete(entity);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public List<Raza> GetAll()
        {
            List<Raza> lista = new List<Raza>();
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    lista = DAL.manteRaza._Instancia.GetAll();
                    scope.Complete();
                }
                return lista;
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public Raza GetOneById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Raza entity)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.manteRaza._Instancia.Insert(entity);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Update(Raza entity)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.manteRaza._Instancia.Update(entity);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }

        }

        List<Raza> CRUD<Raza>.GetAll()
        {
            throw new NotImplementedException();
        }
        Raza CRUD<Raza>.GetOneById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
