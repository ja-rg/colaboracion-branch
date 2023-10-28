using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Config;
using static System.Net.Mime.MediaTypeNames;

namespace pruebas_unitarias
{
    public class Funciones
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Funciones));
        public void Setup()
        {
            XmlConfigurator.Configure(new FileInfo("log4net-config.xml"));
        }
        public static bool EsPar(int num)
        {
            if ((num % 2) == 0)
                return true;
            else
                return false;
        }
        public static bool EsDivisibleEntre3(int num)
        {
            log.Debug("Usa la operacion de modulo para comprobar si es divisible entre 3");
            return (num % 3) == 0;
        }

        public static int DivisionDosNumeros(int a, int b)
        {
            int res;
            try
            {
                res = a / b;
            }catch(DivideByZeroException)
            {
                log.Fatal("Se intentó una división entre 0");
                return 0;
            }
            if(a % b != 0)
            {
                log.Warn("El resultado quedó redondeado");
            }
            return (a / b);
        }

        public static bool EsDivisibleEntre4(int num)
        {
            if (num == 0)
            { log.Fatal("No se le puede aplicar una diviciona un 0");
                return false;
            }
            else
            {
                if (num % 4 == 0)
                {
                    log.Info("El numero es divisible entre 4");
                    return (num % 4) == 0;
                }
                else
                {
                    log.Warn("El numero no es divisible entre 4");
                    return false;
                }
            }

           
        }
        public static bool EsDivisibleEntre5(int num)
        {
            if (num == 0)
            {
                log.Fatal("No se le puede aplicar una diviciona un 0");
                return false;
            }
            else
            {
                if (num % 5 == 0)
                {
                    log.Info("El numero es divisible entre 5");
                    return (num % 5) == 0;
                }
                else
                {
                    log.Warn("El numero no es divisible entre 5");
                    return false;
                }
            }
        }

    }
}
