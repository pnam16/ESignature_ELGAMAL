using System;
using System.Collections.Generic;
using System.Text;

namespace ESignature_ELGAMAL
{
    public class Services
    {
        public ulong GetRandom()
        {
            Random rnd = new Random();
            return (ulong)rnd.Next(30000);
        }
        public bool KiemtraSNT(ulong param) //kiểm tra số nguyên tố
        {
            if (param < 2)
                return false;

            double squareRoot = Math.Sqrt(param);

            for (ulong i = 2; i <= squareRoot; i++)
                if (param % i == 0)
                    return false;

            return true;
        }
        public bool KiemTraUocCuaP(ulong p, ulong b) //kiểm tra ước của X thuộc (2,...,p-2)
        {
            if ((p - 1) % b == 0)
                return true;
            else
                return false;
        }

        public bool GCDEqual1(ulong a, ulong b) // kiểm tra nguyên tố cùng nhau
        {
            ulong temp;
            // giải thuật Euclid;
            while (b != 0)
            {
                temp = a % b;
                a = b;
                b = temp;
            }

            //kiểm tra ước 2 số có = 1 không
            if (a == 1)
                return true;
            else
                return false;
        } // check GCD(a,b) = 1

        public ulong LuyThuaModulo(ulong coSo, ulong soMu, ulong soModulo)
        {
            ulong ketqua = 1, n = soModulo, x = coSo;
            String k = Convert.ToString((int)soMu, 2);//chuyen sang nhi phan
            int i = 0;
            while (i < k.Length)
            {
                ketqua *= ketqua;
                ketqua %= n;
                if (k[i] == '1')
                {
                    ketqua *= x;
                }
                ketqua %= n;
                i++;
            }
            return ketqua;
        }

        public ulong NghichDaoModulo(ulong temp, ulong modulo)
        {
            //áp dụng thuật toán ơ clit mở rộng
            ulong r = 1, q, y0 = 0, y1 = 1, y = 0;

            while (temp != 0)
            {
                r = modulo % temp;
                if (r == 0) break;// số dư = 0 thì kết thúc
                else
                {
                    q = modulo / temp;
                    y = y0 - y1 * q;
                    modulo = temp;
                    temp = r;
                    y0 = y1;
                    y1 = y;
                }
                if (y == 0) return y;// bước đầu gán giá trị y = 0 sẽ trả về y = 0 
                else
                {
                    y = modulo + y;//bước 2 trở đi
                    return y;
                }
            }

            return 0;
        } //Nghịch đảo Modulo


        public bool KiemTraKetQuaTao(ulong temp, ulong p, ulong b)
        {
            ulong soMu = p - 1 / b;
            ulong result = LuyThuaModulo(temp, soMu, p);
            if (result == 1)
                return false;
            else
                return true;
        } //kiem tra so duoc sinh ra

        public ulong TinhD(ulong a, ulong x, ulong p)
        {
            ulong result = 1;

            for (ulong i = 0; i <= x; i++)
                result *= NghichDaoModulo(a, p);

            return result;
        }

     

    }
}