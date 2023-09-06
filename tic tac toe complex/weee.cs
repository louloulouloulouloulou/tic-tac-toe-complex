using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tic_tac_toe_complex
{
    internal class weee
    {
        public static Grid CGrid(int rows, int cols)
        {
            Grid grid = new Grid();

            for (int i = 0; i < rows; i++)
            {
                grid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(100, GridUnitType.Auto) });
            }
            
            for (int j = 0; j < cols; j++)
            {
                grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength (100, GridUnitType.Auto) });
            }

            for (int k = 0; k < rows; k++)
            {
                for (int l = 0; l < cols; l++)
                {
                    Button button = new Button();

                    button.Text = "";
                    button.WidthRequest = 200;
                    button.HeightRequest = 200;

                    grid.SetRow(button, k);
                    grid.SetColumn(button, l);


                    grid.Children.Add(button);
                }
            }
            return grid;
        }
        
    }
}
