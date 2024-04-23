using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class absClass
{
    public abstract void fun1();
    public abstract void fun2();
}
public class Class1 : absClass
{
    public override void fun1()
    {
        Debug.Log("Hello world !!!");
    }
    public override void fun2()
    {
        Debug.Log("Good bye World :(");
    }
}
public class Class2 : absClass
{
    public override void fun1()
    {
        Debug.Log("Hello world !!!");
    }
    public override void fun2()
    {
        Debug.Log("Good bye World :(");
    }
}
public class Class3 : absClass
{
     public override void fun1()
    {
        Debug.Log("Hello world !!!");
    }
    public override void fun2()
    {
        Debug.Log("Good bye World :(");
    }
}
public class LabEx10 : MonoBehaviour
{
    void Start()
    {
        absClass obj1 = new Class1();
        absClass obj2 = new Class2();
        absClass obj3 = new Class3();
        obj1.fun1();
        obj2.fun1();
        obj3.fun1();
        obj1.fun2();
        obj2.fun2();
        obj3.fun2();

    }
}

