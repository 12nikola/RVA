using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Model
{
    public class Action
    {
        private string vremeIzmene;
        private string message;

        public Action(string vremeIzmene, string message)
        {
            this.vremeIzmene = vremeIzmene;
            this.message = message;
        }

        public string VremeIzmene { get => vremeIzmene; set => vremeIzmene = value; }
        public string Message { get => message; set => message = value; }
    }
}
