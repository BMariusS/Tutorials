namespace Record;

// Comment version for positional syntax
// public record CoordsRecordClass(double X, double Y);

public record CoordsRecordClass
{
    public CoordsRecordClass(double x, double y)
    {
        X = x;
        Y = y;
    }
    
    // Comment version for mutable record class
    // public double X { get; set; }
    // public double Y { get; set; }
    
    public double X { get; set; }
    public double Y { get; set; }
}






