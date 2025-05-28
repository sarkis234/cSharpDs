namespace ClassLib
{
    
    public class Class1
    {

    }

    public class PC
    {
        private string color;
        private int series;
        private string brand;
        private int price;
        private bool isEnabled;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public int Series
        {
            get { return series; }
            set { series = value; }
        }
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        public bool IsEnabled
        {
            get { return isEnabled; }
            set { isEnabled = value; }
        }

        public PC()
        {
            color = "white";
            series = 1000;
            brand = "Apple";
            price = 75000;
            isEnabled = false;
        }
        public PC(string color, int series, string brand, int price, bool isEnabled)
        {
            this.color = color;
            this.series = series;
            this.brand = brand;
            this.price = price;
            this.isEnabled = isEnabled;
        }
        public void on()
        {
            this.isEnabled = true;
        }
        public void off()
        {
            this.isEnabled = false;
        }

    }

}