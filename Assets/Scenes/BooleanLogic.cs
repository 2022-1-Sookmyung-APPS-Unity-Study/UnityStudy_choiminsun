using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BooleanLogic : MonoBehaviour
{
    public int age1;
    public int age2;

    // Start is called before the first frame update
    void Start()
    {
        //problem1
        print((5 % 2 == 1 && 10 > 10) || (5 * 5 == 10 || "hey" == "hey"));

        //problem2
        print(("hello".Length >= 5 && 3.5f > 3.45f) && ("dragon".Length < 6 || "a" == "A"));

        //problem3
        string name = "bob";
        string color = "blue";
        print((name.Length > color.Length || name[0] == color[0]) || (name[2] == color[0] && 1 != 1));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
