using Entities.Models;
using RestSharp;
using System.Security.Policy;
using System.Text;

namespace AppUI
{
	public partial class LoginPage : Form
	{
		public LoginPage()
		{
			InitializeComponent();
		}
		private async void btnLogin_Click(object sender, EventArgs e)
		{
			string url = "https://localhost:7248/api/customers";
			var client = new RestClient(url);
			var request = new RestRequest();
			var body = new Customer
			{
				CustomerName = txtUserName.Text,
				CustomerSurname = txtSurname.Text,
				CustomerPhoneNumber = txtPhoneNumber.Text,
				CustomerAddress = txtAddress.Text,
				CustomerPassword = txtPassword.Text,
				CustomerStatus = true
			};
			request.AddJsonBody(body);

			try
			{
				var response = client.Post(request);

				if (response.IsSuccessStatusCode)
				{
					MessageBox.Show("Your account is successfully created!",
					"Information",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information);

					new ShoppingPage().Show();
					this.Hide();
				}
			}
			catch (HttpRequestException ex)
			{
				MessageBox.Show("This user already exists! Change phone number or password");
				txtPhoneNumber.Clear();
				txtPassword.Clear();
			};
		}

		private void label2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void pictureBoxProductWindow_Click(object sender, EventArgs e)
		{
			new ShoppingPage().Show();
			this.Hide();
		}

		private void pictureBoxSignUpWindow_Click(object sender, EventArgs e)
		{
			MessageBox.Show("You are already in this page",
				"Information",
				MessageBoxButtons.OK,
				MessageBoxIcon.Information);
		}

		private void pictureBoxBasketWindow_Click(object sender, EventArgs e)
		{
			new BasketPage().Show();
			this.Hide();
		}
	}
}