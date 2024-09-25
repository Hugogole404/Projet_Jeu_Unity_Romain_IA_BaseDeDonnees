using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.UI;

public class ButtonsTests : MonoBehaviour
{
    [SerializeField] private int _quantity;

    [SerializeField] private PlayerStats _playerStats;

    public void OnClickButton()
    {
        if (!_playerStats.IsDead)
        {
            _playerStats.CurrentLife += _quantity;
            _playerStats.ChangePlayerLife();
        }
        else 
        {
            Debug.Log("The player is dead");
        }
    }
}