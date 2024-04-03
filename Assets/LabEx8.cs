using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic;

// Kourosh Kalatian 101438689
public class LabEx8 : MonoBehaviour
{

    List<int> numbers = new List<int>(10);
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            numbers.Add(i * 2);
            Debug.Log(" before doubling the numbers:");
            PrintList(numbers);
            
            DoubleEvenNum(numbers);
            Debug.Log("after doubling even numbers: ");
            PrintList(numbers);
        }
    }
    void DoubleEvenNum(List<int> numbers)
    {
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                numbers[i] *= 2;
            }

        }
    }

    void PrintList(List<int> numbers)
    {
        foreach (int i in numbers)
        {
            Debug.Log(i);
        }
    }
}
