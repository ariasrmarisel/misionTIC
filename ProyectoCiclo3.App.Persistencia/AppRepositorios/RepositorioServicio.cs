using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioServicio
    {
        List<Servicio> servicios;
        private readonly AppContext _appContext = new AppContext(); 
 
 
        public IEnumerable<Servicio> GetAll()
        {
            return _appContext.Servicios;
        }
 
        public Servicio GetServicioWithId(int id){
            return _appContext.Servicios.Find(id);
            // return usuarios.SingleOrDefault(b => b.id == id);
        }

        public Servicio Create(Servicio newServicio)
        {
            var addServicio=_appContext.Servicios.Add(newServicio);
            _appContext.SaveChanges();
            return addServicio.Entity;
        }
        //    if(usuarios.Count > 0){
        //    newUsuario.id=usuarios.Max(r => r.id) +1; 
        //     }else{
        //        newUsuario.id = 1; 
        //     }
        //    usuarios.Add(newUsuario);
        //    return newUsuario;
        

        public Servicio Update(Servicio newServicio){
            var service = _appContext.Servicios.Find(newServicio.id);

            if(service != null){
                service.origen = newServicio.origen;
                service.destino = newServicio.destino;
                service.fecha = newServicio.fecha;
                service.hora = newServicio.hora;
                service.encomienda = newServicio.encomienda;
                //Guardar en base de datos
                 _appContext.SaveChanges();
            }
            return service;
        }

        public void Delete(int id)
        {
        var service = _appContext.Servicios.Find(id);
        if (service == null)
            return;
        _appContext.Servicios.Remove(service);
        _appContext.SaveChanges();
        }



    }
}
