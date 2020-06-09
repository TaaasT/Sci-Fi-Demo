using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private Text _ammoText;
    [SerializeField]
    private GameObject _coin;

    private void Start()
    {
        _ammoText.enabled = false;
    }

    public void UpdateAmmo(int count)
    {
        _ammoText.text = "Ammo: " + count; 
    }

    public void CollectedCoin()
    {
        _coin.SetActive(true);
    }

    public void RemoveCoin()
    {
        _coin.SetActive(false);
    }

    public void EnableAmmoText()
    {
        _ammoText.enabled = true;
    }

}
