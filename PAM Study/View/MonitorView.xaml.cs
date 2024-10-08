namespace PAM_Study.View;

public partial class MonitorView : ContentPage
{
	public MonitorView()
	{
		InitializeComponent();
		BindingContext = new ViewModels(this);
	}
}