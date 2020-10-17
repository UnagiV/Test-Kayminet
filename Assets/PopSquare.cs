using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopSquare : MonoBehaviour
{

    public GameObject RightSqare;
    public GameObject LeftSquare;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("left"))
        {
            LeftSquare.SetActive(true);
            RightSqare.SetActive(false);

            //do some code for sound effect
        }

        if (Input.GetKey("right"))
        {
            LeftSquare.SetActive(false);
            RightSqare.SetActive(true);

            //do some code for sound effect
        }
    }
}
