using Android.App;
using Android.Runtime;

namespace tic_tac_toe_complex;

[Application]
public class MainApplication : MauiApplication
{
	public MainApplication(IntPtr handle, JniHandleOwnership ownership)
		: base(handle, ownership)
	{
	}

	protected override MauiApp CreateMauiApp() => MainProgram.CreateMauiApp();
}
