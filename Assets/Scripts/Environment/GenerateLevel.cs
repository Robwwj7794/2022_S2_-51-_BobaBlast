using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{
    //variables
    public GameObject[]  section;
    public int zPos = 50;
    //public bool createSection = false;
    public int secNum;

    private void Start()
    {
        GenerateSection();
    }


    //subroutine to randomize the sections placed after 8 seconds then repeat
    public void GenerateSection()
    {
        secNum = Random.Range(0, section.Length);
        Instantiate(section[secNum], new Vector3(0, 0, zPos), Quaternion.identity);
        zPos += 50;
    }
}
