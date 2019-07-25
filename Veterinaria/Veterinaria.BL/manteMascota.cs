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
    public class manteMascota : CRUD<DAL.Mascota>
    {
        private static manteMascota Instancia;

        public static manteMascota _Instancia
        {
            get
            {
                if (Instancia == null)
                {
                    return new manteMascota();
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

        public void Delete(Mascota entity)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.manteMascota._Instancia.Delete(entity);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public List<Mascota> GetAll()
        {
            List<Mascota> lista = new List<Mascota>();
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    lista = DAL.manteMascota._Instancia.GetAll();
                    scope.Complete();
                }
                return lista;
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public Mascota GetOneById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Mascota entity)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.manteMascota._Instancia.Insert(entity);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Update(Mascota entity)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.manteMascota._Instancia.Update(entity);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }

        }

        List<Mascota> CRUD<Mascota>.GetAll()
        {
            throw new NotImplementedException();
        }
        Mascota CRUD<Mascota>.GetOneById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
