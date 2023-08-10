
namespace tic_tac_toe_complex;

public partial class MainPage : ContentPage
{
    public Grid biggrid { get; set; }

    public MainPage()
	{
		InitializeComponent();

		Wenumechinsama();
	}
	private void Wenumechinsama()
	{
		biggrid = weee.CGrid(3, 3);

        foreach (var child in biggrid.Children)
        {
            if (child is Button button)
            {
               button.Clicked += GridButton_Click;
            }
        }

        gri.Children.Add(biggrid);


	}
    private void GridButton_Click(object sender, EventArgs e)
    {
        Button clickedbutton = (Button)sender;
      
        
        ImageSource imagesource = new FileImageSource { File = "../Resources/Images/black_x.jpg" };
        clickedbutton.ImageSource = imagesource;     
    }	
}

