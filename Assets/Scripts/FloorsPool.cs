using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorsPool : MonoBehaviour
{
    public GameObject otherFloor;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(otherFloor);
        }
    }

}