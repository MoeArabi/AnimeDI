namespace ANIME_DI.Models
{
    public class MCharacter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int weight { get; set; }
        public int height { get; set; }
        public string type { get; set; }
        //more info about typehttps://www.cbr.com/dere-anime-types-explained/

        public MCharacter(int id, string name, int Age, int weight, int height, string type)
        {
            Id = id;
            Name = name;
            this.Age = Age;
            this.weight = weight;
            this.height = height;
            this.type = type;
        }
    }
}
