namespace DOTNET_RPG.Models
{
    public class Charcter
    {
        public int Id {get; set;}
        public String Name {get; set;} = "Frodo";
        public int HitPoints {get; set;} =100;
        public int Strength {get; set;} = 10;
        public int Defense {get; set;} = 10;
        public int Intelligence {get; set;} = 10;
        public RpgClass class {get; set;} = RpgClass.Knight;
    }
}