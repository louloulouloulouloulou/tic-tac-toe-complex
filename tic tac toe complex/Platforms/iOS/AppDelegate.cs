using Foundation;

namespace tic_tac_toe_complex;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
	protected override MauiApp CreateMauiApp() => MainProgram.CreateMauiApp();
}
