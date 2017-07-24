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

        static public List<Reserva> listadoReserva()
        {
            List<Reserva> listado = new List<Reserva>();
            using (var data = new BDAlquilerVehiculoEntities())
            {
                return data.Reserva.ToList();
            }
        }
        static public bool RegistrarReserva(Reserva Reserva)
        {
            bool exito = true;
            try
            {
                using (var data = new BDAlquilerVehiculoEntities())
                {
                    data.Reserva.Add(Reserva);
                    data.SaveChanges();
                }
            }
            catch
            {

                exito = false;
            }

            return exito;
        }
        static public bool ActualizarReserva(Reserva Reserva)
        {
            bool exito = true;
            try
            {
                using (var data = new BDAlquilerVehiculoEntities())
                {
                    Reserva actual = data.Reserva.Where(x => x.CodReserva == Reserva.CodReserva).FirstOrDefault();
                    actual.CodCliente = Reserva.CodCliente;
                    actual.CodVehiculo = Reserva.CodVehiculo;
                    actual.FechaReserva = Reserva.FechaReserva;
                    actual.Precio = Reserva.Precio;
                    actual.NroDias = Reserva.NroDias;
                    actual.NroRetraso = Reserva.NroRetraso;

                    data.SaveChanges();
                }

            }
            catch (Exception)
            {

                exito = false;
            }
            return exito;
        }
        static public bool EliminarReserva(Reserva Reserva)
        {
            bool exito = true;
            try
            {
                using (var data = new BDAlquilerVehiculoEntities())
                {
                    Reserva actual = data.Reserva.Where(x => x.CodReserva == Reserva.CodReserva).FirstOrDefault();
                    data.Reserva.Remove(actual);
                    data.SaveChanges();
                }
            }
            catch (Exception)
            {

                exito = false;
            }
            return exito;
        }

        static public List<Cliente> listadoCliente()
        {
            List<Cliente> listado = new List<Cliente>();
            using (var data = new BDAlquilerVehiculoEntities())
            {
                return data.Cliente.ToList();
            }
        }
        static public bool RegistrarCliente(Cliente cliente)
        {
            bool exito = true;
            try
            {
                using (var data = new BDAlquilerVehiculoEntities())
                {
                    data.Cliente.Add(cliente);
                    data.SaveChanges();
                }
            }
            catch
            {

                exito = false;
            }

            return exito;
        }
        static public bool ActualizarCliente(Cliente cliente)
        {
            bool exito = true;
            try
            {
                using (var data = new BDAlquilerVehiculoEntities())
                {
                    Cliente actual = data.Cliente.Where(x => x.CodCliente == cliente.CodCliente).FirstOrDefault();
                    actual.CodCliente = cliente.CodCliente;
                    actual.ApePaterno = cliente.ApePaterno;
                    actual.ApeMaterno = cliente.ApeMaterno;
                    actual.Nombres = cliente.Nombres;
                    actual.FechaNacimiento = cliente.FechaNacimiento;
                    actual.Edad = cliente.Edad;
                    actual.Calle = cliente.Calle;
                    actual.Pais = cliente.Pais;
                    actual.Departamento = cliente.Departamento;
                    actual.Provincia = cliente.Provincia;
                    actual.Distrito = cliente.Distrito;
                    data.SaveChanges();
                }

            }
            catch (Exception)
            {

                exito = false;
            }
            return exito;
        }
        static public bool EliminarCliente(Cliente cliente)
        {
            bool exito = true;
            try
            {
                using (var data = new BDAlquilerVehiculoEntities())
                {
                    Cliente actual = data.Cliente.Where(x => x.CodCliente == cliente.CodCliente).FirstOrDefault();
                    data.Cliente.Remove(actual);
                    data.SaveChanges();
                }
            }
            catch (Exception)
            {

                exito = false;
            }
            return exito;
        }

        static public List<Vehiculo> listadoVehiculo()
        {
            List<Vehiculo> listado = new List<Vehiculo>();
            using (var data = new BDAlquilerVehiculoEntities())
            {
                return data.Vehiculo.ToList();
            }
        }
        static public bool RegistrarVehiculo(Vehiculo vehiculo)
        {
            bool exito = true;
            try
            {
                using (var data = new BDAlquilerVehiculoEntities())
                {
                    data.Vehiculo.Add(vehiculo);
                    data.SaveChanges();
                }
            }
            catch
            {

                exito = false;
            }

            return exito;
        }
        static public bool ActualizarVehiculo(Vehiculo vehiculo)
        {
            bool exito = true;
            try
            {
                using (var data = new BDAlquilerVehiculoEntities())
                {
                    Vehiculo actual = data.Vehiculo.Where(x => x.CodVehiculo == vehiculo.CodVehiculo).FirstOrDefault();
                    actual.CodVehiculo = vehiculo.CodVehiculo;
                    actual.Descripcion = vehiculo.Descripcion;
                    actual.Placa = vehiculo.Placa;
                    actual.Color = vehiculo.Color;
                    actual.CodModelo = vehiculo.CodModelo;
                    actual.Disponible = vehiculo.Disponible;
                    data.SaveChanges();
                }

            }
            catch (Exception)
            {

                exito = false;
            }
            return exito;
        }
        static public bool EliminarVehiculo(Vehiculo vehiculo)
        {
            bool exito = true;
            try
            {
                using (var data = new BDAlquilerVehiculoEntities())
                {
                    Vehiculo actual = data.Vehiculo.Where(x => x.CodVehiculo == vehiculo.CodVehiculo).FirstOrDefault();
                    data.Vehiculo.Remove(actual);
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
