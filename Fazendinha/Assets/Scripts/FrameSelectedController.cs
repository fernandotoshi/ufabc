using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameSelectedController : MonoBehaviour
{
    public GameObject player;
    private Vector3 distCompen;
    public Vector3 positionSelected;
    public GameObject currentSquare;

    // Start is called before the first frame update
    void Start()
    {
        currentSquare.transform.position = positionSelected;
        distCompen = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + distCompen;
        float posX;
        float posZ;

        if (transform.position.x >= 0)
        {
            posX = (int)transform.position.x + 0.5f;
        } else
        {
            posX = (int)transform.position.x - 0.5f;
        }

        if (transform.position.z >= 0)
        {
            posZ = (int)transform.position.z + 0.5f;
        } else
        {
            posZ = (int)transform.position.z - 0.5f;
        }

        positionSelected = new Vector3(posX, 0.05f, posZ);
        currentSquare.transform.position = positionSelected;
    }

    
}
