using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterfaceController : MonoBehaviour
{
    private PlayerController scriptPlayerController;
    public GameObject textGold;

    // Start is called before the first frame update
    void Start()
    {
        scriptPlayerController = GameObject.FindWithTag("Player").GetComponent<PlayerController>();
        textGold.GetComponent<Text>().text = "Gold: " + scriptPlayerController.gold;
    }

    // Update is called once per frame
    void Update()
    {
        textGold.GetComponent<Text>().text = "Gold: " + scriptPlayerController.gold;
    }
}
