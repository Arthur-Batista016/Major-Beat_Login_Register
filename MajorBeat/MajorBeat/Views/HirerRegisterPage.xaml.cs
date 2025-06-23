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

    
    private async void voltar_Clicked_1(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new InitialPage());
    }

   
}