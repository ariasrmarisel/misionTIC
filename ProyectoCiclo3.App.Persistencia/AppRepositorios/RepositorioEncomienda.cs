using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioEncomienda
    {
        List<Encomienda> encomiendas;
        private readonly AppContext _appContext = new AppContext(); 
 
 
        public IEnumerable<Encomienda> GetAll()
        {
            return _appContext.Encomiendas;
        }
 
        public Encomienda GetEncomiendaWithId(int id){
            return _appContext.Encomiendas.Find(id);
            // return encomiendas.SingleOrDefault(b => b.id == id);
        }

        public Encomienda Create(Encomienda newEncomienda)
        {
            var addUsuario=_appContext.Encomiendas.Add(newEncomienda);
            _appContext.SaveChanges();
            return addUsuario.Entity;
        }
        //    if(encomiendas.Count > 0){
        //    newEncomienda.id=encomiendas.Max(r => r.id) +1; 
        //     }else{
        //        newEncomienda.id = 1; 
        //     }
        //    encomiendas.Add(newEncomienda);
        //    return newEncomienda;
        

        public Encomienda Update(Encomienda newEncomienda){
            var encomi = _appContext.Encomiendas.Find(newEncomienda.id);

            if(encomi != null){
                encomi.descripcion = newEncomienda.descripcion;
                encomi.peso = newEncomienda.peso;
                encomi.tipo = newEncomienda.tipo;
                encomi.presentacion = newEncomienda.presentacion;
                //Guardar en base de datos
                 _appContext.SaveChanges();
            }
            return encomi;
        }

        public void Delete(int id)
        {
        var encomi = _appContext.Encomiendas.Find(id);
        if (encomi == null)
            return;
        _appContext.Encomiendas.Remove(encomi);
        _appContext.SaveChanges();
        }



    }
}