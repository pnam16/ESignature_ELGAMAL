using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ESignature_ELGAMAL
{
    public partial class Form1 : Form
    {
        public Services services = new Services();
        ulong p, q, So_G_A, a, x, d, k, y;
        private void BtnBrowerUnsign_Click(object sender, EventArgs e)
        {
            openFileDialogToSign.Filter = "Text Files|*.txt";
            if (openFileDialogToSign.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string fileName = openFileDialogToSign.FileName;
                txtPathUnsign.Text = fileName;
            }
        }

        private void BtnSign_Click(object sender, EventArgs e)
        {
            if (txtP.Text == "" || txtA.Text == "" || txtD.Text == "" || txtX.Text == "" || txtK.Text == "" || txtY.Text == "")
            {
                MessageBox.Show("Hãy tạo đủ các trường cần thiết trước khi ký", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtPathUnsign.Text == "")
            {
                MessageBox.Show("Hãy chọn file trước khi ký", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string readFile = File.ReadAllText(openFileDialogToSign.FileName);
            txtShow.Text = readFile;

            String chuky = Ky(readFile);
            txtShow.Text = chuky;

        }
        public string Ky(string ChuoiVao)
        {
            //danh so ky tu unicode
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(ChuoiVao);

            string hashStr = Convert.ToBase64String(plainTextBytes);

            int n = hashStr.Length;
            List<uint> mh_temp2 = new List<uint>();

            for (int i = 0; i < n; i++)
            {
                mh_temp2.Add((uint)hashStr[i]);
            }
            long mh_temp2length = mh_temp2.Count;
            List<ulong> mh_temp3 = new List<ulong>();

            //tính y2= (x*b^k) mod p
            for (int i = 0; i < mh_temp2length; i++)
            {
                mh_temp3.Add((ulong)((mh_temp2[i] % p) * (services.LuyThuaModulo(d, k, p))) % p);
            }

            String str = "";
            long mh_temp3length = mh_temp3.Count;
            for (int i = 0; i < mh_temp3length; i++)
            {
                str += (char)mh_temp3[i];
            }
            string banMaHoa;
            var _plainTextBytes = System.Text.Encoding.UTF8.GetBytes(str);
            banMaHoa = System.Convert.ToBase64String(_plainTextBytes);

            return banMaHoa;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {}
        void Reset()
        {
            txtP.Text = txtA.Text = txtD.Text = txtX.Text = txtK.Text = txtY.Text = "";
        }
        private void BtnCreateKey_Click(object sender, EventArgs e)
        {
            Reset();
            // chọn số nguyên tố ngẫu nhiên P
            p = 0;
            do
            {
                p = services.GetRandom();
            } while (services.KiemtraSNT(p) == false);

            AutoCreateKey();
            txtP.Text = p.ToString();
            txtA.Text = a.ToString();
            txtX.Text = x.ToString();
            txtD.Text = d.ToString();
            txtK.Text = k.ToString();
            txtY.Text = y.ToString();

            MessageBox.Show("Khóa đã tạo thành công", "Thông báo", MessageBoxButtons.OK);
        }

        void AutoCreateKey() //Tạo khóa tự động
        {
            q = So_G_A = a = x = d = k = 0;
            // chọn số nguyên tố ngẫu nhiên Q thỏa mãn Q là ước của P - 1
            do
            {
                q = services.GetRandom() % ((p - 1) - 2 + 1) + 2;
            } while (!services.KiemTraUocCuaP(p, q) || ((p - 1) - 2 + 1) == 0);

            // tìm số G để tìm số A (A là phần tử sinh): 
            do
            {
                So_G_A = services.GetRandom() % ((p - 1) - 2 + 1) + 2; ;
            } while (!services.KiemTraKetQuaTao(So_G_A, p, q));

            a = services.LuyThuaModulo(So_G_A, p - 1 / q, p);// phần tử a
            //tạo x
            do
            {
                x = services.GetRandom() % ((p - 2) - 2 + 1) + 2;
            } while (x == q || x == So_G_A);

            // d= a^x mod P
            d = services.LuyThuaModulo(a, x, p);
            do
            {
                k = services.GetRandom() % ((p - 2) - 2 + 1) + 2;
            } while (k == x || k == a || k == q || k == So_G_A || !services.GCDEqual1(k, p - 1));

            // Tính Y = A^k mod p - Khóa công khai
            y = services.LuyThuaModulo(a, k, p);
        }
    }
}
