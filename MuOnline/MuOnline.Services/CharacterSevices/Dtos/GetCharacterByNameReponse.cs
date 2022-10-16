namespace MuOnline.Services.CharacterSevices.Dtos
{
    public class GetCharacterByNameReponse
    {
        public string AccountName { get; set; }
        public string CharacterName { get; set; }
        public string CharacterClassName { get; set; }
        public int Level { get; set; }
        public int MasterLevel { get; set; }
        public int FreePoint { get; set; }
        public int MasterPonit { get; set; }
        public int Strength { get; set; }
        public int Agility { get; set; }
        public int Vitality { get; set; }
        public int Energy { get; set; }
        public int Command { get; set; }
    }
}
