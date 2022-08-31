using GetStarted_Types;

var p1 = new Point(0, 0);
var p2 = new Point(10, 20);

var pair = new TypeParameters<int, string>(1, "two");
int i = pair.First;     //TFirst int
string s = pair.Second; //TSecond string

Point a = new(10, 20);
Point b = new Point3D(10, 20, 30);