using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoInfo.Other
{
    /// <summary>
    /// Třída zkopírovaná z CIEAdmin.Classes...!!!
    /// 
    /// Zakladni funkce pro praci s carovymi kody
    /// </summary>
    public static class BarCode128
    {
        private static bool TestDigit(string str, int startIndex, int length)
        {
            int stopIndex = startIndex + length;
            if (stopIndex > str.Length)
                return false;

            for (int i = startIndex; i < stopIndex; i++)
            {
                byte ascValue = Convert.ToByte(str[i]);
                if (ascValue < 48 || ascValue > 57)
                    return false;
            }
            return true;
        }

        public static string Code128(string str)
        {
            try
            {
                int i;
                long checkSum = 0;
                int mini = 0;
                int dummy = 0;
                bool tableB;
                string result = string.Empty;

                // Nema smysl zpracovavat prazdny retezec
                if (str == string.Empty)
                    return string.Empty;

                // Kontrola prijatelnych znaku
                foreach (char c in str)
                {
                    byte ascValue = Convert.ToByte(c);
                    if ((ascValue < 32 || ascValue > 126) && (ascValue != 198))
                        return string.Empty;
                }

                tableB = true;

                i = 0;
                while (i < str.Length)
                {
                    if (tableB)
                    {
                        mini = (i == 0 || i + 4 == str.Length) ? 4 : 6;

                        // Jestlize bylo od i-teho znaku mini cislic, pak pracujeme s TableC
                        if (TestDigit(str, i, mini))
                        {
                            if (i == 0)
                                result += Convert.ToChar(205).ToString(); //Zacatek kodu s TableC
                            else
                                result += Convert.ToChar(199).ToString(); //Prepnuti na TableC
                            tableB = false;
                        }
                        else
                        {
                            if (i == 0)
                                result += Convert.ToChar(204).ToString(); //Zacatek kodu s TableB
                        }
                    }
                    if (!tableB)
                    {
                        // Pokud nasleduji dve cislice, zpracuji jako TableC, jinak se prepinam do TableB
                        if (TestDigit(str, i, 2))
                        {
                            dummy = int.Parse(str.Substring(i, 2));
                            dummy = dummy < 95 ? dummy + 32 : dummy + 100;
                            result += Convert.ToChar(dummy).ToString();
                            i += 2;
                        }
                        else
                        {
                            result += Convert.ToChar(200).ToString();
                            tableB = true;
                        }
                    }
                    if (tableB)
                    {
                        result += str[i++];
                    }
                }

                // Vypocet kontrolniho souctu
                i = 0;
                foreach (char c in result)
                {
                    dummy = Convert.ToByte(c);
                    dummy = dummy < 127 ? dummy - 32 : dummy - 100;

                    if (i == 0)
                        checkSum = dummy;

                    checkSum += i * dummy;

                    i++;
                }
                checkSum = checkSum % 103;
                checkSum = checkSum < 95 ? checkSum + 32 : checkSum + 100;

                result += Convert.ToChar((byte)checkSum).ToString() + Convert.ToChar(206).ToString();

                return result;
            }
            catch (Exception ex)
            {
                SmartISLib.Messages.Error("Cannot generate barcode for '" + str + "'");
                return string.Empty;
            }
        }

        /// <summary>
        /// Vykresli do bitmapy dany barcode ve formatu Code 128 A
        /// </summary>
        /// <param name="barCodeStr"></param>
        /// <returns></returns>
        public static byte[] PaintBarCodeA(int width, int height, string barCodeStr)
        {
            char[] charData = {' ', '!', (char)34, '#', '$', '%', '&', '\'', '(', ')', '*', '+', ',', '-', '.', '/',
                '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', ':', ';', '<', '=', '>', '?', '@', 'A', 'B', 'C',
                'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W',
                'X', 'Y', 'Z', '[', '\\', ']', '^', '_', '`', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k',
                'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '{', '|', '}', '~', 
                (char)127, (char)201, (char)202, (char)203, (char)204, (char)205, (char)206, (char)207, (char)208, (char)209, (char)210, (char)211};

            string[] charBarData = {"212222", "222122", "222221", "121223", "121322", "131222", "122213", "122312", "132212", "221213", "221312", "231212", "112232", "122132", "122231", "113222", "123122", "123221", "223211", "221132", "221231", "213212", "223112", "312131", "311222", "321122", "321221", "312212", "322112", "322211", "212123", "212321", "232121", "111323", "131123", "131321", "112313", "132113", "132311", "211313", "231113", "231311", "112133", "112331", "132131", "113123", "113321", "133121", "313121", "211331", "231131", "213113", "213311", "213131", "311123", "311321", "331121", "312113", "312311", "332111", "314111", "221411", "431111", "111224", "111422", "121124", "121421", "141122", "141221", "112214", "112412", "122114", "122411", "142112", "142211", "241211", "221114", "413111", "241112", "134111", "111242", "121142", "121241", "114212", "124112", "124211", "411212", "421112", "421211", "212141", 
                "214121", "412121", "111143", "111341", "131141", "114113", "114311", "411113", "411311", "113141", "114131", "311141", "411131", "211412", "211214", "211232", "2331112"};

            int[] nratio = { 0, 15, 30, 45, 60 };

            int parts;
            float pix;
            string barCode = string.Empty;
            char barChar;
            int barWidth;
            float nextBar;
            int boxY;
            int boxH;
            int boxW;
            Color barColor;
            string eanCode;
            char eanChar;
            int i, j;

            eanCode = (char)207 + barCodeStr; //FNC1

            boxY = 0;
            boxH = height;
            boxW = width;
            nextBar = 0;

            int checkSum = 0;

            for (j = 0; j < eanCode.Length; j++)
            {
                eanChar = eanCode[j];
                for (i = 0; i < charData.Length; i++)
                {
                    if (charData[i] == eanChar)
                    {
                        checkSum += i * (j + 1);
                        barCode += charBarData[i];
                    }
                }
            }

            checkSum = checkSum % 103;

            //[Start code A] & [Bar code string] & [CheckSum] & [Stop]

            barCode = charBarData[103] + barCode + charBarData[checkSum] + charBarData[106];

            parts = 0;

            for (i = 0; i < barCode.Length; i++)
                parts += nratio[int.Parse(barCode[i].ToString())];


            Bitmap bitmap = new Bitmap(width, height);
            pix = boxW / (float)parts;

            float[] nBar = { nratio[0] * pix, nratio[1] * pix, nratio[2] * pix, nratio[3] * pix, nratio[4] * pix };

            barColor = Color.Black;

            Graphics g = Graphics.FromImage(bitmap);
            g.Clear(Color.White);

            for (j = 0; j < barCode.Length; j++)
            {
                barChar = barCode[j];
                barWidth = int.Parse(barChar.ToString());

                g.FillRectangle(new SolidBrush(barColor), nextBar, boxY, nBar[barWidth], boxH);

                nextBar += nBar[barWidth];
                if (barColor == Color.Black)
                    barColor = Color.White;
                else
                    barColor = Color.Black;
            }

            MemoryStream stream = new MemoryStream();
            bitmap.Save(stream, System.Drawing.Imaging.ImageFormat.Bmp);
            stream.Close();

            return stream.GetBuffer();
        }
    }
}
