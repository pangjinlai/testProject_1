using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TimeScalesCom : MonoBehaviour
{

    public Text texte;
   static int i=1;
    bool b=true;
    public static int I { get => i; set => i = value; }

    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift)&&Input.GetKeyUp(KeyCode.Home))
        {
        
            i+=3;
            TimeScales(i);
        }
        if (Input.GetKey(KeyCode.LeftShift)&&Input.GetKeyUp(KeyCode.End))
        {
            if (i<=1)
            {
                texte.enabled = false;
                return;
            }
            else
            {
                  i--;
            }
           
            TimeScales(i);
        }
        if (Input.GetKey(KeyCode.LeftShift)&&Input.GetKeyUp(KeyCode.Delete))
        { 
            texte.enabled = false;
            Time.timeScale = 1;
            i = 1;
        }
   
        if (Input.GetKeyDown(KeyCode.Pause))
        {
            b = true;
            if (b)
            {
             Time.timeScale = 0;
             b = false;
                
            }
        }
    }
    private  void TimeScales(int times)
    {
        texte.enabled = true;
    
        Time.timeScale = times;
        texte.text = Time.timeScale.ToString();
    }
}
