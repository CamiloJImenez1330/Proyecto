using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veterinaria.DO.Interfaces;

namespace Veterinaria.DAL
{
    public class manteDueno : CRUD<Dueno>
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
                VeteEntities1 entities = new VeteEntities1();
                var result = entities.Dueno.Find(entity.idDueno);
                entities.Dueno.Remove(result);
                entities.SaveChanges();

            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public List<Dueno> GetAll()
        {
            //Inicializamos
            List<Dueno> lista = new List<Dueno>();

            try
            {
                VeteEntities1 entities = new VeteEntities1();
                lista = entities.Dueno.ToList();
                entities.SaveChanges();

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
                VeteEntities1 entities = new VeteEntities1();
                entities.Dueno.Add(entity);
                entities.SaveChanges();

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
