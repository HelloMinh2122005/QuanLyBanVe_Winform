namespace QuanLyBanVe
{
    public partial class Form1 : Form
    {
        private List<Button> DS_GheDangChon = new List<Button>();
        private Dictionary<Button, int> TriGiaGhe = new Dictionary<Button, int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TriGiaGhe.Add(Ghe1, 8000);
            TriGiaGhe.Add(Ghe2, 8000);
            TriGiaGhe.Add(Ghe3, 8000);
            TriGiaGhe.Add(Ghe4, 8000);
            TriGiaGhe.Add(Ghe5, 8000);
            TriGiaGhe.Add(Ghe6, 6500);
            TriGiaGhe.Add(Ghe7, 6500);
            TriGiaGhe.Add(Ghe8, 6500);
            TriGiaGhe.Add(Ghe9, 6500);
            TriGiaGhe.Add(Ghe10, 6500);
            TriGiaGhe.Add(Ghe11, 5000);
            TriGiaGhe.Add(Ghe12, 5000);
            TriGiaGhe.Add(Ghe13, 5000);
            TriGiaGhe.Add(Ghe14, 5000);
            TriGiaGhe.Add(Ghe15, 5000);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void Chon_BUT_Click(object sender, EventArgs e)
        {
            if (DS_GheDangChon.Count == 0)
                MessageBox.Show("Bạn chưa chọn ghế nào để bán");
            else
            {
                int TongTien = 0;
                foreach (var Ghe in DS_GheDangChon)
                {
                    TongTien += TriGiaGhe[Ghe];
                    Ghe.BackColor = Color.Yellow;
                }
                ThanhTien_RES.Text = TongTien.ToString();
                DS_GheDangChon.Clear();
            }
        }

        private void Ghe_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == Color.Blue)
            {
                btn.BackColor = SystemColors.ButtonFace;
                DS_GheDangChon.Remove(btn);
            }
            else
            {
                if (btn.BackColor != Color.Yellow)
                {
                    btn.BackColor = Color.Blue;
                    DS_GheDangChon.Add(btn);
                }
                else
                {
                    string GheSo = btn.Name.Replace("Ghe", "");
                    MessageBox.Show($"Vị trí {GheSo} đã được bán");
                }
            }
        }
        private void HuyBo_BUT_Click(object sender, EventArgs e)
        {
            foreach (var Ghe in DS_GheDangChon)
                if (Ghe.BackColor == Color.Blue)
                    Ghe.BackColor = SystemColors.ButtonFace;
            ThanhTien_RES.Text = "0";
        }

        private void KetThuc_BUT_Click(object sender, EventArgs e)
        {
            foreach (var Ghe in TriGiaGhe.Keys)
                Ghe.BackColor = SystemColors.ButtonFace;
            DS_GheDangChon.Clear();
            ThanhTien_RES.Text = "0";
        }
    }
}