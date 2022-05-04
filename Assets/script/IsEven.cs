using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsEven : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    bool isEven(int n)
    {
        if (n % 2 == 0)
            return true;
        return false;
    }

    int WhatIsBigger(int x, int y)
    {
        if (x > y)
            return x;
        else
            return y;
    }

    void Repeat(string s, int n)
    {  
        while (n>0)
        {
            print(s);
            n--;
        }
    }

    int Factorial(int n)
    {
        int sum = 1;

        while(n > 0)
        {
            sum *= n;
            n--;
        }

        return sum;
    }

}
