using UnityEngine;

public class FlipSprite : MonoBehaviour
{
   void Start()
    {
        SpriteRenderer sr = GetComponent<SpriteRenderer>();

        if (sr != null)
        {
            sr.flipX = true;
        }
    }
}
