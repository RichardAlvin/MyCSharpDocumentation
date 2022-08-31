Classes define types that support inheritance and polymorphism

By Contrast,

Struct simpler types
Structs can't declare base type
can't derive other struct types from a struct type

public struct Point
{
}


Interfaces a contract that can be implementetd by classes and structs

Classes and structs can implement multiple interfaces

public class EditBox : IControl, IDataBound{

}

EditBox editBox = new();
IControl control = editBox;
IDataBound dataBound = editBox;


An Enum type defines a set of constant values

public enum SomeRootVegetable
{
    HorseRadish,
    Radish,
    Turnip
}

Nullable Types
Tuples