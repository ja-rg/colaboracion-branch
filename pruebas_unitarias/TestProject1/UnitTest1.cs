namespace pruebas_unitarias
{
    public class Tests
    {
        private Funciones funciones { get; set; } = null!;
        [SetUp]
        public void Setup()
        {
            funciones = new Funciones();
        }

        [Test]
        public void EsPar()
        {
            int a = 10, b = 21;
            Assert.Multiple(() =>
            {
                Assert.That(Funciones.EsPar(a), Is.True);
                Assert.That(Funciones.EsPar(b), Is.False);
            });
        }
    }
}