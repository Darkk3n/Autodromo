namespace Autodromo.Data.VO
{
    public class ComboItem
    {
        public string Name;
        public string Value;
        public int intValue;
        public ComboItem(string name, string value)
        {
            Name = name; Value = value;
        }
        public ComboItem(string name, int value)
        {
            Name = name; intValue = value;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
