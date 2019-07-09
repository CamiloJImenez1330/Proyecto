using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veterinaria.DO.Interfaces;

namespace Veterinaria.DAL
{
    public class manteRaza : CRUD<Raza>
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
                VeteEntities entities = new VeteEntities();
                var result = entities.Raza.Find(entity.idRaza);
                entities.Raza.Remove(result);
                entities.SaveChanges();

            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public List<Raza> GetAll()
        {
            //Inicializamos
            List<Raza> lista = new List<Raza>();

            try
            {
                VeteEntities entities = new VeteEntities();
                lista = entities.Raza.ToList();
                entities.SaveChanges();

                return lista;
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Insert(Raza entity)
        {
            try
            {
                VeteEntities entities = new VeteEntities();
                entities.Raza.Add(entity);
                entities.SaveChanges();

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
                using (VeteEntities entities = new VeteEntities())
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
