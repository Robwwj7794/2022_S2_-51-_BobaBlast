using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SettingsMenu : MonoBehaviour
{
    //public Toggle fullscreenTog;

    public List<Res> resolutions = new List<Res>();
    private int selectedResolution;

    public TMP_Text resolutionLabel;

    // Start is called before the first frame update
    void Start()
    {
        //fullscreenTog.isOn = Screen.fullScreen;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ApplyGraphics()
    {
        Screen.SetResolution(resolutions[selectedResolution].horizontal, resolutions[selectedResolution].vertical, true);
        Debug.Log("Graphics applied: " + selectedResolution);
    }

    public void ResLeft()
    {
        selectedResolution--;
        if(selectedResolution < 0)
        {
            selectedResolution = 0;
        }

        UpdateResLabel();
    }

    public void ResRight()
    {
        selectedResolution++;
        if (selectedResolution > resolutions.Count - 1)
        {
            selectedResolution = resolutions.Count - 1;
        }

        UpdateResLabel();
    }

    public void UpdateResLabel()
    {
        resolutionLabel.text = resolutions[selectedResolution].horizontal.ToString() + " x " + resolutions[selectedResolution].vertical.ToString();    }
    }

[System.Serializable]
public class Res
{
    public int horizontal, vertical;
}
