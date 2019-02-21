using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShaderScript : MonoBehaviour
{

    Texture2D tex;
    public float[] wave;
    public int f1;
    public float t1;
    public float level_curren_f;
    Color c;
    Renderer rend;


    // Start is called before the first frame update
    void Start()
    {
        c = new Color(1, 0, 0, 0);
        rend = GetComponent<Renderer>();
        rend.material.SetColor("_Color", new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f)));
    }

    // Update is called once per frame
    void Update()
    {
        //tex = new Texture2D(32, 30);

        //for (int i = 0; i < 32; i++)
        //{
        //    int y = Mathf.RoundToInt(wave[i]*1000) + 15;
        //    tex.SetPixel(i, y, c);
        //}

        level_curren_f = wave[f1];

        if (wave[f1] > t1)
        {

            rend.material.SetFloat("_Intensity", wave[f1]*1000);

        }
        else
        {
            rend.material.SetFloat("_Intensity", wave[f1]*(-1000));
        }

        

    }
}
