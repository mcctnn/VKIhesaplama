namespace Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnHesapla_Click(object sender, EventArgs e)
        {
                int boy = Convert.ToInt32(tbxBoy.Text);
                int kilo = Convert.ToInt32(tbxKilo.Text);
                int sonuc = Convert.ToInt32(kilo / (boy*boy));
                if (sonuc < 19)
                {
                   lblSonuc.Text = "Zay�f kilo dikkat edin...";    
                }
                 if (sonuc > 19 && sonuc < 25)
                {
                lblSonuc.Text = "Normal kilodas�n�z b�yle devam...";
                }

                 if (sonuc > 25 && sonuc < 30)
                {

                lblSonuc.Text = "Ortalama �st� kilodas�n�z dikkat edin...";
                }
                 if (sonuc > 30 && sonuc < 40)
                {
                lblSonuc.Text = "Obezsiniz �ok dikkat edin...";
                }
                 if (sonuc > 40)
                {
                lblSonuc.Text = "�leri obezlik....";
                }
            
        }
    }
}