using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NurseryManagement : MonoBehaviour
{
    public int applesCost = 5;
    public int maxLevel = 4;
    public int houseLevelVal;

    // Start is called before the first frame update
    void Start()
    {
        houseLevelVal = 0;
    }

    public int Feedinga(int apples)
    {
        if ((apples >= applesCost) && (houseLevelVal < maxLevel))
        {
            StartCoroutine(WaitBeforeLevelUp());
            return applesCost;
        }
        else
        {
            return 0;
        }
    }
    private IEnumerator WaitBeforeLevelUp()
    {
        yield return new WaitForSeconds(3f);
        houseLevelVal++;
        applesCost = 5 * houseLevelVal;
    }
    public int HouseLevel()
    {
        return houseLevelVal;
    }
}
