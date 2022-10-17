using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StayOnBlock : MonoBehaviour
{
    List<GameObject> gameObjects = new List<GameObject>();

    private void OnCollisionEnter(Collision collision)
    {
        if(gameObjects.Contains(collision.gameObject))
        {
            float dist = Vector3.Distance(this.gameObject.transform.position, gameObject.transform.position);
            Debug.Log("Distance to other: " + dist);
        }
    }
}