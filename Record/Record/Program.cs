using Record;


var coordsRecordClass = new CoordsRecordClass(12, 50);
var coordsRecordClass2 = new CoordsRecordClass(12, 50);
var coordsRecordClass3 = new CoordsRecordClass(70, 50);

var coordsClass = new CoordsClass(12, 50);
var coordsClass2 = new CoordsClass(12, 50);

Console.WriteLine(coordsRecordClass.ToString());
Console.WriteLine(coordsClass.ToString());

Console.WriteLine($"coordsRecordClass == coordsRecordClass2 - {coordsRecordClass == coordsRecordClass2}" );
Console.WriteLine($"coordsRecordClass == coordsRecordClass3 - {coordsRecordClass == coordsRecordClass3}" );
Console.WriteLine($"coordsRecordClass.Equals(coordsRecordClass2) - {coordsRecordClass.Equals(coordsRecordClass2)}" );
Console.WriteLine($"coordsRecordClass.Equals(coordsRecordClass3) - {coordsRecordClass.Equals(coordsRecordClass3)}" );

Console.WriteLine($"coordsClass == coordsClass2 - {coordsClass == coordsClass2}" );
Console.WriteLine($"coordsClass.Equals(coordsClass2) - {coordsClass.Equals(coordsClass2)}" );


// Comment version for immutable struct

// var coordsRecordStruct = new CoordsRecordStruct(25, 50);
// Console.WriteLine(coordsRecordStruct.X);
// coordsRecordStruct.X = 70;
// Console.WriteLine(coordsRecordStruct.X);


var coordsRecordStruct = new CoordsRecordStruct(25, 50);
Console.WriteLine(coordsRecordStruct.X);
coordsRecordStruct.X = 70;
Console.WriteLine(coordsRecordStruct.X);

var newCoordsRecordClassClass = coordsRecordClass with { Y = 65 };
Console.WriteLine($"coordsRecordClass = {coordsRecordClass}");
Console.WriteLine($"newCoordsRecordClassClass = {newCoordsRecordClassClass}");






