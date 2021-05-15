using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TankStatsUI : MonoBehaviour
{
    [SerializeField]
    Text ammoUIText=null, gasolineUIText=null, hpUIText=null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    #region TankStatsUI

    public void SetAmmo(int ammoCount, int ammoMax)
    {
        ammoUIText.text = ammoCount.ToString()+"/"+ammoMax.ToString();
    }

    public void SetGasoline(float gasoline, float gasolineMax)
    {
        gasolineUIText.text = gasoline.ToString()+"/"+gasolineMax.ToString();
    }

    public void SetHP(float hp, float hpMax)
    {
        hpUIText.text = hp.ToString()+"/"+hpMax.ToString();
    }

    #endregion
}
