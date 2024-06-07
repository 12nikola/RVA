using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    [ServiceContract]
    public interface IContract
    {
        [OperationContract]
        Admin LogInAdmin(LogInKorisnik korisnik);

        [OperationContract]
        Gledalac LogInGledalac(LogInKorisnik korisnik);

        [OperationContract]
        void LogOut(string username);

        [OperationContract]
        string CreateAdmin(Admin admin);

        [OperationContract]
        string CreateGledalac(Gledalac gledalac);

        [OperationContract]
        List<Admin> GetAllAdmins();

        [OperationContract]
        List<Gledalac> GetGledalac();

        [OperationContract]
        string DeleteAdmin(Admin admin);

        [OperationContract]
        string DeleteGledalac(Gledalac gledalac);

        [OperationContract]
        string ChangeAdmin(Admin admin);

        [OperationContract]
        string ChangeGledalac(Gledalac gledalac);

        [OperationContract]
        string AddKartaAdmin(Admin admin, Karta karta);

        [OperationContract]
        string AddKartaGledalac(Gledalac gledalac, Karta karta);

        [OperationContract]
        string DeleteKartaAdmin(int adminID,  Karta karta);

        [OperationContract]
        string DeleteKartaGledalac(int gledalacID, Karta karta);

        [OperationContract]
        List<Karta> GetKarteAdmin(Admin admin);

        [OperationContract]
        List<Karta> GetKarteGledalac(Gledalac gledalac);

        [OperationContract]
        string Undo();

        [OperationContract]
        string Redo();

        [OperationContract]
        string ChangeKorisnikAdmin(Admin admin);

        [OperationContract]
        string ChangeKorisnikGledalac(Gledalac gledalac);

        [OperationContract]
        string SearchUser(string type, string input);
    }
}
