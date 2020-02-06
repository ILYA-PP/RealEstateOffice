namespace RealStateOffice
{
    public struct Obj
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Obj(int i, string n)
        {
            ID = i;
            Name = n;
        }
    };
}
