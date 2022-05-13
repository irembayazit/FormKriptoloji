using System;
using System.Collections.Generic;
using System.Text;

namespace FormKriptoloji
{
    class RSA
    {
        public void desgiskenTanımla(int p, int q, out int n, out int e, out int d, out int phi)
        {
            n = p * q;
            phi = (p - 1) * (q - 1);

            d = 0;
            e = 0;
            int rand;

            while (true)
            {
                rand = new Random().Next(1, phi);
                if (OBEB(rand, phi) == 1)
                {
                    e = rand;
                    break;
                }
            }

            d = oklit(e, phi);

            Console.WriteLine("phi: " + phi);
            Console.WriteLine("d: " + d);
            Console.WriteLine("(n,e) : ({0},{1}) ", n, e);
        }

        static int OBEB(int x, int y)
        {
            int min = Math.Min(x, y);
            int obeb = 1;
            for (int i = 1; i <= min; i++)
            {
                if (x % i == 0 && y % i == 0)
                {
                    obeb = i;
                }
            }
            return obeb;
        }

        static int oklit(int d, int f)
        {

            int x1, x2, x3, y1, y2, y3;
            x1 = 1; x2 = 0; x3 = f; //p
            y1 = 0; y2 = 1; y3 = d; //d

            int q = 0, i = 1;
            int t1 = 0, t2 = 0, t3 = 0;
            do
            {
                if (i == 1)
                {
                    q = x3 / y3;
                    t1 = x1 - (q * y1);
                    t2 = x2 - (q * y2);
                    t3 = x3 - (q * y3);
                }
                else
                {
                    x1 = y1; x2 = y2; x3 = y3;
                    y1 = t1; y2 = t2; y3 = t3;
                    q = x3 / y3;
                    t1 = x1 - (q * y1);
                    t2 = x2 - (q * y2);
                    t3 = x3 - (q * y3);
                }
                i++;

                if (y3 == 0)
                {
                    break;
                }

            } while (y3 != 1);

            if (y3 == 0)
            {
                Console.WriteLine("Sayinin tersi yoktur!!!!");
            }
            else
            {
                Console.WriteLine("nSayinin tersi : %d", y2);
            }

            return y2 + f;
        }

        public string Desifreleme(string sifreliMetin, int d, double n)//a^b(mod(n))
        {
            Console.WriteLine("desişreleme geldi");
            int LCipher = Convert.ToString(n).Length;
            int LClear = Convert.ToString(n).Length - 1;
            int _d;
            string acikMetin = "";

            for (int i = 0; i < sifreliMetin.Length; i += LCipher)
            {
                string bolum = sifreliMetin.Substring(i, LCipher);
                Console.WriteLine("bolum : " + bolum);
                _d = d;
                double _bolum = Convert.ToInt32(bolum);
                double __bolum = _bolum;
                while (_d > 1)
                {
                    _bolum *= __bolum;
                    _bolum = _bolum % n;
                    _d--;
                }
                Console.WriteLine("hesaplanmıs: " + _bolum);
                string bolumString = Convert.ToString(_bolum);
                while (bolumString.Length < LClear)
                {
                    bolumString = 0 + bolumString;
                }
                acikMetin += bolumString;
                Console.WriteLine("sıfır atılmıs: " + bolumString);
            }
            Console.WriteLine("Deşifrelenmiş metin: " + acikMetin);

            string ucluAcikMetin = "";
            int ucluAcikMetinInt = 0;
            string acikmetin2 = "";
            char toChar;

            while (acikMetin.Length % 3 != 0)
            {
                acikMetin = acikMetin.Substring(0, acikMetin.Length - 1);
            }
            for (int i = 0; i < acikMetin.Length; i += 3)
            {
                ucluAcikMetin = acikMetin.Substring(i, 3);
                Console.WriteLine(ucluAcikMetin);
                ucluAcikMetinInt = Convert.ToInt32(ucluAcikMetin);
                toChar = Convert.ToChar(ucluAcikMetinInt);
                acikmetin2 += toChar;
            }


            Console.WriteLine("Açık metin 2: " + acikmetin2);
            return acikmetin2;
        }


        public string ModAlma(int k, int e, int n)//k^e(mod(n))
        {
            int LCipher = Convert.ToString(n).Length;
            double _k = k % n;
            int _e = e;

            while (_e > 1)
            {
                _k *= k;
                _k %= n;
                _e--;
            }
            Console.WriteLine("mod sonuc: " + _k);
            string _kStr = Convert.ToString(_k);
            while (_kStr.Length < LCipher)
            {
                _kStr = 0 + _kStr;
            }
            return _kStr;
        }

        public string RsaHesapla(string metin, int n, int e)
        {
            
            StringBuilder builder = new StringBuilder();
            int LCipher = Convert.ToString(n).Length;
            int LClear = LCipher - 1;
            string birlesme = null;
            char[] chars = metin.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                int deger = Convert.ToInt32(chars[i]);
                string sayi = deger.ToString();
                while (sayi.Length < 3)
                {
                    sayi = 0 + sayi;
                }
                Console.WriteLine("ASCII degerleri: " + sayi);
                birlesme += sayi;
            }
            Console.WriteLine("acik metin: " + birlesme);


            for (int i = 0; i < birlesme.Length; i += LClear)
            {
                int kalan = birlesme.Length % LClear;
                if (kalan != 0)
                {
                    while (birlesme.Length % LClear != 0)
                    {
                        birlesme = birlesme + 0;
                    }
                }
                string bolum = birlesme.Substring(i, LClear);
                int bolumInt = Convert.ToInt32(bolum);
                builder.Append(ModAlma(bolumInt, e, n));
            }
            return builder.ToString();
        }
    }
}
