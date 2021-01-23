using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Drinks_WebForm.BLL;
using Drinks_WebForm.DTO;

namespace Drinks_WebForm
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Drink> drinks = new DrinksBUS().GetAll();
            GridView.DataSource = drinks;
            GridView.DataBind();
        }

        protected void GridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtID.Text=GridView.SelectedRow.Cells[1].Text;
            txtType.Text = GridView.SelectedRow.Cells[2].Text;
            txtName.Text = GridView.SelectedRow.Cells[3].Text;
            txtIngredients.Text = GridView.SelectedRow.Cells[4].Text;
            txtPrice.Text = GridView.SelectedRow.Cells[5].Text;
        }

        protected void bntSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtkeyword.Text.Trim();
            List<Drink> drinks = new DrinksBUS().Search(keyword);
            GridView.DataSource = drinks;
            GridView.DataBind();
        }

       

        void Clear()
        {
            txtID.Text = txtType.Text = txtName.Text = txtIngredients.Text = txtPrice.Text = "";
            btnAdd.Text = "Add";
            btnUpdate.Text = "Update";
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string id = txtID.Text.Trim();
            string type = txtType.Text.Trim();
            string name = txtName.Text.Trim();
            string ingredients = txtIngredients.Text.Trim();
            int price = int.Parse(txtPrice.Text.Trim());
            Drink newdrink = new Drink()
            {
                ID = id,
                Type = type,
                Name = name,
                Ingredients = ingredients,
                Price = price
            };
            bool result = new DrinksBUS().AddNew(newdrink);
            if(result)
            {
                List<Drink> drinks = new DrinksBUS().GetAll();
                GridView.DataSource = drinks;
                GridView.DataBind();
                lbdebug.Text = ("SUCCESS!");
            }
            else
            {
                lbdebug.Text = ("FAIL!");
            }
            Clear();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string id = txtID.Text.Trim();
            string type = txtType.Text.Trim();
            string name = txtName.Text.Trim();
            string ingredients = txtIngredients.Text.Trim();
            int price = int.Parse(txtPrice.Text.Trim());
            Drink newdrinks = new Drink()
            {
                ID = id,
                Type = type,
                Name = name,
                Ingredients = ingredients,
                Price = price
            };
            Clear();
            bool result = new DrinksBUS().Update(newdrinks);
            if (result)
            {
                lbdebug.Text = ("SUCCESS!");
                List<Drink> drinks = new DrinksBUS().GetAll();
                GridView.DataSource = drinks;
                GridView.DataBind();
            }
            else
            {
                lbdebug.Text = ("FAIL!");
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            string id = txtID.Text.Trim();
            Drink newdrinks = new Drink()
            {
                ID = id
            };
            Clear();
            bool result = new DrinksBUS().Delete(id);
            if (result)
            {
                lbdebug.Text = ("SUCCESS!");
                List<Drink> drinks = new DrinksBUS().GetAll();
                GridView.DataSource = drinks;
                GridView.DataBind();
            }
            else
            {
                lbdebug.Text = ("FAIL!");
            }
        }
    }
}