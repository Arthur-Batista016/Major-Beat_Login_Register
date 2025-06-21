using MajorBeat.ViewModels;

namespace MajorBeat.Views;

public partial class HirerRegisterPage : ContentPage
{
	UsuarioViewModel viewModel;
	public HirerRegisterPage()
	{
		InitializeComponent();

		viewModel = new UsuarioViewModel();
		BindingContext = viewModel;


	}
}