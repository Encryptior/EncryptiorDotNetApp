using System;
using System.Drawing;
using System.Linq;

namespace Encryptior
{
    class Identicon
    {
        /// <summary>
        /// Creates new identicon for ethereum address. Standard size of identicon is 8.
        /// </summary>
        /// <param name="Seed">Ethereum address (with 0x prefix)</param>
        /// <param name="Size">Size of the identicon (use 8 for standard identicon)</param>
        public Identicon(string Seed, int size)
        {
            Size = size;
            createImageData(Seed);
        }

        /// <summary>
        /// Returns identicon bitmap with desired resolution (nearest smaller multiple of Blockies.Size)
        /// </summary>
        /// <param name="resolution">use multiples of Blockies.Size</param>
        /// <returns></returns>
        public Bitmap GetBitmap(int resolution)
        {
            int Scale = resolution / Size;
            return CreateEthereumIcon(Scale);
        }

        /// <summary>
        /// Returns identicon Icon which could be used runtime with desired resolution (nearest smaller multiple of Blockies.Size)
        /// </summary>
        /// <param name="resolution">use multiples of Blockies.Size</param>
        /// <returns></returns>
        public Icon GetIcon(int resolution)
        {
            var IconBitmap = GetBitmap(resolution);
            System.IntPtr ich = IconBitmap.GetHicon();
            Icon ico = Icon.FromHandle(ich);
            return ico;
        }

        private Int32[] randseed = new Int32[4];
        private Color[] iconPixels;
        public int Size;

        private void seedrand(string seed)
        {
            char[] seedArray = seed.ToCharArray();
            for (int i = 0; i < randseed.Length; i++)
                randseed[i] = 0;
            for (int i = 0; i < seed.Length; i++)
                randseed[i % 4] = ((randseed[i % 4] << 5) - randseed[i % 4]) + seedArray[i];
        }

        private double rand()
        {
            var t = randseed[0] ^ (randseed[0] << 11);

            randseed[0] = randseed[1];
            randseed[1] = randseed[2];
            randseed[2] = randseed[3];
            randseed[3] = (randseed[3] ^ (randseed[3] >> 19) ^ t ^ (t >> 8));
            return Convert.ToDouble(randseed[3]) / Convert.ToDouble((UInt32)1 << 31);
        }

        private double hue2rgb(double p, double q, double t)
        {
            if (t < 0) t += 1;
            if (t > 1) t -= 1;
            if (t < 1D / 6) return p + (q - p) * 6 * t;
            if (t < 1D / 2) return q;
            if (t < 2D / 3) return p + (q - p) * (2D / 3 - t) * 6;
            return p;
        }

        private Color HSLtoRGB(double h, double s, double l)
        {
            double r, g, b;
            if (s == 0)
            {
                r = g = b = l; // achromatic
            }
            else
            {
                var q = l < 0.5 ? l * (1 + s) : l + s - l * s;
                var p = 2 * l - q;
                r = hue2rgb(p, q, h + 1D / 3);
                g = hue2rgb(p, q, h);
                b = hue2rgb(p, q, h - 1D / 3);
            }
            return Color.FromArgb((int)Math.Round(r * 255), (int)Math.Round(g * 255), (int)Math.Round(b * 255));
        }

        private Color createColor()
        {
            var h = (rand());
            var s = ((rand() * 0.6) + 0.4);
            var l = ((rand() + rand() + rand() + rand()) * 0.25);
            return HSLtoRGB(h, s, l);
        }

        private void createImageData(string seed)
        {
            seedrand(seed.ToLower());
            var mainColor = createColor();
            var bgColor = createColor();
            var spotColor = createColor();

            int width = Size;
            int height = Size;

            int mirrorWidth = width / 2;
            int dataWidth = width - mirrorWidth;
            double[] data = new double[width * height];
            for (int y = 0; y < height; y++)
            {
                double[] row = new double[dataWidth];
                for (int x = 0; x < dataWidth; x++)
                {
                    row[x] = Math.Floor(rand() * 2.3);
                }
                Array.Copy(row, 0, data, y * width, dataWidth);
                Array.Copy(row.Reverse().ToArray(), 0, data, y * width + dataWidth, mirrorWidth);
            }

            iconPixels = new Color[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == 1)
                {
                    iconPixels[i] = mainColor;
                }
                else if (data[i] == 0)
                {
                    iconPixels[i] = bgColor;
                }
                else
                {
                    iconPixels[i] = spotColor;
                }
            }
        }

        private Bitmap CreateEthereumIcon(int scale)
        {
            Bitmap pic = new Bitmap(Size * scale, Size * scale, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            for (int i = 0; i < iconPixels.Length; i++)
            {
                int x = i % Size;
                int y = i / Size;
                for (int xx = x * scale; xx < x * scale + scale; xx++)
                {
                    for (int yy = y * scale; yy < y * scale + scale; yy++)
                    {
                        pic.SetPixel(xx, yy, iconPixels[i]);
                    }
                }
            }
            return pic;
        }
    }
}
