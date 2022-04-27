using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Condition : MonoBehaviour
{
    public int number1;
    public int number2;

    public string action;

    // Start is called before the first frame update
    void Start()
    {
        if (action == "add")
        {
            print(number1 + number2);
        } else if (action == "subtract")
        {
            print(number1 - number2);
        } else if (action== "muliply")
        {
            print(number1 * number2);
        } else if (action == "divide")
        {
            if (number2 != 0)
            {
                print(number1 / number2);
            } else
            {
                print("You can not divide by 0.");
            }
        } else
        {
            print("The action does not exist.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
