using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class InAdmin
    {
        private IService service;

        public InAdmin()
        {
            service=new KorisnickiServis();
        }

        ~InAdmin() { }

        public void Check()
        {
            CheckAdmin();
        }

        public void CheckAdmin() {
            var admin = new Admin();
            admin.Username = "admin";
            admin.Password = "admin";

        }

    }
}
