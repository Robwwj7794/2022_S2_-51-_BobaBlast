using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{
    //variables
    public GameObject[]  section;
    public int zPos = 50;
    public bool createSection = false;
    public int secNum;

    void Update()
    {
        //used to create sections then runs subroutine
        if(createSection == false)
        {
            createSection = true;

            StartCoroutine(GenerateSection());
        }
    }

    //subroutine to randomize the sections placed after 8 seconds then repeat
    IEnumerator GenerateSection()
    {
        secNum = Random.Range(0,3);
        Instantiate(section[secNum], new Vector3(0, 0, zPos), Quaternion.identity);
        zPos += 50;
        yield return new WaitForSeconds(8);
        createSection = false;
    }
}
