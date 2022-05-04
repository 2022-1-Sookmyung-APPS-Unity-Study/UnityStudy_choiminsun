using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = -5; i <= 5; i++)
            print(i);

        int j = 0;

        while (j <= 5)
        {
            j++;
            print(j);
        }

        for (int i = 1; i <= 100; i++)
        {
            if (i % 5 == 0 && i % 3 == 0)
                print(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
