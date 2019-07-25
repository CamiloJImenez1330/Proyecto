using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veterinaria.DO.Interfaces;

namespace Veterinaria.DAL
{
    public class manteMascota : CRUD<Mascota>
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
                VeteEntities1 entities = new VeteEntities1();
                var result = entities.Mascota.Find(entity.idMascota);
                entities.Mascota.Remove(result);
                entities.SaveChanges();

            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public List<Mascota> GetAll()
        {
            //Inicializamos
            List<Mascota> lista = new List<Mascota>();

            try
            {
                VeteEntities1 entities = new VeteEntities1();
                lista = entities.Mascota.ToList();
                entities.SaveChanges();

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
                VeteEntities1 entities = new VeteEntities1();
                entities.Mascota.Add(entity);
                entities.SaveChanges();

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
