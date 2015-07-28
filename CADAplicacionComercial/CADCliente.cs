using CADAplicacionComercial.DSAplicacionComercialTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADAplicacionComercial
{
    public class CADCliente
    {
        private static ClienteTableAdapter adaptador = new ClienteTableAdapter();

        public static DSAplicacionComercial.ClienteDataTable GetData()
        {
            return adaptador.GetData();
        }

        public static void InsertCliente(int IDTipoDocumento, string Documento, string NombreComercial, string NombresContacto,
                                    string ApellidosContacto, string Direccion, string Telefono1, string Telefono2, string Correo,
                                    string Notas, DateTime Aniversario)
        {
            adaptador.InsertCliente(IDTipoDocumento, Documento, NombreComercial, NombresContacto,
                                    ApellidosContacto, Direccion, Telefono1, Telefono2, Correo,
                                    Notas, Aniversario);
        }

        public static void UpdateCliente(int IDTipoDocumento, string Documento, string NombreComercial, string NombresContacto, 
                                    string ApellidosContacto, string Direccion, string Telefono1, string Telefono2, string Correo,
                                    string Notas, DateTime Aniversario, int IDCliente)
        {
            adaptador.UpdateCliente(IDTipoDocumento, Documento, NombreComercial, NombresContacto, 
                                    ApellidosContacto, Direccion, Telefono1, Telefono2, Correo,
                                    Notas, Aniversario, IDCliente);
        }

        public static void DeleteCliente(int IDCliente)
        {
            adaptador.DeleteCliente(IDCliente);
        }
    }
}
