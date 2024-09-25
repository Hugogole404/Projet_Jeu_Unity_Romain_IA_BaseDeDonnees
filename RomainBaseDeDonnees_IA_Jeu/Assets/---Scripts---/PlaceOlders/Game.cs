using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] private PlayerStats _playerStats;

    private void Update()
    {
        if (_playerStats.IsDead) Debug.Log("GAME OVER");
    }
}