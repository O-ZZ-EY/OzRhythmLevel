using System.Collections;
using UnityEngine;

public class MonstaScript : HazardController
{
    public override void DoAction(string act, float amt = 0)
    {
        if (act == "Pulse")
        {
            StartCoroutine(PulseCoroutine((int)amt));
        }
        else
        {
            base.DoAction(act, amt);
        }
    }

    private IEnumerator PulseCoroutine(float duration)
    {
        float bulletCount = 25;

        float anglePos = 360f / bulletCount;

        Quaternion originalRotation = transform.rotation;

        for (int i = 0; i < bulletCount; i++)
        {
            float angle = i * anglePos;

            transform.rotation = Quaternion.Euler(0, 0, angle);
            Shoot();
            Debug.Log("Pulsed");
        }

        transform.rotation = originalRotation;

        yield return null; 
    }

    
}
