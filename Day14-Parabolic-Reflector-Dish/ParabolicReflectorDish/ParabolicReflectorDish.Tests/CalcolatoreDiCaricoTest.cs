namespace ParabolicReflectorDish.Tests
{
    public class CalcolatoreDiCaricoTest
    {
        [Test(Description = "Il calcolo del carico di una configurazione con una roccia tonda in riga 1 e una roccia tonda in riga 2 è 19")]
        public void TestCalcoloPeso19ConRocciaRiga1E2()
        {
            CalcolatoreDelCarico calcolatore = new ();
            string rocksConfiguration =
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

            Assert.That(calcolatore.CalcolaCarico(rocksConfiguration), Is.EqualTo(19));

        }
    }
}