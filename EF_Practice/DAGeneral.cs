using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Practice
{
    public class DAGeneral
    {
        static public List<Marca> listadoMarca()
        {
            List<Marca> listado = new List<Marca>();
            using (var data = new BDAlquilerVehiculoEntities())
            {
                return data.Marca.ToList();
            }
        }
        static public bool RegistrarMarca(Marca Marca)
        {
            bool exito = true;
            try
            {
                using (var data = new BDAlquilerVehiculoEntities())
                {
                    data.Marca.Add(Marca);
                    data.SaveChanges();
                }
            }
            catch
            {

                exito = false;
            }

            return exito;
        }
        static public bool ActualizarMarca(Marca Marca)
        {
            bool exito = true;
            try
            {
                using (var data = new BDAlquilerVehiculoEntities())
                {
                    Marca actual = data.Marca.Where(x => x.CodMarca == Marca.CodMarca).FirstOrDefault();
                    actual.CodMarca = Marca.CodMarca;
                    actual.Descripcion = Marca.Descripcion;
                    actual.Pais = Marca.Pais;
                    
                    data.SaveChanges();
                }

            }
            catch (Exception)
            {

                exito = false;
            }
            return exito;
        }
        static public bool EliminarMarca(Marca Marca)
        {
            bool exito = true;
            try
            {
                using (var data = new BDAlquilerVehiculoEntities())
                {
                    Marca actual = data.Marca.Where(x => x.CodMarca == Marca.CodMarca).FirstOrDefault();
                    data.Marca.Remove(actual);
                    data.SaveChanges();
                }
            }
            catch (Exception)
            {

                exito = false;
            }
            return exito;
        }


        static public List<Modelo> listadoModelo()
        {
            List<Modelo> listado = new List<Modelo>();
            using (var data = new BDAlquilerVehiculoEntities())
            {
                return data.Modelo.ToList();
            }
        }
        static public bool RegistrarModelo(Modelo Modelo)
        {
            bool exito = true;
            try
            {
                using (var data = new BDAlquilerVehiculoEntities())
                {
                    data.Modelo.Add(Modelo);
                    data.SaveChanges();
                }
            }
            catch
            {

                exito = false;
            }

            return exito;
        }
        static public bool ActualizarModelo(Modelo Modelo)
        {
            bool exito = true;
            try
            {
                using (var data = new BDAlquilerVehiculoEntities())
                {
                    Modelo actual = data.Modelo.Where(x => x.CodModelo == Modelo.CodModelo).FirstOrDefault();
                    actual.CodModelo = Modelo.CodModelo;
                    actual.Descripcion = Modelo.Descripcion;
                    actual.Puertas = Modelo.Puertas;
                    actual.Precio = Modelo.Precio;
                    actual.CodMarca = Modelo.CodMarca;
                    
                    data.SaveChanges();
                }

            }
            catch (Exception)
            {

                exito = false;
            }
            return exito;
        }
        static public bool EliminarModelo(Modelo Modelo)
        {
            bool exito = true;
            try
            {
                using (var data = new BDAlquilerVehiculoEntities())
                {
                    Modelo actual = data.Modelo.Where(x => x.CodModelo == Modelo.CodModelo).FirstOrDefault();
                    data.Modelo.Remove(actual);
                    data.SaveChanges();
                }
            }
            catch (Exception)
            {

                exito = false;
            }
            return exito;
        }
    }

}
