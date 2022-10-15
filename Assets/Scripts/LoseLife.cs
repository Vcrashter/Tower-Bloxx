using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseLife : MonoBehaviour
{
    [SerializeField] float life = 3f;

    public void OnCollisionEnter(Collision collision)
    {
        if (FindObjectOfType<ThrowLevel>())
        {
            life--;
        }

        if(life == 0)
        {
            Debug.Log("esti boss");
            Application.Quit();
        }
    }
}
