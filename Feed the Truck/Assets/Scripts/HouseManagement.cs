using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseManagement : MonoBehaviour
{
    public int houseLevel = 0;
    public float cps = 2;
    public CompostManagement compostScript;

    public Sprite[] houseSprites = new Sprite[5];

    public NurseryManagement nurseryScript;

    private float waitingCompost = 0;
    private int oldHouseLevel;
    private SpriteRenderer houseRenderer;

    // Start is called before the first frame update
    void Start()
    {
        houseRenderer = GetComponent<SpriteRenderer>();

        oldHouseLevel = 0;
    }

    // Update is called once per frame
    void Update()
    {
        waitingCompost += cps * Time.deltaTime;
        if(waitingCompost > 5)
        {
            compostScript.AddCompost(System.Convert.ToInt32(waitingCompost));
            waitingCompost = 0;
        }

        houseLevel = nurseryScript.HouseLevel(); 

        if (houseLevel != oldHouseLevel)
        {
            oldHouseLevel = houseLevel;
            houseRenderer.sprite = houseSprites[houseLevel];
        }
    }
}
