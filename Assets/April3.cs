using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
public class April3 : MonoBehaviour
{
    public TextMeshProUGUI areaText;
    public class Circle
    {
        public float radius;
        public Vector2 Position;
        public float Area()
        {
            float area = Mathf.PI * radius * radius;
            Debug.Log("the area is equal to" + area);
            return area;
     }
    }
    void Start()
    {
        Circle circle = new Circle();
        circle.radius = UnityEngine.Random.Range(0,30);
        circle.Position = new Vector2(3,4);
        Debug.Log("the area of the circle is"  +   circle.Area());
        Debug.Log("the radius was " + circle.radius);
        
    }

}
