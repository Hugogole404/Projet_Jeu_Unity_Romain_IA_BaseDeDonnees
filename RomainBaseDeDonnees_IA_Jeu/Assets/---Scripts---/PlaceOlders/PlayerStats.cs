using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public float MaxLife;
    [HideInInspector] public float CurrentLife;
    [HideInInspector] public bool IsDead;

    [SerializeField] private Image _lifeBarPlayer;

    public void CheckLife()
    {
        if (CurrentLife <= 0)
        {
            IsDead = true;
        }
        if (CurrentLife > MaxLife) 
        {
            CurrentLife = MaxLife;
        }
    }

    
    public void ChangePlayerLife()
    {
        _lifeBarPlayer.fillAmount = CurrentLife / MaxLife;

        CheckLife();
    }
    private void Start()
    {
        CurrentLife = MaxLife;
        IsDead = false;
    }
}