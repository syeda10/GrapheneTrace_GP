using System;

namespace GrapheneTrace_GP.Services
{
    public static class ColorMaps
    {
        // ---------------------------------------------------------
        // Inferno Color Map (shortened for example; you can replace
        // with full 256-color Inferno if needed)
        // ---------------------------------------------------------
        private static readonly (byte r, byte g, byte b)[] Inferno =
        {
            (0, 0, 4), (1, 0, 5), (1, 1, 6), (1, 1, 8),
            (2, 1, 10), (3, 1, 12), (4, 2, 14), (6, 2, 16),
            (7, 3, 18), (8, 3, 21), (10, 4, 23), (12, 4, 26),
            (14, 5, 29), (16, 5, 32), (18, 6, 35), (20, 7, 38),
            (22, 7, 41), (24, 8, 44), (27, 9, 48), (29,10,51),
            // (add full Inferno here if you want perfect accuracy)
            (252, 255, 164)
        };

        // ---------------------------------------------------------
        // Get Inferno RGB color, with gamma correction
        // ---------------------------------------------------------
        public static string GetInfernoColor(float value, float min, float max)
        {
            if (max - min == 0)
                return "rgb(0,0,0)";

            // Normalize 0–1
            float t = (value - min) / (max - min);
            t = Math.Clamp(t, 0f, 1f);

            double gamma = 0.3;      // lower = brighter shadows
            t = (float)Math.Pow(t, gamma);

            // ★ Optional scaling boost
            t *= 1.5f;
            t = Math.Min(t, 1f);     // clamp again

            // Map to Inferno index
            int index = (int)(t * (Inferno.Length - 1));

            var (r, g, b) = Inferno[index];
            return $"rgb({r},{g},{b})";
        }


    }
}
