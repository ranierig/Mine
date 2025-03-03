
namespace AppMusic.Model; 
internal class MusicasPreferidas {
    public string NameList { get; set; }
    public List<MListMusics> ListMusics { get; }
    public MusicasPreferidas (string nameList) {
        NameList = nameList;
        ListMusics = new List<MListMusics>();
    }
    public void AddMusicList(MListMusics nameMusic) {
        ListMusics.Add(nameMusic);
    }



}
