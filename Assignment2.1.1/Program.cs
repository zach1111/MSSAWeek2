/*
2.1.1 Design a class hierarchy of your choice. (Need only class files )
*/

/*
Hierarchy

GymEquipment

GymEquipment -> Machine

GymEquipment -> FreeWeight
GymEquipment -> FreeWeight -> Barbell
GymEquipment -> FreeWeight -> Dumbbell
GymEquipment -> FreeWeight -> WeightPlate

*/

Console.WriteLine(); //to validate program

public abstract class GymEquipment
{
    public int AssetID { get; set; }
    public string EquipmentName { get; set; }
    public double Weight { get; set; }
    public string Manufacturer { get; set; }
    public bool IsFunctional { get; set; }
}

public class Machine : GymEquipment
{
    public double SetWeightLow { get; set; }
    public double SetWeightHigh { get; set; }
    public string MuscleGroup { get; set; }
}


public abstract class FreeWeight : GymEquipment
{
    public double Diameter { get; set; }
}

public class Barbell : FreeWeight
{
    public double Length { get; set; }
    public bool IsMens { get; set; }
}

public class Dumbbell : FreeWeight
{
    public bool IsAdjustable { get; set; }
}

public class WeightPlate : FreeWeight
{
    public bool IsBumperPlate { get; set; }
}

