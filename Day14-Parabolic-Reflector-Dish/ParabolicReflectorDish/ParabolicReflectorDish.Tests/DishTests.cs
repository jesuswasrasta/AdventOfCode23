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

        [Test(Description = "Posso creare un disco con una configurazione iniziale a scelta")]
        public void ConfigurazioneInizialeCustom() {
            var expectedConfiguration =
                "...O......" + Environment.NewLine +
                "....O....." + Environment.NewLine +
                ".....#...." + Environment.NewLine +
                ".........." + Environment.NewLine +
                ".........." + Environment.NewLine +
                ".........." + Environment.NewLine +
                ".........." + Environment.NewLine +
                ".........." + Environment.NewLine +
                ".........." + Environment.NewLine +
                "..........";


            var dish = new Dish(expectedConfiguration);
            dish.ShowConfiguration();
            Assert.That(outputStream.ToString(), Is.EqualTo(expectedConfiguration));
        }

        [Test(Description = "Il carico di una configurazione con una roccia tonda in riga 1 e una roccia tonda in riga 2 è 19")]
        public void Carico19ConRocciaRiga1e2()
        {
            var initialConfiguration =
                "...O......" + Environment.NewLine +
                "....O....." + Environment.NewLine +
                ".....#...." + Environment.NewLine +
                ".........." + Environment.NewLine +
                ".........." + Environment.NewLine +
                ".........." + Environment.NewLine +
                ".........." + Environment.NewLine +
                ".........." + Environment.NewLine +
                ".........." + Environment.NewLine +
                "..........";


            var dish = new Dish(initialConfiguration);
            Assert.That(dish.TotalLoad, Is.EqualTo(19));
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
        private string rocksConfiguration;

        public Dish() : this(EmptyConfiguration()) { }

        private static string EmptyConfiguration()
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

        public Dish(string initialRocksConfiguration)
        {
            rocksConfiguration = initialRocksConfiguration;
        }

        public int TotalLoad => 0;

        public void ShowConfiguration()
        {
            Console.Write(rocksConfiguration);
        }

    }
}