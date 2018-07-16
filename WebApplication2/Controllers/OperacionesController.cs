using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication2.DTO;

namespace WebApplication2.Controllers
{
    public class OperacionesController : ApiController
    {
        // GET api/values/5
        public OperacionesDTO Get(int a, int b)
        {
            return new OperacionesDTO()
            {
                Resultado = Convert.ToString(a + b)
            };    
        }
    }
}
// Va a tener un metodo que se llame "Sumar"
// Va a devolver un objeto de tipo "Suma" con parametros (a, b) 
// Va a retornar un nuevo objeto Suma que va a tener una propiedad llamada resultados de tipo int publica
// En resultado vamos a almacenar la suma de a y b y eso es lo que va a retornar el objeto suma en la api
// Esto tiene que devolver un json con un solo atributo, resultados, que tenga la suma de a y b
