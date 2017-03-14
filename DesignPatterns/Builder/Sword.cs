using System.Text;

namespace DesignPatterns.Builder
{
    public class Bar
    {
        // Bar Type
        public string Type { get; set; }
    }

    public class Skin
    {
        public string Type { get; set; }
    }


    public class Dust
    {
        public string Name { get; set; }
    }


    public class Sword
    {
        public Bar IronBar { get; set; }
        public Bar AdamantitBar { get; set; }
        public Skin Skin { get; set; }
        public Dust Additives { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            var dmg = 20;
            if (IronBar != null)
            {
                sb.Append("Iron Bar " + IronBar.Type + "\n");
                dmg *= 2;
            }
              
            if (AdamantitBar != null)
            {
                sb.Append("Adamantit Bar " + AdamantitBar.Type + " \n");
                dmg *= 4;
            }

            if (Skin != null)
                sb.Append("Skin: " + Skin.Type + " \n");
            if (Additives != null)
                sb.Append("Dust: " + Additives.Name + " \n");
            sb.Append("Dmg: " + dmg + " \n");
            return sb.ToString();
        }
    }
}
