using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseLife : MonoBehaviour
{
    [SerializeField] float life = 3f;
    List<GameObject> collisions = new List<GameObject>();

    public void OnCollisionEnter(Collision collision)
    {
        if(collisions.Contains(collision.gameObject))
        {
            return;
        }

        collisions.Add(collision.gameObject);

        if (FindObjectOfType<ThrowLevel>())
        {
            life--;
            Destroy(collision.gameObject, 3f);
        }

        if(life == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}