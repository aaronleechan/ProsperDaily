using MauiApp1;

namespace ProsperDaily;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new DashboardPage();
		//MainPage = new TransactionsPage();
		//MainPage = new StatisticsPage();
	}
}
