using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ESignature_ELGAMAL
{
    public partial class Form1 : Form
    {
        public Services services = new Services();
        long p, q, So_G_A, a, x, d, k, y;
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
            try
            {
                p = (long)Int64.Parse(txtP.Text);
                a = (long)Int64.Parse(txtA.Text);
                d = (long)Int64.Parse(txtD.Text);
                x = (long)Int64.Parse(txtX.Text);
                k = (long)Int64.Parse(txtK.Text);
                y = (long)Int64.Parse(txtY.Text);
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtPathUnsign.Text == "")
            {
                MessageBox.Show("Hãy chọn file trước khi ký", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!services.KiemtraSNT(p))
            {
                MessageBox.Show("p phải là số nguyên tố", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (d != services.LuyThuaModulo(a, x, p))
            {
                MessageBox.Show("d của bạn không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (y != services.LuyThuaModulo(a, k, p))
            {
                MessageBox.Show("y của bạn không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!services.GCDEqual1(k, p - 1))
            {
                MessageBox.Show("k, p là 2 số nguyên tố cùng nhau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string readFile = File.ReadAllText(openFileDialogToSign.FileName);
            String chuky = Sign(readFile);
            txtShow.Text = chuky;

            //lưu file
            try
            {
                saveFileDialog.Title = "Save File Sign";
                saveFileDialog.Filter = "Sign File (*txt.sig) | *.sig";
                saveFileDialog.FileName = "ChuKy.sig";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, chuky);
                    MessageBox.Show("Ký thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnBrowerSigned_Click(object sender, EventArgs e)
        {
            openFileDialogToCheck.Filter = "|*.sig";
            if (openFileDialogToCheck.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string fileName = openFileDialogToCheck.FileName;
                txtPathSignature.Text = fileName;
            }
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            if (txtPathUnsign.Text == "")
            {
                MessageBox.Show("Hãy chọn file cần kiểm tra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtPathSignature.Text == "")
            {
                MessageBox.Show("Hãy chọn file chữ ký để kiểm tra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtP.Text == "" || txtA.Text == "" || txtD.Text == "")
            {
                MessageBox.Show("Khóa công khai không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtY.Text == "" || txtK.Text == "")
            {
                MessageBox.Show("k và y không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                p = (long)Int64.Parse(txtP.Text);
                a = (long)Int64.Parse(txtA.Text);
                d = (long)Int64.Parse(txtD.Text);
                k = (long)Int64.Parse(txtK.Text);
                y = (long)Int64.Parse(txtY.Text);
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!services.KiemtraSNT(p) || a > p || !services.GCDEqual1(k, p - 1) || y != services.LuyThuaModulo(a, k, p))
            {
                MessageBox.Show(
                    "p hoặc a hoặc k chưa hợp lệ. p phải là số nguyên tố, a < p, GCD(k, p-1) = 1, y = a^k mod p",
                    "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning
                );
                return;
            }

            string originalFile = File.ReadAllText(openFileDialogToSign.FileName);
            string signature = File.ReadAllText(openFileDialogToCheck.FileName);


            if (Verify(signature, originalFile))
            {
                MessageBox.Show("File vẫn còn nguyên vẹn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("File đã bị chỉnh sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }


        private bool Verify(string signature, string content)
        {
            // Hash content of original file
            var contentHashed = services.Hash(content);
            var list = services.ListHex2Dec(contentHashed);
            int n = list.Count;

            try
            {
                var signatureDecode = System.Convert.FromBase64String(signature);
                var signatureStr = System.Text.Encoding.UTF8.GetString(signatureDecode);
                // signatureStr có dạng y-y2

                string[] signature2Arr = signatureStr.Split('-');

                // chuyển y từ string sang long
                long y = long.Parse(signature2Arr[0]);

                var temp = signature2Arr[1].Split("|");

                for (int i = 0; i < n; i++)
                {
                    long y2 = long.Parse(temp[i]);

                    // v1 = d^y * y^y2
                    long v1 = services.LuyThuaModulo((services.LuyThuaModulo(d, y, p) * services.LuyThuaModulo(y, y2, p)), 1, p);

                    //giá trị của v2 là giá trị được tạo ra từ chữ ký của nội dung đó

                    // v2 = a ^ H(m) mod p
                    long v2 = services.LuyThuaModulo(a, (long)list[i], p);

                    if (v1 != v2)
                    {
                        return false;
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false; ;
            }

            return true;

        }

        public string Sign(string ChuoiVao)
        {
            //string hashStr = Convert.ToBase64String(plainTextBytes);
            string hashStr = services.Hash(ChuoiVao);



            // 
            // chuyển các ký tự đã được hash(đang ở dạng chữ hex) ra mảng số kiểu dữ liệu long
            List<long> list = services.ListHex2Dec(hashStr);
            int n = list.Count;

            //tạo mảng để lưu các giá trị đã được mã hoá thông qua công thức y2 =  k^-1 * (H(m) - x * y) mod (p - 1)
            List<long> listY2 = new List<long>();

            //tính y2= (H(m) - x * y) * k^-1 * mod (p - 1)
            for (int i = 0; i < n; i++)
            {
                var yy2 = services.NghichDaoModulo(k, p - 1);   // k^-1
                var yyy2 = (list[i] - x * y);              // (H(m) - x * y)

                var y2 = (yy2 * yyy2) % (p - 1);
                if (y2 < 0)
                {
                    y2 += (p - 1);
                }

                listY2.Add(y2);
            }

            // lưu lại giá trị mã hoá bao gồm cả y1 và y2
            String banMaHoa = y + "-";

            for (int i = 0; i < n; i++)
            {
                banMaHoa += listY2[i];
                if (i != n - 1)
                    banMaHoa += "|";
            }

            var _plainTextBytes = System.Text.Encoding.UTF8.GetBytes(banMaHoa);

            return System.Convert.ToBase64String(_plainTextBytes); ;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) { }
        void Reset()
        {
            txtP.Text = txtA.Text = txtD.Text = txtX.Text = txtK.Text = txtY.Text = txtPathSignature.Text = txtPathUnsign.Text = txtShow.Text = "";
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

            // d= a^x mod p
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
