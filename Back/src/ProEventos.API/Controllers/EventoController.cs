using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
       
        public IEnumerable<Evento> _evento =  new Evento[]{
                new Evento(){
                    
                EventoID = 1,
                Tema = "teste",
                Local = "Porto Velho",
                Lote = "1 Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString(),
                ImagemURL= "foto.png"
            },
             new Evento(){
                    
                EventoID = 2,
                Tema = "teste2",
                Local = "Porto Velho",
                Lote = "2 Lote",
                QtdPessoas = 350,
                DataEvento = DateTime.Now.AddDays(4).ToString("dd/MM/yyyy"),
                ImagemURL= "foto2.png"
            }
            };
        public EventoController()
        {
           
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return  _evento;
            
            
            
        }
    }
}
