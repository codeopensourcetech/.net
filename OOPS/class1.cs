using System;
					
public class Program
{
	public static void Main()
	{
		bike bikeObject = new bike();		
		bikeObject.setWheelCount();
        bikeObject.SetYear();
		bikeObject.body = "White";
		Console.WriteLine(bikeObject.body + " " + bikeObject.Year + " vehicle has " + bikeObject.WheelCount + " wheels.");

        car carObject = new car();		
		carObject.setWheelCount();
        carObject.SetYear();
		carObject.body = "black";
		Console.WriteLine(carObject.body + " " + carObject.Year + " vehicle has " + carObject.WheelCount + " wheels.");

        //Sealed class instantiation.
        color sealedObject = new color{ body = "White"};
        Console.WriteLine(sealedObject.body);
	}	
}

//Below class cannot be inherited as it is marked as sealed but can be instantiated.
public sealed class color
{
    public string body;
    public string interior;
}

public class colour
{
    public string body;
    public string interior;
}

//Abstract class with common methods/properties.
public abstract class vehicle : colour
{
    public abstract void setWheelCount();
    public int WheelCount;
    public string Year;
    public void SetYear()
    {
        Year = "2000";
    }
}

public class car : vehicle
{
    public override void setWheelCount()
    {
        //set count to 4.
        WheelCount = 4;
    }

    public new void SetYear()
    {
        Year = "2018";
    }
}

public class bike : vehicle
{
    public override void setWheelCount()
    {
        //set count to 2.
        WheelCount = 2;
    }
}