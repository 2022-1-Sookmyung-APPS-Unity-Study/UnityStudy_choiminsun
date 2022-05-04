using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Challange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int sumArray(int[] arr)
    {
        int n = arr.Length;
        int sum = 0;

        for ( int i = 0; i <n; i++)
            sum += arr[i];

        return sum;

    }

    void PrintReverse(string[] arr)
    {
        for (int i = arr.Length; i >= 0; i--)
            print(arr[i]);
    }

    int Max(int[] arr)
    {
        int max = arr[0];
        int n = arr.Length;

        for (int i =  1; i <= n; i++)
        {
            if (arr[i] > max)
                max = arr[i];
        }

        return max;
    }

    bool IsUniform(string[] arr)
    {
        bool result = true;
        
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != arr[i])
            {
                result = false;
            }
        }

        return result;
    }
}
