using collection.MVVM.ViewModels;

namespace collection.MVVM.View;

public partial class DataView : ContentPage
{
	public DataView()
	{
		InitializeComponent();
		BindingContext = new ViewModel();
	}
}