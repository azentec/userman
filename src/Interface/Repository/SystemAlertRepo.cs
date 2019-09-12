using System;

namespace Sampekey.Interface.Repository
{
    public class SystemAlertRepo : ISystemAlert
    {
        public Object GetUnauthorizedMenssageFromActiveDirectory()
        {
            return new
            {
                title = "Error de autenticación",
                message = "No se ha podido autentificar ante el directorio activo. Por favor compruebe si las credenciales son correctas."
            };
        }

        public Object GetUnauthorizedMenssageFromSampeKey()
        {
            return new
            {
                title = "Error de autenticación",
                message = "Su cuenta no esta dada de alta en el sistema. Por favor contacte al administrador para mayor imformación."
            };
        }

        public Object GetUnauthorizedMenssage()
        {
            return new
            {
                title = "Error de autenticación",
                message = "No se ha podido autentificar. Por favor compruebe si las credenciales son correctas."
            };
        }

        public Object GetValidationProblemMenssage()
        {
            return new
            {
                title = "Error de validación de modelo",
                message = "verifique que sencuentren los datos requeridos para el consumo de este servicio."
            };
        }
    }
}