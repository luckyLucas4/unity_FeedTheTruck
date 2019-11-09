using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Feed : MonoBehaviour
{
    public TruckMovement truckScript;
    public NurseryManagement nurseryScript;
    public int compost;
    public int apples;
    public Text compostText;
    // Start is called before the first frame update

    void Start()
    {
        
    }

    void Update()
    {
        compostText.text = "Compost: " + compost.ToString() + " Apples: " + apples.ToString();
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            if(other.GetComponent<TruckMovement>())
                compost -= truckScript.Feeding(compost);
            if (other.GetComponent<NurseryManagement>())
                apples -= nurseryScript.Feedinga(apples);
            if (other.GetComponent<AirTreeManagement>())
                apples -= other.gameObject.GetComponent<AirTreeManagement>().FeedingairTree(apples);
        }
    }
}
