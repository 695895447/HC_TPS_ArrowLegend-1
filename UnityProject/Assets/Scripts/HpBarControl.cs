﻿using UnityEngine;
using UnityEngine.UI;

public class HpBarControl : MonoBehaviour
{
    private Image imgHp;
    private Text textHp;

    private void Start()
    {
        imgHp = transform.GetChild(1).GetComponent<Image>();
        textHp = transform.GetChild(2).GetComponent<Text>();
    }

    private void Update()
    {
        AngleControl();
    }

    /// <summary>
    /// 角度控制：讓血條保持世界座標角度為原本角度 35, -180, 0
    /// </summary>
    private void AngleControl()
    {
        // 變形元件.歐拉角度 = 新 三維向量() - 世界座標
        //transform.localEulerAngles         - 區域座標
        transform.eulerAngles = new Vector3(35, -180, 0);
    }

    /// <summary>
    /// 更新血條圖片長度與文字內容，需要提供最大與目前血量
    /// </summary>
    /// <param name="hpMax">最大血量</param>
    /// <param name="hpCurrent">目前血量，受傷後的血量</param>
    public void UpdateHpBar(float hpMax, float hpCurrent)
    {
        imgHp.fillAmount = hpCurrent / hpMax;       // 圖片.填滿數值 = 目前 / 最大
        textHp.text = hpCurrent.ToString();         // 文字.文字內容 = 目前.轉字串()
    }
}