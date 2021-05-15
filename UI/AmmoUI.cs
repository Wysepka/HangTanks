using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoUI : MonoBehaviour
{
    [SerializeField]
    Text iloscAmmoText=null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetAmmo(int obecnaIlosc, int iloscMax)
    {
        iloscAmmoText.text = obecnaIlosc.ToString() + "/" + iloscMax.ToString();
    }
}
