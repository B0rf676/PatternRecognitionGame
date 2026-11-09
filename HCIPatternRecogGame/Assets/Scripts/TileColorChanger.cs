
using System.Collections;
using UnityEngine;

public class TileColorChanger : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        StartCoroutine(ChangeColor());
    }

    IEnumerator ChangeColor()
    {
        while (true)
        {
            // Wait a random amount of time between 1 and 3 seconds
            float waitTime = Random.Range(1f, 3f);
            yield return new WaitForSeconds(waitTime);

            // 50% chance of being white
            if (Random.value < 0.5f)
            {
                spriteRenderer.color = Color.white;
            }
            else
            {
                // Generate a random vibrant color
                float hue = Random.Range(0f, 1f);
                float saturation = Random.Range(0.7f, 1f);
                float brightness = Random.Range(0.7f, 1f);

                Color randomColor = Color.HSVToRGB(
                    hue, saturation, brightness
                );

                spriteRenderer.color = randomColor;
            }
        }
    }
}
