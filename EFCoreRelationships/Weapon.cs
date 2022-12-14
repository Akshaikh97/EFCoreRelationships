using System.Text.Json.Serialization;

namespace EFCoreRelationships
{
    public class Weapon
    {
        public int Id { get; set; }
        public string Name { get; set; }=String.Empty;
        public int Damage { get; set; } = 10;
        [JsonIgnore]
        public Character Character { get; set; }
        public int CharacterId { get; set; }
    }
}
