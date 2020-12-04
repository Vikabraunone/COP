namespace ClassLibraryControl.ThreeLab
{
    public class Column
    {
        public string Name { get; set; }
        public bool Visibility { get; set; }
        public int Width { get; set; }

        public Column(string Name)
        {
            this.Name = Name;
            Visibility = true;
            Width = 119;
        }
    }
}
