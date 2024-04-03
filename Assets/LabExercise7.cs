using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LabExercise7 : MonoBehaviour
{
 
    bool IsSorted(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            
            if (array[i] <  array[i + 1])
            {
                return false;
            }
           
        }
        return true;
    }
    int Find(int number, int[] array)

    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] == number)
            {
                return i;
            }

        }
        Debug.Log("nothing");
        return -1;
    }
    void Start()
    {
        int[] Numbers = { 1, 3, 5, 4, 2, 0, -1 };
        bool Sort = IsSorted(Numbers);
        Debug.Log("check for sorted or no " + Sort);
        int index = Find(4, Numbers);
        if (index != -1)
        {
            Debug.Log("the 4 is in index " + index);
        }
        else
        {
            Debug.Log("something is wrong");
        }
}
}
