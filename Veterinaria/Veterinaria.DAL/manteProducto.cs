using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veterinaria.DO.Interfaces;

namespace Veterinaria.DAL
{
    public class manteProducto : CRUD<Producto>
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
                VeteEntities1 entities = new VeteEntities1();
                var result = entities.Producto.Find(entity.idProducto);
                entities.Producto.Remove(result);
                entities.SaveChanges();

            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public List<Producto> GetAll()
        {
            //Inicializamos
            List<Producto> lista = new List<Producto>();

            try
            {
                VeteEntities1 entities = new VeteEntities1();
                lista = entities.Producto.ToList();
                entities.SaveChanges();

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
                VeteEntities1 entities = new VeteEntities1();
                entities.Producto.Add(entity);
                entities.SaveChanges();

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
                using (VeteEntities1 entities = new VeteEntities1())
                {
                    entities.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                    entities.SaveChanges();

                    //var result = entities.Personas.Find(persona.iID);
                    //result = persona;
                    //entities.SaveChanges();
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
