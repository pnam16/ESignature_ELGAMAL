using System;
using System.Collections.Generic;
using System.Text;

namespace ESignature_ELGAMAL
{
    class Services
    {
        public ulong getRandom()
        {
            Random rnd = new Random();
            return rnd.Next(3000);
        }
        public bool kiemtraSNT(ulong param) //kiểm tra số nguyên tố
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

        public ulong LuyThuaModulo(ulong CoSo, ulong SoMu, ulong soModulo)
        {

            //Sử dụng thuật toán "bình phương nhân"
            //Chuyển SoMu sang hệ nhị phân
            ulong[] a = new ulong[100];
            ulong k = 0;
            do
            {
                a[k] = SoMu % 2;

                k++;
                SoMu /= 2;
            }
            while (SoMu != 0);

            //Quá trình lấy dư
            ulong kq = 1;

            for (ulong i = k - 1; i >= 0; i--)
            {
                kq = (kq * kq) % soModulo;
                if (a[i] == 1)
                    kq = (kq * CoSo) % soModulo;
            }

            return kq;
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
    }
}