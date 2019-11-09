using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{
    private Feed feedScript;
    // Start is called before the first frame update
    void Start()
    {
        feedScript = GetComponent<Feed>();   
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.GetComponent<AppleMovement>())
        {
            feedScript.apples += other.gameObject.GetComponent<AppleMovement>().collectValue;
            Destroy(other.gameObject);
        }   
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (other.gameObject.GetComponent<CompostManagement>())
            {
                feedScript.compost += other.gameObject.GetComponent<CompostManagement>().RemoveCompost();
            }
            if (other.gameObject.GetComponent<TreeManagement>())
            {
                feedScript.compost -= 
                    other.gameObject.GetComponent<TreeManagement>().LevelUp(feedScript.compost);
            }
        }
    }
}
