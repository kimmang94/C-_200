namespace Property_
{
    internal class Program
    {
        class Rectangle
        {
            private double width;
            private double height;

            public double GetWidth() // Getter
            {
                return width;
            }

            public double GetHeight()
            {
                return height;
            }

            public void SetWidth(double width) // setter
            {
                if(width > 0)
                {
                    this.width = width;
                }
            }

            public void SetHeight(double height)
            {
                if (height > 0)
                {
                    this.height = height;
                }
            }
        }

        class RectWithProp
        {
            public double Width { get; set; } // Width 속성
            public double Height { get; set; } // Height 속성
        }

        class RecWithPropFull
        {
            private double width;

            public double Width
            {
                get { return width; }
                set { if (value > 0) width = value; }
            }

            private double height;
            public double Height
            {
                get { return height; }
                set { if (value >= 0) height = value; }
            }
        }
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.SetWidth(10.0);
            r.SetHeight(10.0);
            Console.WriteLine("r의 면적은 {0}", r.GetWidth() * r.GetHeight());

            RectWithProp r1 = new RectWithProp();
            r1.Width = 10.0;
            r1.Height = 10.0;
            Console.WriteLine("r1 의 면적은 {0}", r1.Width * r1.Height);

            RecWithPropFull r2 = new RecWithPropFull();
            r2.Width = 10.0;
            r2.Height = 10.0;
            Console.WriteLine("r2의 면적은 {0}", r2.Width * r2.Height);

            RecWithPropFull r3 = new RecWithPropFull();
            r3.Width = 10.0;
            r3.Height = -10.0;
            Console.WriteLine("r3의 면적은 {0}", r3.Width * r3.Height);
        }
    }
}
