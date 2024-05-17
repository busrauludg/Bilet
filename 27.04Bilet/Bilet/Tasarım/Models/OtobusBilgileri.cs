namespace Tasarim.Models
{
    public partial class OtobusBilgileri
    {
        public int OtobusId { get; set; }
        public string Plaka { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public int KoltukSayisi { get; set; }
    }
}