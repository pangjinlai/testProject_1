using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaiHang 
{
    public List<int> result;

    public PaiHang()
    {
        result= new List<int>();
    }
    public void ADD(int a)
    {
        result.Add(a);
    }
    /// <summary>
    /// 检查次数
    /// </summary>
    /// <param name="number"></param>
    public int CheekTimes(int number)
    {
        int times = 0;
        for (int i = 0; i < result.Count; i++)
        {
            if (result[i] != number)
            {
                times++;
            }
        }
        return times;
    }
    /// <summary>
    /// 检查连续
    /// </summary>
    /// <param name="number"></param>
    /// <returns></returns>
    public int CheekLianXu(int number)
    {
        int last = 0;
       
        for (int i = 0; i < result.Count; i++)
        {
            if (result[i] == number)
            {
                last = i;
            }
           
        }
        return result.Count - 1 - last;
    }
}
