namespace OopIntro;
internal class Car
{
    private string _brand;
    public string Brand
    {
        get { return _brand; }
        set { _brand = value; }
    }
    private int _tankCapacity;
    public int TankCapacity
    {
        get { return _tankCapacity; }
        set { _tankCapacity = value; }
    }
    private double _currentGas;
    public double CurrentGas
    {
        get { return _currentGas; }
        set
        {
            if (value >= 0 && value <= _tankCapacity)
            {
                _currentGas = value;
            }
        }
    }
    private double _consumption;
    private string _licencePlate;
    public string LicencePlate
    {
        get { return _licencePlate; }
        set { _licencePlate = value; }
    }

    public Car(
        int tankCapacity,
        double currentGas,
        double consumption,
        string licencePlate
        )
    {
        if (tankCapacity > 0)
        {
            _tankCapacity = tankCapacity;
        }
        _currentGas = currentGas;
        _licencePlate = licencePlate;
        _currentGas = currentGas;
    }

    public void TurnOn()
    {
        Console.WriteLine(_tankCapacity);
    }
}
