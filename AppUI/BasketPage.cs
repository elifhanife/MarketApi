using Azure;
using Entities.Models;
using Microsoft.AspNetCore.JsonPatch;
using Newtonsoft.Json;
using Repositories.EFCore;
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
	public partial class BasketPage : Form
	{
		public BasketPage()
		{
			InitializeComponent();
		}

		private void BasketPage_Load(object sender, EventArgs e)
		{
			string url = "https://localhost:7248/api/orderedproducts/11";
			var client = new RestClient(url);
			var request = new RestRequest();
			var response = client.Get(request);

			var products = JsonConvert.DeserializeObject<IEnumerable<OrderedProduct>>(response.Content);

			foreach (var item in products)
			{

				if (item.ProductId == 1)
				{
					pictureBoxProduct1.ImageLocation = item.ProductImage;
					lblProductName1.Text = item.ProductName;
					lblUnitPrice1.Text = item.ProductPrice.ToString();
					lblNumberOfProduct1.Text = item.NumberOfProduct.ToString();
					lblProductTotal1.Text = item.BasketTotal.ToString();
				}
				else if (item.ProductId == 2)
				{
					pictureBoxProduct2.ImageLocation = item.ProductImage;
					lblProductName2.Text = item.ProductName;
					lblUnitPrice2.Text = item.ProductPrice.ToString();
					lblNumberOfProduct2.Text = item.NumberOfProduct.ToString();
					lblProductTotal2.Text = item.BasketTotal.ToString();
				}
				else if (item.ProductId == 4)
				{
					pictureBoxProduct3.ImageLocation = item.ProductImage;
					lblProductName3.Text = item.ProductName;
					lblUnitPrice3.Text = item.ProductPrice.ToString();
					lblNumberOfProduct3.Text = item.NumberOfProduct.ToString();
					lblProductTotal3.Text = item.BasketTotal.ToString();
				}
				else if (item.ProductId == 7)
				{
					pictureBoxProduct4.ImageLocation = item.ProductImage;
					lblProductName4.Text = item.ProductName;
					lblUnitPrice4.Text = item.ProductPrice.ToString();
					lblNumberOfProduct4.Text = item.NumberOfProduct.ToString();
					lblProductTotal4.Text = item.BasketTotal.ToString();
				}

				lblProductsTotalValue.Text = item.ProductsTotal.ToString();
				lblShippingFeeValue.Text = item.ShippingFee.ToString();
				lblTotalValue.Text = item.TotalPrice.ToString();
			}
		}

		private void pictureBoxBasketWindow_Click(object sender, EventArgs e)
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

		private void pictureBoxProductWindow_Click(object sender, EventArgs e)
		{
			new ShoppingPage().Show();
			this.Hide();
		}

		private void btnConfirm_Click(object sender, EventArgs e)
		{
			string url = "https://localhost:7248/api/orderedproducts/11";
			var client = new RestClient(url);
			var request = new RestRequest();

			JsonPatchDocument<OrderedProduct> patchDocument = new JsonPatchDocument<OrderedProduct>();
			patchDocument.Replace(o=>o.OrderStatus,true);
			string jsonPatch = JsonConvert.SerializeObject(patchDocument);
			request.AddParameter("application/json-patch+json", jsonPatch, ParameterType.RequestBody);
			var response = client.Patch(request);

			if (response.IsSuccessStatusCode)
			{
				var result = MessageBox.Show("Your order has been confirmed!",
				"Order Confirmation",
				MessageBoxButtons.OK,
				MessageBoxIcon.Information);

				new BasketPage().Show();
				this.Hide();
			}
			else
			{
				var result = MessageBox.Show("Order could not be created!",
				"Order Create Error",
				MessageBoxButtons.OK,
				MessageBoxIcon.Error);
			}

		}
	}
}
