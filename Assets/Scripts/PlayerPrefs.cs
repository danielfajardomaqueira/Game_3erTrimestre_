using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerPrefs : MonoBehaviour
{

    public TMP_InputField inputField;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SaveData()
    {
        //PlayerPrefs.SetString("Input", inputField.text);
    }

    public void LoadData()
    {
        //inputField.text = PlayerPrefs.GetString("Input");
    }

    
}
