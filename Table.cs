class Table : Rectangle
    {
        private double cost;
        public Table(double l, double w)
            : base(l, w)
        { }
        public double costcal()
        {
            double cost;
            cost = GetArea() * 70;
            return cost;
        }
        public void Display()
        {
            base.Display();
            Console.WriteLine("Cost: {0}", costcal());
        }
    }
