using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tic_tac_toe_complex
{
    public static class Other
    {
        public static void Wenumechinsama(Layout gri, Grid biggrid)
        {
            biggrid = weee.CGrid(3, 3);

            foreach (var child in biggrid.Children)
            {
                if (child is Button button)
                {
                    button.Clicked += Gamein.GridButton_Click;
                }
            }

            gri.Children.Add(biggrid);



        }
        public static void Array(Grid biggrid, Button[,] buttons)
        {

            foreach (var child in biggrid.Children)
            {
                if (child is Button button)
                {
                    int row = biggrid.GetRow(button);
                    int col = biggrid.GetColumn(button);

                    buttons[row, col] = button;

                }
            }
        }

        public static void Erase(Button[,] buttons)//, Grid biggrid)
        {
            for (int i = 0; i < buttons.GetLength(1); i++)
            {
                for (int j = 0; j < buttons.GetLength(1); j++)
                {
                    buttons[i, j].ImageSource = null;
                }
            }/*
            foreach (var child in biggrid.Children)
            {
                if (child is Button)
                {

                }
            }*/
        }

    }
}
