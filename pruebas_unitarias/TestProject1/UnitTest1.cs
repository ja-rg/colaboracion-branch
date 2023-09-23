namespace pruebas_unitarias
{
    public class Tests
    {
        Funciones funciones;
        [SetUp]
        public void Setup()
        {
            funciones = new Funciones();
        }

        [Test]
        public void EsPar()
        {
            int a = 10;
            bool resultadoEsperado = true;
            if (resultadoEsperado)
            {
                Assert.IsTrue(funciones.esPar(a));
            }
            else
            {
                Assert.IsFalse(funciones.esPar(a));
            }
            Assert.Pass();
        }
    }
}