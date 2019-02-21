using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{

    public float[] wave;

    public int freq;
    public float tollerance;
    public float freq_level;
    public int height;

    

    public float max;
    public float min;

    Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.material.SetFloat("_Intensity", 1);
      
        rend.material.SetColor("_Color", new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f)));
    }

    // Update is called once per frame
    void Update()
    {
        freq_level = wave[freq];

        if (freq_level + tollerance > max)
        {
            max = freq_level;

            rend.material.SetFloat("_Jump", wave[freq] * (-height));

        }
        else
        {
            rend.material.SetFloat("_Jump", 0);
        }
       


        if (freq_level - tollerance < min)
        {
            min = freq_level;

            rend.material.SetFloat("_Jump", wave[freq] * (-height));

        }
        else
        {
            rend.material.SetFloat("_Jump", 0);
        }

    }
}
