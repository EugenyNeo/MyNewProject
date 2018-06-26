using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecipesDataUnit;
using ResipesEntities.Code;
using System.Linq;

namespace Recept.Tests
{
    [TestClass]
    public class ReceptTest
    {
        [TestMethod]
        public void AddDishTest()
        {
            DeleteAllDishReceptProductTest();

            for (int i = 0; i < 10; ++i)
            {
                Unit.DishesRepository.AddItem(new Dish());
            }

            var list = Unit.DishesRepository.AllItems.ToList();
            Assert.AreEqual(10, list.Count);
        }

        [TestMethod]
        public void AddDishReceptPoductTest()
        {
            DeleteAllDishReceptProductTest();

            Dish d = new Dish();
            d.Recipe = new Receipt();
            d.Recipe.Products = new Product();

            var list = Unit.DishesRepository.AllItems.ToList();

            for (int i = list.Count; i < 10; ++i)
            {
                Unit.DishesRepository.AddItem(d);
            }

            list = Unit.DishesRepository.AllItems.ToList();
            Assert.AreEqual(10, list.Count);
        }

        [TestMethod]
        public void DeleteAllDishReceptProductTest()
        {
            var list_P = Unit.ProductsRepository.AllItems.ToList();
            for (int i = 0; i < list_P.Count; ++i)
                Unit.ProductsRepository.DeleteItem(list_P[i].Id);

            var list_R = Unit.RecipesRepository.AllItems.ToList();
            for (int i = 0; i < list_R.Count; ++i)
                Unit.RecipesRepository.DeleteItem(list_R[i].Id);

            var list_D = Unit.DishesRepository.AllItems.ToList();
            for (int i = 0; i < list_D.Count; ++i)
            {
                Unit.DishesRepository.DeleteItem(list_D[i].Id);
            }

            list_P = Unit.ProductsRepository.AllItems.ToList();
            list_R = Unit.RecipesRepository.AllItems.ToList();
            list_D = Unit.DishesRepository.AllItems.ToList();

            Assert.AreEqual(0, list_P.Count);
            Assert.AreEqual(0, list_R.Count);
            Assert.AreEqual(0, list_D.Count);
        }

        [TestMethod]
        public void DeleteAllDishTest()
        {
            var list = Unit.DishesRepository.AllItems.ToList();

            for (int i = 0; i < list.Count; ++i)
            {
                Unit.DishesRepository.DeleteItem(list[i].Id);
            }

            list = Unit.DishesRepository.AllItems.ToList();
            Assert.AreEqual(0, list.Count);
        }

        [TestMethod]
        public void DeleteAllReceptTest()
        {
            var list = Unit.RecipesRepository.AllItems.ToList();

            for (int i = 0; i < list.Count; ++i)
            {
                Unit.RecipesRepository.DeleteItem(list[i].Id);
            }

            list = Unit.RecipesRepository.AllItems.ToList();
            Assert.AreEqual(0, list.Count);
        }

        [TestMethod]
        public void DeleteAllProductTest()
        {
            var list = Unit.ProductsRepository.AllItems.ToList();

            for (int i = 0; i < list.Count; ++i)
            {
                Unit.ProductsRepository.DeleteItem(list[i].Id);
            }

            list = Unit.ProductsRepository.AllItems.ToList();
            Assert.AreEqual(0, list.Count);
        }
    }
}
