using App.Client.CarReantalService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Client
{
	public partial class Form1 : Form
	{
		private readonly CarRentalServiceClient carRentalServiceClient;
		public Form1()
		{
			InitializeComponent();
			 carRentalServiceClient = new CarRentalServiceClient("BasicHttpBinding_ICarRentalService");
			carRentalServiceClient.Open();
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			var car = new CarModel();
			car.Avaliable = checkBoxAvaliable.Checked;
			car.Brand = TboxBrand.Text ;
			car.Model = TboxModel.Text;
			car.Year = int.Parse(TboxYear.Text);
			car.RegistrationNumber = TboxRegistrationNumber.Text;
			carRentalServiceClient.AddCar(car);
		}
	}
}
