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
                Assert.IsTrue(Funciones.EsPar(a));
            }
            else
            {
                Assert.IsFalse(Funciones.EsPar(a));
            }
            Assert.Pass();
        }
    }
}