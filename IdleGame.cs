using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using BreakInfinity;
using static BreakInfinity.BigDouble;
using TMPro;

public class IdleTutorialGame : MonoBehaviour
{

    [SerializeField] public TMP_Text MoneyText;
    public BigDouble Moneys;
    public BigDouble MoneyPerSecond;
    public BigDouble Generator1Power;
    public BigDouble Generator2Power;
    public BigDouble Generator3Power;

    public void Start()
    {
        Moneys =0 ;
        MoneyPerSecond = 0;
        Generator1Power = 1;
        Generator2Power = 1;
        Generator3Power = 1;
        Generator1Power = BigDouble.Pow(10, 55000);
    }

    public void Update()
    {
        MoneyPerSecond = Generator1Power + Generator2Power + Generator3Power;
        MoneyText.text = "Money : " + Moneys;
        Moneys += MoneyPerSecond * Time.deltaTime;
        Moneys *= 100;
    }
}
