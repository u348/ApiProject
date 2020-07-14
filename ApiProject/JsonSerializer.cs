using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ApiProject
{
    public class JsonSerializer
    {
        public string SerializeJson(string description, string number)
        {
            var sTO = new DTO(description, number);

            var jsonObject = JsonConvert.SerializeObject(sTO);

            return jsonObject;
           
        }
    }
}
