namespace Tasarim.Models
{
    public partial class UyeBilgileri
    {
        public int Uye_Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int TC { get; set; }
        public bool Cinsiyet { get; set; }
        public int Telefon { get; set; }
        public int Sifre { get; set; }
        public int Yas { get; set; }
    }
}