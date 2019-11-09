using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FeedTruck : MonoBehaviour
{
    public TruckMovement truckScript;
    public int compost;
    public Text compostText;
    // Start is called before the first frame update

    void Start()
    {
        
    }

    void Update()
    {
        compostText.text = "Compost: " + compost.ToString();
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if(other.GetComponent<TruckMovement>() && Input.GetKeyDown(KeyCode.E))
        {
            compost -= truckScript.Feeding(compost);
        }
    }
}
