using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timesetting : MonoBehaviour
{
    public Text ScriptTxt;

    int gold = 0;
    // Start is called before the first frame update
    void Start()
    {
        ScriptTxt.text = "0";
    }

    // Update is called once per frame
    public void numplus()
    {
        gold += 1;
        ScriptTxt.text = gold.ToString();
    }
    public void nummin()
    {

        gold -= 1;
        if (gold < 0)
            gold = 0;
        ScriptTxt.text = gold.ToString();
    }
}
