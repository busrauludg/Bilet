namespace Tasarim.Models
{
    public partial class GuzergahBilgileri
    {
        public int GuzergahId { get; set; }
        public string Baslangıç{ get; set; }
        public string Varis { get; set; }
        public decimal Mesafe { get; set; }
        public decimal TahminiSüre { get; set; }

    }
}