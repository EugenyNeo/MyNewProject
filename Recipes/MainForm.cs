using System;
using System.Linq;
using System.Windows.Forms;
using RecipesDataUnit;
using ResipesEntities.Code;

namespace Recipes
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Add recept in Data base
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Add_Dish_Click(object sender, EventArgs e)
        {
            Dish dish = new Dish();
            Recipe recipe = new Recipe();
            Product product = new Product();

            if (textNameDish.Text.Length != 0 && textRecept.Text.Length != 0 && textBox_NameProd.Text.Length != 0)
            {
                dish.Name = textNameDish.Text;
                recipe.TextRecipe = textRecept.Text;
                product.Name = textBox_NameProd.Text;

                int tryCount = new int();
                if (int.TryParse(textBox_countPRod.Text, out tryCount))
                    product.Count = tryCount;
                else return;

                if (textBox_Dimensh.Text.Length == 0)
                    return;

                product.Dimension = textBox_Dimensh.Text;

                recipe.Products = product;
                dish.Recipe = recipe;
                Unit.DishesRepository.AddItem(dish);
            }
        }
        /// <summary>
        /// Show list is recepts
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_ShowList_Click(object sender, EventArgs e)
        {
            listBox_ListDishs.Items.Clear();
            foreach (var item in Unit.DishesRepository.AllItems.ToList())
            {
                listBox_ListDishs.Items.Add(item.Name);
            }
            listBox_ListDishs.Show();
        }

        /// <summary>
        /// Show selected recept info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_ShowRecept_Click(object sender, EventArgs e)
        {
            string search = (string)listBox_ListDishs.SelectedItem;
            if (search != null)
            {
                foreach (var item in Unit.DishesRepository.AllItems.ToList())
                {
                    if (item.Name.CompareTo(search) == 0)
                    {
                        textBox_ReceptShow.Text = item.Recipe.TextRecipe;
                        return;
                    }
                }
            }
        }

        /// <summary>
        /// Clean
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            textNameDish.Clear();
            textRecept.Clear();
            textBox_ReceptShow.Clear();
            textBox_countPRod.Clear();
            textBox_Dimensh.Clear();
            textBox_NameProd.Clear();
            listBox_ListDishs.Items.Clear();
        }

        /// <summary>
        /// Remove dish from Data base
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Remove_Click(object sender, EventArgs e)
        {
            string search = (string)listBox_ListDishs.SelectedItem;
            Dish dish = new Dish();

            try
            {
                foreach (var item in Unit.DishesRepository.AllItems.ToList())
                {
                    if (item.Name.CompareTo(search) == 0)
                    {
                        dish = item;
                        break;
                    }
                }

                Unit.ProductsRepository.DeleteItem(dish.Recipe.Products.Id);
                Unit.RecipesRepository.DeleteItem(dish.Recipe.Id);
                Unit.DishesRepository.DeleteItem(dish.Id);

            }
            catch (Exception ee)
            {
                textBox_ReceptShow.Text = ee.Message;
            }
            finally
            {
                Unit.ProductsRepository.SaveChanges();
                Btn_ShowList_Click(sender, e);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
