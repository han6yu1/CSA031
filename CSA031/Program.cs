static void Main(string[] args)

    Wanted<string> wantedString = new Wanted<string>("string");
    Wanted<int> wantedint = new Wanted<int>(52273);
    Wanted<double> wantedDouble = new Wanted<double>(52.273);

    class Product
{
    public int this[int i]
    {
        get { return i; }
        set { Console.WriteLine("{0}번째 상품 설정", i); }
    }
}