
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
// kourosh kalatian 101438689
public class LabTest3 : MonoBehaviour
{
    List<int> intitList(int noElements = 10)
    {
        List<int> newList = new List<int>();
        for (int i = 0; i < noElements; i++)
        {
            newList.Add(UnityEngine.Random.Range(1, 101));
        }
        return newList;
    }

    void doubleAll(List<int> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            list[i] *= 2;
        }
    }

    int sumOdd(List<int> list)
    {
        int sumO = 0;
        foreach (int i in list)
        {
            if (i % 2 != 0)
            {
                sumO += i;
            }
        }
        return sumO;
    }

    List<int> getHighLowEven(List<int> list)
    {
        List<int> result = new List<int>();
        List<int> evenNumber = new List<int>();

        foreach (int num in list)
        {
            if (num % 2 == 0)
            {
                evenNumber.Add(num);
            }
        }

        if (evenNumber.Count == 0)
        {
            Debug.Log("There are no even numbers.");
            return result;
        }
        else
        {
            int maxEven = evenNumber[0];
            int minEven = evenNumber[0];

            foreach (int num in evenNumber)
            {
                if (num > maxEven)
                {
                    maxEven = num;
                }
                if (num < minEven)
                {
                    minEven = num;
                }
            }

            result.Add(maxEven);
            if (maxEven != minEven)
            {
                result.Add(minEven);
            }
            return result;
        }
    }

    List<int> skipBy(List<int> list, int Step)
    {
        List<int> result = new List<int>();
        for (int i = 0; i < list.Count; i += Step)
        {
            result.Add(list[i]);
        }
        return result;
    }

    void Start()
    {
        List<int> mainList = intitList(10);
        Debug.Log("Original list: " + string.Join(", ", mainList));

        doubleAll(mainList);
        Debug.Log("Original list after duplication: " + string.Join(", ", mainList));

        int sumO = sumOdd(mainList);
        Debug.Log("Sum of odd numbers: " + sumO);

        List<int> highlowEven = getHighLowEven(mainList);
        if (highlowEven.Count > 0)
        {
            Debug.Log("The highest and lowest even numbers are: " + string.Join(",", highlowEven));
        }

        int step = 2;
        List<int> skippedList = skipBy(mainList, step);
        Debug.Log("List after skip function with steps " + step + ": " + string.Join(", ", skippedList));
    }
}

