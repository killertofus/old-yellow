using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Get_Money : MonoBehaviour
{
	public Text counterText;
	int Kills;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
       ShowKills(); 
    }
private void ShowKills()
{
	counterText.text = Kills.ToString();
}


public void Addkill()
{
	Kills++;
}
}
