using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{

    Renderer rend;
    AudioProcessor processor;
    Color color;
    float displacement;

    public float multiplier;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();


        color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f),0.5f);


        rend.material.SetColor("_Color", color);

        

        processor = FindObjectOfType<AudioProcessor>();
        processor.onBeat.AddListener(onOnbeatDetected);
        processor.onSpectrum.AddListener(onSpectrum);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void onOnbeatDetected()
    {
        Debug.Log("Beat!!!");

        color.a = Random.value;

        rend.material.SetColor("_Color", color);

    }

    //This event will be called every frame while music is playing
    void onSpectrum(float[] spectrum)
    {
        //The spectrum is logarithmically averaged
        //to 12 bands

        for (int i = 0; i < spectrum.Length; ++i)
        {
            Vector3 start = new Vector3(i, 0, 0);
            Vector3 end = new Vector3(i, spectrum[i], 0);
            Debug.DrawLine(start, end);
        }
    }
}
