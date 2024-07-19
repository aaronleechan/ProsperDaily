using ProsperDaily.MVVM.Views;

namespace ProsperDaily;

public partial class DashboardPage : ContentPage
{
	public DashboardPage()
	{
		InitializeComponent();
		BindingContext = new DashboardViewModel();
	}

	public async void AddTransaction_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new TransactionsPage());
	}

	protected override void OnAppearing()
	{
		base.OnAppearing();
		var vm = (DashboardViewModel)BindingContext;
		vm.FillData();
	}
}