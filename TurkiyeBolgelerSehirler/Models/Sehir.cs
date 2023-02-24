namespace TurkiyeBolgelerSehirler.Models
{
    public class Sehir
    {
        public int Id { get; set; }
        public string? SehirAd { get; set; }
        public int Nufus { get; set; }
        public string? Slug { get; set; } // Slug yapısı ile Türkçe karakter kullanmayız.Bunun için önce Helpers içinde UrlUtilities oluşturduk.

        public int BolgeId { get; set; }
        public Bolge? Bolge { get; set; }
    }
}
