using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantController : MonoBehaviour
{
    public GameObject plant;
    public GameObject frameSelected;
    private bool canPlant;

    private void Start()
    {
        canPlant = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && canPlant)
        {
            Instantiate(plant, frameSelected.GetComponent<FrameSelectedController>().positionSelected, frameSelected.transform.rotation);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Plant")
        {
            canPlant = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Plant")
        {
            canPlant = true;
        }
    }
}
