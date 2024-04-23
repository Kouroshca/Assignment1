using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;
// Kourosh Kalatian 101438689
public abstract class Polygon
{
    public abstract float Area();
    public string ShapeName()
    {
        return "";
    }
}
public class Sqaure : Polygon
{
    private float a;
    public Sqaure (float sideLenght = 0)
    {
        a = sideLenght;
    }
    public override float Area()
    {
        return a*a;
    }
    public string ShapeName()
    {
        return "Sqaure";
    }
}
public class Triangle : Polygon
{
    private float a;
    private float h;
    public Triangle(float sideLenght = 0, float height =0 )
    {
        a = sideLenght;
        h = height;
    }
    public override float Area()
    {
       float area = (a*h)/2;
       return area;
    }
    public string ShapeName()
    {
        return "Triangle";
    }
}

public class LabTest4 : MonoBehaviour
{
    void Start()
    {
        Sqaure sqaure1= new Sqaure(5);
        Triangle triangle1 = new Triangle(4,3);

     Debug.Log("Area of sqaure 1: " + sqaure1.Area());
     Debug.Log("Name of the sqaure: " + sqaure1.ShapeName());

     Debug.Log("Area of Triangle: " + triangle1.Area());
     Debug.Log("Area of Triangle: " + triangle1.ShapeName());
    }
}
