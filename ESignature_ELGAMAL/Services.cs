using System;
using System.Text;
using System.Security.Cryptography;
using System.Collections.Generic;

namespace ESignature_ELGAMAL
{
    public class Services
    {
        public long GetRandom()
        {
            Random rnd = new Random();
            return (long)rnd.Next(30000);
        }
        public bool KiemtraSNT(long param) //kiểm tra số nguyên tố
        {
            if (param < 2)
                return false;

            double squareRoot = Math.Sqrt(param);

            for (long i = 2; i <= squareRoot; i++)
                if (param % i == 0)
                    return false;

            return true;
        }
        public bool KiemTraUocCuaP(long p, long b) //kiểm tra ước của X thuộc (2,...,p-2)
        {
            if ((p - 1) % b == 0)
                return true;
            else
                return false;
        }

        public bool GCDEqual1(long a, long b) // kiểm tra nguyên tố cùng nhau
        {
            long temp;
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

        public long LuyThuaModulo(long coSo, long soMu, long soModulo)
        {
            long ketqua = 1, n = soModulo, x = coSo;
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

        public long NghichDaoModulo(long n, long modulo)
        {
            for (long i = 1; i < modulo; i++)
            {
                //nếu có 1 số nhỏ hơn m mà nhân với n chia co m dữ 1 thì trả về giá trị 
                if (((long)n * i) % modulo == 1)
                {
                    return i;
                }
            }

            return 0; // nếu không có trả về 0
        } //Nghịch đảo Modulo


        public bool KiemTraKetQuaTao(long temp, long p, long b)
        {
            long soMu = p - 1 / b;
            long result = LuyThuaModulo(temp, soMu, p);
            if (result == 1)
                return false;
            else
                return true;
        } //kiem tra so duoc sinh ra

        public long TinhD(long a, long x, long p)
        {
            long result = 1;

            for (long i = 0; i <= x; i++)
                result *= NghichDaoModulo(a, p);

            return result;
        }

        public string Hash(string strNeedHash) // Hash SHA256
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(strNeedHash));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        public List<long> ListHex2Dec(string hashStr)
        {
            List<long> temp = new List<long>();
            for (int i = 0; i < hashStr.Length; i += 2)
            {
                var sub = hashStr.Substring(i, 2);
                temp.Add((long)Convert.ToInt64(sub, 16));
            }

            return temp;
        }

    }
}