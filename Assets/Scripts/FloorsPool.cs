using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FloorsPool : MonoBehaviour
{
    public GameObject otherFloor;
    public TextMeshProUGUI floorLevel;

    public int yOffset;
    private int counter;
    private bool canCreate = true;

    private void Awake()
    {
        UpdateDisplay();
    }

    void Update()
    {
        CreatePossibility();
        UpdateDisplay();
    }

    private void CreatePossibility()
    {
        if (canCreate)
        {
            float xOffset = Random.Range(-1f, 1f);
            Vector3 offset = new Vector3(xOffset, yOffset + counter, 0);
            counter++;
            var towerLevel = Instantiate(otherFloor, offset, Quaternion.identity);
            towerLevel.GetComponent<ThrowLevel>().AssignFloorPool(this);
            canCreate = false;
        }
    }

    void UpdateDisplay()
    {
        floorLevel.text = "Floor:" + counter;
    }

    public void MakeTrue()
    {
        canCreate = true;
        Camera.main.transform.DOMoveY(Camera.main.transform.position.y + 1, 0.5f);
    }
}