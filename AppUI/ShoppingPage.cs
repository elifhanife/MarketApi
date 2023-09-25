using Entities.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppUI
{
	public partial class ShoppingPage : Form
	{
		public ShoppingPage()
		{
			InitializeComponent();
		}

		private void pictureBoxProductWindow_Click(object sender, EventArgs e)
		{
			MessageBox.Show("You are already in this page",
				"Information",
				MessageBoxButtons.OK,
				MessageBoxIcon.Information);
		}

		private void pictureBoxSignUpWindow_Click(object sender, EventArgs e)
		{
			var result = MessageBox.Show("Are you sure for loging out?",
				"Loging Out",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Warning);

			if (result == DialogResult.Yes)
			{
				new LoginPage().Show();
				this.Hide();
			}
		}

		private void pictureBoxBasketWindow_Click(object sender, EventArgs e)
		{
			new BasketPage().Show();
			this.Hide();
		}

		private void ShoppingPage_Load(object sender, EventArgs e)
		{
			string url = "https://localhost:7248/api/products";
			var client = new RestClient(url);
			var request = new RestRequest();
			var response = client.Get(request);

			var products = JsonConvert.DeserializeObject<IEnumerable<Product>>(response.Content);

			foreach (var item in products)
			{
				if (item.ProductId == 1)
				{
					pictureBoxProduct1.ImageLocation = item.ProductImage;
					lblProductName1.Text = item.ProductName;
					lblPrice1.Text = item.ProductPrice.ToString();
				}
				else if (item.ProductId == 2)
				{
					pictureBoxProduct2.ImageLocation = item.ProductImage;
					lblProductName2.Text = item.ProductName;
					lblPrice2.Text = item.ProductPrice.ToString();
				}
				else if (item.ProductId == 4)
				{
					pictureBoxProduct3.ImageLocation = item.ProductImage;
					lblProductName3.Text = item.ProductName;
					lblPrice3.Text = item.ProductPrice.ToString();
				}
				else if (item.ProductId == 7)
				{
					pictureBoxProduct4.ImageLocation = item.ProductImage;
					lblProductName4.Text = item.ProductName;
					lblPrice4.Text = item.ProductPrice.ToString();
				}
			}
		}

		private void pictureBoxProduct1_Click(object sender, EventArgs e)
		{
			checkBox1.Checked = true;
		}

		private void pictureBoxProduct2_Click(object sender, EventArgs e)
		{
			checkBox2.Checked = true;
		}

		private void pictureBoxProduct3_Click(object sender, EventArgs e)
		{
			checkBox3.Checked = true;
		}

		private void pictureBoxProduct4_Click(object sender, EventArgs e)
		{
			checkBox4.Checked = true;
		}

		private void btnBasket_Click(object sender, EventArgs e)
		{
			string url = "https://localhost:7248/api/orderedproducts";
			var client = new RestClient(url);
			var request = new RestRequest();

			if (checkBox1.Checked)
			{
				var body = new OrderedProduct { CustomerId = 11, ProductId = 1 };
				request.AddJsonBody(body);
				var response = client.Post(request);

				if (response.IsSuccessStatusCode)
				{
					MessageBox.Show("Product is successfully added!",
					"Information",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information);
				}
				checkBox1.Checked = false;
			}
			else if(checkBox2.Checked)
			{
				var body = new OrderedProduct { CustomerId = 11, ProductId = 2 };
				request.AddJsonBody(body);
				var response = client.Post(request);

				if (response.IsSuccessStatusCode)
				{
					MessageBox.Show("Product is successfully added!",
					"Information",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information);
				}
				checkBox2.Checked = false;
			}
			else if (checkBox3.Checked)
			{
				var body = new OrderedProduct { CustomerId = 11, ProductId = 4 };
				request.AddJsonBody(body);
				var response = client.Post(request);

				if (response.IsSuccessStatusCode)
				{
					MessageBox.Show("Product is successfully added!",
					"Information",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information);
				}
				checkBox3.Checked = false;
			}
			else if (checkBox4.Checked)
			{
				var body = new OrderedProduct { CustomerId = 11, ProductId = 7 };
				request.AddJsonBody(body);
				var response = client.Post(request);

				if (response.IsSuccessStatusCode)
				{
					MessageBox.Show("Product is successfully added!",
					"Information",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information);
				}
				checkBox4.Checked = false;
			}
			else
			{
				MessageBox.Show("No products selected!",
					"Warning",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning);
			}
		}
	}
}
