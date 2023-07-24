using System;
using System.Drawing;

namespace KeyStrokes
{
    public static class Colorful
    {
        private static float step = 0;
        private static Random random = new Random();
        private static Color currentColor = Color.FromArgb(46, 204, 113);
        private static Color targetColor = Color.FromArgb(229, 54, 69);

        public static Color GetNextColor()
        {
            if (step >= 1f)
            {
                step = 0;

                int R = random.Next(0, 255);
                int G = random.Next(0, 255);
                int B = random.Next(0, 255);

                currentColor = targetColor;
                targetColor = Color.FromArgb(R, G, B);
            }
            int mixR = (int)(currentColor.R * (1f - step) + targetColor.R * step);
            int mixG = (int)(currentColor.G * (1f - step) + targetColor.G * step);
            int mixB = (int)(currentColor.B * (1f - step) + targetColor.B * step);

            step += 0.015F;

            return Color.FromArgb(mixR, mixG, mixB);
        }
    }
}
