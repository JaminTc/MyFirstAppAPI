using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFirstApp.API.ServiceModel.Dtos;
using ServiceStack;

namespace MyFirstApp.API.ServiceModel.Messages
{    [Route("/Person/{PersonId}",
        Verbs = "GET",
        Summary = "First Api lets hook up",
        Notes ="Connects to UI")]
    public class ReadPerson
    {
        public int PersonId { get; set; }
    }
}
