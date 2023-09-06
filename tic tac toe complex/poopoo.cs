using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tic_tac_toe_complex
{
    public static class poopoo
    {


        public static bool Diags(ImageSource image, Button[,] buttons)
        {
            int k = buttons.GetLength(0);
            bool diag1Match = true; // Initialize to true
            bool diag2Match = true; // Initialize to true

            for (int i = 0; i < k; i++)
            {
                if (buttons[i, i].ImageSource != image)
                {
                    diag1Match = false; // Set to false if any element in the first diagonal doesn't match

                }

                if (buttons[i, k - 1 - i].ImageSource != image)
                {
                    diag2Match = false; // Set to false if any element in the second diagonal doesn't match

                }
            }

            if (diag1Match == true || diag2Match == true)
            {
                return true;
            }
            return false;
        }
        public static bool Lines(ImageSource image, Button[,] buttons)
        {
            int k = buttons.GetLength(0);
            bool vertical = true; // Initialize to true
            bool horizontal = true; // Initialize to true
            for (int i = 0; i < k; i++)
            {
                // Reset these variables for each row/column
                vertical = true;
                horizontal = true;

                for (int j = 0; j < k; j++)
                {
                    // Check horizontal line
                    if (buttons[i, j].ImageSource != image)
                    {
                        horizontal = false; // Set to false if any element in the current row doesn't match
                    }

                    // Check vertical line
                    if (buttons[j, i].ImageSource != image)
                    {
                        vertical = false; // Set to false if any element in the current column doesn't match
                    }
                }

                // If either horizontal or vertical line is true, return true
                if (vertical || horizontal)
                {
                    return true;
                }
            }

            // If no lines were found, return false
            return false;
        }
        public static bool Tie(Button[,] buttons)
        {
            for (int i = 0; i < buttons.GetLength(0); i++)
            {
                for (int j = 0; j < buttons.GetLength(1); j++)
                {
                    if (buttons[i, j].ImageSource == null)
                    {
                        return false;
                    }

                }
            }
            return true;

        }
    }
}
