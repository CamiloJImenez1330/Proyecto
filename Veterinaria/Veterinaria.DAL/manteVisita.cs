using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veterinaria.DO.Interfaces;

namespace Veterinaria.DAL
{
    public class manteVisita : CRUD<Visita>
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
                VeteEntities1 entities = new VeteEntities1();
                var result = entities.Visita.Find(entity.idVisita);
                entities.Visita.Remove(result);
                entities.SaveChanges();

            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public List<Visita> GetAll()
        {
            //Inicializamos
            List<Visita> lista = new List<Visita>();

            try
            {
                VeteEntities1 entities = new VeteEntities1();
                lista = entities.Visita.ToList();
                entities.SaveChanges();

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
                VeteEntities1 entities = new VeteEntities1();
                entities.Visita.Add(entity);
                entities.SaveChanges();

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
