using log4net;
using log4net.Config;

namespace pruebas_unitarias
{
    public class Tests
    {
        private Funciones Funciones { get; set; } = null!;
        private static readonly ILog log = LogManager.GetLogger(typeof(Tests));

        [SetUp]
        public void Setup()
        {
            XmlConfigurator.Configure(new FileInfo("log4net-config.xml"));
            Funciones = new Funciones();
            log.Info("Inicialización de las pruebas.");
        }

        [Test]
        public void EsPar()
        {
            int a = 10, b = 21;

            log.Info("Iniciando prueba EsPar.");

            Assert.Multiple(() =>
            {
                Assert.That(Funciones.EsPar(a), Is.True);
                Assert.That(Funciones.EsPar(b), Is.False);
            });

            log.Info("Finalizando prueba EsPar.");
        }

        [Test]
        public void EsDivisibleEntre3()
        {
            int a = 10, b = 21;

            log.Info("Iniciando prueba EsDivisibleEntre3.");

            Assert.Multiple(() =>
            {
                Assert.That(Funciones.EsDivisibleEntre3(a), Is.False);
                Assert.That(Funciones.EsDivisibleEntre3(b), Is.True);
            });

            log.Info("Finalizando prueba EsDivisibleEntre3.");
        }

        [Test]
        public void EsDivisibleEntre4()
        {
            int a = 12, b = 21;

            log.Info("Iniciando prueba EsDivisibleEntre4.");

            Assert.Multiple(() =>
            {
                Assert.That(Funciones.EsDivisibleEntre4(a), Is.True);
                Assert.That(Funciones.EsDivisibleEntre4(b), Is.False);
            });

            log.Info("Finalizando prueba EsDivisibleEntre4.");
        }

        [Test]
        public void EsDivisibleEntre5()
        {
            int a = 10, b = 21;

            log.Info("Iniciando prueba EsDivisibleEntre5.");

            Assert.Multiple(() =>
            {
                Assert.That(Funciones.EsDivisibleEntre5(a), Is.True);
                Assert.That(Funciones.EsDivisibleEntre5(b), Is.False);
            });

            log.Info("Finalizando prueba EsDivisibleEntre5.");
        }

        [Test]
        public void Division2Numeros()
        {
            int a = 10, b = 5, c = 14, d = 0;
            Assert.Multiple(() =>
            {
                Assert.That(Funciones.DivisionDosNumeros(a, b), Is.EqualTo(2));
                Assert.That(Funciones.DivisionDosNumeros(c, b), Is.EqualTo(2));
                Assert.That(Funciones.DivisionDosNumeros(a, d), Is.EqualTo(0));
            });
        }
    }
}
