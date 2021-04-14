using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace MathServiceTP1
{
    /// <summary>
    /// Description résumée de MathService
    /// </summary>
    [WebService(Namespace = "http://localhost/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
    // [System.Web.Script.Services.ScriptService]
    public class MathService : System.Web.Services.WebService
    {

        [WebMethod]
        public float Add(float a, float b)
        {
            return (a + b);
        }

        [WebMethod]
        public float Subtract(float A, float B)
        {
            return (A - B);
        }

        [WebMethod]
        public float Multiply(float A, float B)
        {
            return A * B;
        }

        [WebMethod]
        public float Divide(float A, float B)
        {
            if (B == 0) return -1;
            return (A / B);
        }
    }
}
