using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tic_tac_toe_complex
{
    public static class Gamein
    {
        public static Grid biggrid { get; set; }
        public static Button[,] buttons { get; set; }

        public static bool GameOver;
        public static bool TryAgain;
        public static ImageSource o = new FileImageSource { File = "../Resources/Images/o_image.png" };
        public static ImageSource x = new FileImageSource { File = "../Resources/Images/um.png" };
        public static ImageSource image;
        public static void InitGame(Layout gri)
        {
            buttons = new Button[3, 3];
            biggrid = weee.CGrid(3, 3);
            Other.Wenumechinsama(gri, biggrid);
            Other.Array(biggrid, buttons);
        }
        public static async void GridButton_Click(object sender, EventArgs e)
        {
            Button clickedbutton = (Button)sender;

              
            image = (image == x) ? o : x;
            string nameofthing;
            if (image == x)
            {
                nameofthing = "X";
            }
            else
            {
                nameofthing = "O";
            }

            if (clickedbutton.ImageSource == null)
            {
                clickedbutton.ImageSource = image;
                int row = biggrid.GetRow(clickedbutton);
                int col = biggrid.GetColumn(clickedbutton);
                buttons[row, col] = clickedbutton;
            }
            

            if (poopoo.Tie(buttons) == true)
            {
                await Application.Current.MainPage.DisplayAlert("Tie", "X & O", "OK");
                GameOver = true;
            }
            else if (poopoo.Diags(image, buttons) == true || poopoo.Lines(image, buttons) == true)
            {
                await Application.Current.MainPage.DisplayAlert($"{nameofthing} WON", $"{nameofthing}", "OK");
                GameOver = true;
            }
            if (GameOver == true)
            {
                bool result = await Application.Current.MainPage.DisplayAlert("Confirmation", "Do you want to play again?", "Yes", "No");

                if (result == true)
                {
                    Other.Erase(buttons);
                    GameOver = false;
                }
                else
                {
                    System.Diagnostics.Process.GetCurrentProcess().Kill();
                }
            }
        }
    }
}
