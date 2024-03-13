using System.Security.Cryptography.X509Certificates;

namespace ParabolicReflectorDish.Tests
{
    public class DishTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test(Description = "Se creo un disco vuoto, ho un disco a carico 0")]
        public void DiscoVuoto()
        {
            var dish = new Dish();
            
            Assert.That(dish.TotalLoad == 0);
        }
    }
}