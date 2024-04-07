using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

 public class myclass
    {
        public float num1, num2;
        public string text1, text2;
        public bool IsAlive;

        public void fun1()
        {
            Debug.Log("the first number is " + num1);
        }

        public void fun2()
        {
            Debug.Log(" the second number is " + num2);
        }

        public void fun3()
        {
            Debug.Log(" the first string is " + text1);
        }

        public void fun4()
        {
            Debug.Log(" the second string is " + text2);
        }

        public void fun5()
        {
            Debug.Log(" the first boolean is " + IsAlive);
        }
}
public class LabEx9 : MonoBehaviour
{
    void Start()
    {
        myclass myclass = new myclass();
        myclass.num1 = UnityEngine.Random.Range(0, 11);
        myclass.num2 = UnityEngine.Random.Range(-11, 0);
        myclass.text1 = "Hello my name is Kourosh";
        myclass.text2 = "what is your name? ";
        myclass.IsAlive = true;
        myclass.fun1();
        myclass.fun2();
        myclass.fun3();
        myclass.fun4();
        myclass.fun5();
    }
}
