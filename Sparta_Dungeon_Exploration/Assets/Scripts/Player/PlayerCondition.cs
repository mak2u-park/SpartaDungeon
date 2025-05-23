using System;
using System.Collections;
using UnityEngine;

public class PlayerCondition : MonoBehaviour, IDamagable
{
    public UICondition uiCondition;

    Condition health { get { return uiCondition.health; } }
    Condition stamina { get { return uiCondition.stamina; } }
    
    public event Action onTakeDamage;
    
    Coroutine coroutine;

    private void Update()
    {
        stamina.Add(stamina.passiveValue * Time.deltaTime);

        if(health.curValue < 0f)
        {
            Die();
        }
    }

    public void Heal(float amount)
    {
        health.Add(amount);
    }
    
    public void Die()
    {
        Debug.Log("플레이어가 죽었다.");
    }
    
    public void TakePhysicalDamage(int damage)
    {
        health.Add(damage);
        onTakeDamage?.Invoke();
    }

    public void Speed(float speed, float duration)
    {
        if (coroutine != null) return;

        StartCoroutine(SpeedCoroutine(speed, duration));
    }

    private IEnumerator SpeedCoroutine(float speed, float duration)
    {
        float curSpeed = CharacterManager.Instance.Player.controller.moveSpeed;
        float upSpeed = curSpeed + speed;
        CharacterManager.Instance.Player.controller.moveSpeed = upSpeed;
        
        yield return new WaitForSeconds(duration);
        CharacterManager.Instance.Player.controller.moveSpeed = curSpeed;
    }
}