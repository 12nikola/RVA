using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [ServiceContract]
    public interface ICommon
    {
        [OperationContract]
        void LogOut(string username);

        [OperationContract]
        Admin FindAdmin(LogInKorisnik korisnik);

        [OperationContract]
        Gledalac FindGledalac(LogInKorisnik korisnik);

        [OperationContract]
        Biletarnica FindBiletarnica(Biletarnica biletarnica);

        [OperationContract]
        string AddAdmin(Admin admin);

        [OperationContract]
        string AddGledalac(Gledalac gledalac);

        [OperationContract]
        string AddBiletarnica(Biletarnica biletarnica);

        [OperationContract]
        List<Admin> GetAdmins();
        [OperationContract]
        List<Korisnik> GetKorisniks();

        [OperationContract]
        List<Gledalac> GetGledalacs();

        [OperationContract]
        List<Biletarnica> GetBiletarnica();

        [OperationContract]
        string ChangeAdmin(Admin admin);

        [OperationContract]
        string ChangeGledalac(Gledalac gledalac);

        [OperationContract]
        string ChangeBiletarnica(Biletarnica biletarnica);

        [OperationContract]
        string DeleteAdmin(Admin admin);

        [OperationContract]
        string DeleteGledalac(Gledalac gledalac);

        [OperationContract]

        string DeleteBiletarnica(Biletarnica biletarnica);
        [OperationContract]
        string Redo();
        [OperationContract]
        string Undo();

        [OperationContract]
        string searhKorisnik(string type, string input);

        [OperationContract]
        Admin LogInAdmin(LogInKorisnik korisnik);
        [OperationContract]
        Gledalac LogInGledalac(LogInKorisnik korisnik);
    }
}
