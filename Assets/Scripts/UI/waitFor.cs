using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waitFor : MonoBehaviour
{
    public static IEnumerator Frames(int frameCount)
    {
        while (frameCount > 0)
        {
            frameCount--;
            yield return null;
        }
    }
}
