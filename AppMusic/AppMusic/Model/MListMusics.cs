using System.Text.Json.Serialization;

namespace AppMusic.Model; 
internal class MListMusics {

    [JsonPropertyName ("song")]
    public string Music { get; set; }
    [JsonPropertyName ("genre")]
    public string Genre { get; set; }
    [JsonPropertyName("artist")]
    public string Artist { get; set; }
    //[JsonPropertyName ("year")]
    //public int YearMusic { get; set; }
    [JsonPropertyName("duration_ms")]
    public int DurationMusic { get; set; }
    public void ShowMusics() {
        Console.WriteLine($"Music: {this.Music}");
        Console.WriteLine($"Genre: {this.Genre}");
        Console.WriteLine($"Artist: {this.Artist}");
        Console.WriteLine($"Music duration: {this.DurationMusic}");
    }
}
