using System.Text;

namespace ParabolicReflectorDish.Tests
{
    public class DishTests
    {
        private StringWriter outputStream = null!;

        [SetUp]
        public void Setup()
        {
            outputStream = GetOutputStream();
        }

        [TearDown]
        public void TearDown()
        {
            outputStream.Dispose();
        }

        [Test(Description = "Se creo un disco vuoto, ho un disco a carico 0")]
        public void DiscoVuoto()
        {
            var dish = new Dish();
            
            Assert.That(dish.TotalLoad == 0);
        }

        [Test(Description = "Se creo un disco vuoto e ne mostro la configurazione, avrò una matrice 10x10 di soli '.'")]
        public void MostraConfigurazioneVuota() {
            var expectedConfiguration = EmptyConfiguration();


            var dish = new Dish();
            dish.ShowConfiguration();
            Assert.That(outputStream.ToString(), Is.EqualTo(expectedConfiguration));
        }

        private string EmptyConfiguration()
        {
            var puntini = "..........";
            var newLine = Environment.NewLine;
            var expectedConfiguration = "";

            for (int i = 0; i < 9; i++)
            {
                expectedConfiguration += $"{puntini}{newLine}";
            }
            expectedConfiguration += $"{puntini}";
            return expectedConfiguration;
        }

        private StringWriter GetOutputStream()
        {
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            return stringWriter;
        }
    }
    


    public class Dish
    {
        public int TotalLoad => 0;

        public void ShowConfiguration()
        {
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine("..........");
            }
            Console.Write("..........");
        }
    }
}