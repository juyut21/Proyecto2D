using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DataCoin : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    // Start is called before the first frame update
    void Start()
    {
        textMeshPro.text = PlayerPrefs.GetInt("Score", 0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
