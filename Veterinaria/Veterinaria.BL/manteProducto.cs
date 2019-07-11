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
    public class manteProducto : CRUD<DAL.Producto>
    {
        private static manteProducto Instancia;

        public static manteProducto _Instancia
        {
            get
            {
                if (Instancia == null)
                {
                    return new manteProducto();
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

        public void Delete(Producto entity)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.manteProducto._Instancia.Delete(entity);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public List<Producto> GetAll()
        {
            List<Producto> lista = new List<Producto>();
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    lista = DAL.manteProducto._Instancia.GetAll();
                    scope.Complete();
                }
                return lista;
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public Producto GetOneById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Producto entity)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.manteProducto._Instancia.Insert(entity);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Update(Producto entity)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.manteProducto._Instancia.Update(entity);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }

        }

        List<Producto> CRUD<Producto>.GetAll()
        {
            throw new NotImplementedException();
        }
        Producto CRUD<Producto>.GetOneById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
