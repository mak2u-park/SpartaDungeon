using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Laser : MonoBehaviour
{
    public float length = 5;
    public int damage;
    public float damageRate;
    
    private LineRenderer line;
    
    List<IDamagable> things = new List<IDamagable>();

    void Start()
    {
        line = GetComponent<LineRenderer>();
        line.enabled = true;
        
        InvokeRepeating("DealDamage", 0, damageRate);
    }

    void Update()
    {
        Vector3 startPos = transform.position;
        Vector3 endPos = startPos + transform.up * length;

        line.SetPosition(0, startPos);
        line.SetPosition(1, endPos);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out IDamagable damagable))
        {
            things.Add(damagable);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent(out IDamagable damagable))
        {
            things.Remove(damagable);
        }
    }

    void DealDamage()
    {
        for (int i = 0; i < things.Count; i++)
        {
            things[i].TakePhysicalDamage(damage);
        }
    }
}
