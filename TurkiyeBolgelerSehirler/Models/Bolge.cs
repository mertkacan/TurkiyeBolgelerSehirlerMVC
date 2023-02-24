namespace TurkiyeBolgelerSehirler.Models
{
    public class Bolge
    {
        public int Id { get; set; }
        public string BolgeAd { get; set; }
        public string? Slug { get; set; }// Slug yapısı ile Türkçe karakter kullanmayız.Bunun için önce Helpers içinde UrlUtilities oluşturduk.
        public List<Sehir> Sehirler { get; set; }
    }
}
