namespace Tasarim.Models
{
    public partial class YolcuBilgileri
    {
        public int YolcuId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int TC { get; set; }
        public bool Cinsiyet { get; set; }
        public int Telefon { get; set; }
    }
}