using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace BILD.Controllers
{
    [Authorize]
    public class GetformsController : ApiController
    {
        // GET: api/Getforms
        public string Get()
        {
            List<Forms> formList = new List<Forms>();
            List<Inputs> inputList = new List<Inputs>();
            Inputs nombre = new Inputs();
            Inputs email = new Inputs();
            Inputs comenta = new Inputs();
            Forms form = new Forms();
            Msg msg = new Msg();
            Respuesta resp = new Respuesta();

            nombre.name = "nombre";
            nombre.type = "text";
            nombre.required = true;

            email.name = "Email";
            email.type = "email";
            email.required = true;

            comenta = nombre;
            comenta.name = "Comentario";

            inputList.Add(nombre);
            inputList.Add(email);
            inputList.Add(comenta);

            form.name = "formulario comentario";
            form.inputs = inputList.ToArray();

            formList.Add(form);

            msg.forms = formList.ToArray();

            resp.error = "";
            resp.status = 200;
            resp.msg = msg;

            var serialized = JsonConvert.SerializeObject(resp);
            return serialized; 
        }

        // GET: api/Getforms/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Getforms
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Getforms/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Getforms/5
        public void Delete(int id)
        {
        }
    }

}
