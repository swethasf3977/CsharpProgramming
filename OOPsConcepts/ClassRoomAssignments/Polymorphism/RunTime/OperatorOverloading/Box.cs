namespace OperatorOverloading
{
     class Box
    {
        private double _length;
        private double _breath;
        private double _height;
        public Box()
        {

        }
       
        public Box(double length,double breath,double height)
        {
            _length = length;
            _breath = breath;
            _height = height;
        }
        public double CalculateVolume()
        {
            return _length*_breath*_height;

        }

        public static Box operator+ (Box box1,Box box2)
        {
            Box box = new Box();
            box._length = box1._length + box2._length;
            box._breath = box1._breath + box2._breath;
            box._height = box1._height + box2._height;
            return box;

        }
        public Box Add(Box box1,Box box2)
        {
            Box box = new Box();
            box._length = box1._length + box2._length;
            box._breath = box1._breath + box2._breath;
            box._height = box1._height + box2._height;
            return box;

        }
        
    }
}