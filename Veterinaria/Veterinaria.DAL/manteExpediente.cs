using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veterinaria.DO.Interfaces;

namespace Veterinaria.DAL
{
    public class manteExpediente : CRUD<Expediente>
    {
        private static manteExpediente Instancia;

        public static manteExpediente _Instancia
        {
            get
            {
                if (Instancia == null)
                {
                    return new manteExpediente();
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
                VeteEntities1 entities = new VeteEntities1();
                var result = entities.Expediente.Find(entity.idExpendiente);
                entities.Expediente.Remove(result);
                entities.SaveChanges();

            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public List<Expediente> GetAll()
        {
            //Inicializamos
            List<Expediente> lista = new List<Expediente>();

            try
            {
                VeteEntities1 entities = new VeteEntities1();
                lista = entities.Expediente.ToList();
                entities.SaveChanges();

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
                VeteEntities1 entities = new VeteEntities1();
                entities.Expediente.Add(entity);
                entities.SaveChanges();

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
