using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class volume : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider volSlider;
    void Start()
    {
        if(!PlayerPrefs.HasKey("musicVolume"))
        {
            PlayerPrefs.SetFloat("musicVolume",1);
            Load();
        }
        else
        Load();
    }

    public void ChangeVol()
    {
        AudioListener.volume= volSlider.value;
        Save();
    }
    public void Load()
    {
        volSlider.value= PlayerPrefs.GetFloat("musicVolume");
    }
    public void Save()
    {
        PlayerPrefs.SetFloat("musicvolume",volSlider.value);
    }
}
