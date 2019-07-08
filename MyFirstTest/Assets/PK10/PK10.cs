using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PK10 : MonoBehaviour
{
    public PaiHang _1 = new PaiHang();
    public PaiHang _2 = new PaiHang();
    public PaiHang _3 = new PaiHang();
    public PaiHang _4 = new PaiHang();
    public PaiHang _5 = new PaiHang();
    public PaiHang _6 = new PaiHang();
    public PaiHang _7 = new PaiHang();
    public PaiHang _8 = new PaiHang();
    public PaiHang _9 = new PaiHang();
    public PaiHang _0 = new PaiHang();
    public InputField input;
    int num0;
    int num1;
    int num2;
    int num3;
    int num4;
    int num5;
    int num6;
    int num7;
    int num8;
    int num9;
    int[] pre = new int[10];
    public string number;
    void Start()
    {
        input.onEndEdit.AddListener(inputend);
       
    }

    void set()
    {
        pre[0] = num0;
        pre[1] = num1;
        pre[2] = num2;
        pre[3] = num3;
        pre[4] = num4;
        pre[5] = num5;
        pre[6] = num6;
        pre[7] = num7;
        pre[8] = num8;
        pre[9] = num9;
        Array.Sort(pre);
        string s = "";
        foreach (var item in pre)
        {
           

        }
    }

    private void inputend(string arg0)
    {
        _1.result.Add(int.Parse(arg0.Substring(0, 1)));
        _2.result.Add(int.Parse(arg0.Substring(1, 1)));
        _3.result.Add(int.Parse(arg0.Substring(2, 1)));
        _4.result.Add(int.Parse(arg0.Substring(3, 1)));
        _5.result.Add(int.Parse(arg0.Substring(4, 1)));
        _6.result.Add(int.Parse(arg0.Substring(5, 1)));
        _7.result.Add(int.Parse(arg0.Substring(6, 1)));
        _8.result.Add(int.Parse(arg0.Substring(7, 1)));
        _9.result.Add(int.Parse(arg0.Substring(8, 1)));
        _0.result.Add(int.Parse(arg0.Substring(9, 1)));
        input.text = "";
    }


  
   
}
