using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class PlayerStats : MonoBehaviour
{
    public float MaxLife;
    [HideInInspector] public float CurrentLife;
    [HideInInspector] public bool IsDead;

    [SerializeField] private Image _lifeBarPlayer;
    [SerializeField] private GameObject _playerVisual;

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
        FxDamage();
        _lifeBarPlayer.fillAmount = CurrentLife / MaxLife;
        CheckLife();
    }

    private void Start()
    {
        CurrentLife = MaxLife;
        IsDead = false;
    }
    private void FxDamage()
    {
        _playerVisual.transform.DOComplete();
        _playerVisual.transform.DOPunchScale(new Vector3(0.5f, 0.5f, 0), 0.3f, 2, 0.3f);
    }
}