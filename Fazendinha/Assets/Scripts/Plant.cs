using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant : MonoBehaviour
{
    private float timeToReady;
    private bool readyToHarvest;
    private GameObject player;
    private int sellPrice;
    private int buyPrice;

    // Start is called before the first frame update
    void Start()
    {
        timeToReady = 10;
        readyToHarvest = false;
        player = GameObject.FindGameObjectWithTag("Player");
        sellPrice = 15;
        buyPrice = 1;
        player.GetComponent<PlayerController>().gold -= buyPrice;
    }

    void FixedUpdate()
    {
        if(timeToReady >= 0)
        {
            timeToReady -= Time.deltaTime;
        }
        else
        {
            transform.localScale = new Vector3(1, 1, 1);
            transform.position = new Vector3(transform.position.x, 0.5f, transform.position.z);
            readyToHarvest = true;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(Input.GetButtonDown("Fire1") && readyToHarvest)
        {
            if (other.tag == "Player")
            {
                harvest();
            }
        }
    }

    public void harvest()
    {
        Destroy(gameObject, 1f);
        player.GetComponent<PlayerController>().gold += sellPrice;
    }
}
