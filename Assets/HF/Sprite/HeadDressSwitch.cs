using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadDressSwitch : MonoBehaviour
{
    // 在Inspector里，把4朵花的物体拖进这个数组
    public GameObject[] headDressList;

    // 按钮绑定的方法
    public void ChangeDress(int index)
    {
        Debug.Log("进来了!序号"+index);
        // 先把所有头饰隐藏
        foreach (GameObject dress in headDressList)
        {
            dress.SetActive(false);
        }
        // 只显示选中的那一个
        if (index >= 0 && index < headDressList.Length)
        {
            headDressList[index].SetActive(true);
        }
    }
}