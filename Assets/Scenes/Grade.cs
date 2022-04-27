using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grade : MonoBehaviour
{
    [Range(0, 100)]
    public int score;

    // Start is called before the first frame update
    void Start()
    {
        if (score > 90)
        {
            print("You got an A.");
        } else if (score > 80){
            print("You got an B.");
        }
        else if (score > 70)
        {
            print("You got an C.");
        }
        else if (score > 65)
        {
            print("You got an D.");
        }
        else
        {
            print("You got an E.");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
