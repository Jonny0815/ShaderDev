using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class AudioScript : MonoBehaviour
{
    public GameObject Cube0;
    public GameObject Cube1;
    public GameObject Cube2;
    public GameObject Cube3;
    public GameObject Cube4;
    public GameObject Cube5;
    public GameObject Cube6;
    public GameObject Cube7;

    public BallScript bs0;
    public BallScript bs1;
    public BallScript bs2;
    public BallScript bs3;
    public BallScript bs4;
    public BallScript bs5;
    public BallScript bs6;
    public BallScript bs7;

    ShaderScript sc0;
    ShaderScript sc1;
    ShaderScript sc2;
    ShaderScript sc3;
    ShaderScript sc4;
    ShaderScript sc5;
    ShaderScript sc6;
    ShaderScript sc7;

    public AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        
        sc0 = Cube0.GetComponent<ShaderScript>();
        sc1 = Cube1.GetComponent<ShaderScript>();
        sc2 = Cube2.GetComponent<ShaderScript>();
        sc3 = Cube3.GetComponent<ShaderScript>();
        sc4 = Cube4.GetComponent<ShaderScript>();
        sc5 = Cube5.GetComponent<ShaderScript>();
        sc6 = Cube6.GetComponent<ShaderScript>();
        sc7 = Cube7.GetComponent<ShaderScript>();


        sc0.wave = new float[64];
        sc1.wave = new float[64];
        sc2.wave = new float[64];
        sc3.wave = new float[64];
        sc4.wave = new float[64];
        sc5.wave = new float[64];
        sc6.wave = new float[64];
        sc7.wave = new float[64];

        bs0.wave = new float[64];
        bs1.wave = new float[64];
        bs2.wave = new float[64];
        bs3.wave = new float[64];
        bs4.wave = new float[64];
        bs5.wave = new float[64];
        bs6.wave = new float[64];
        bs7.wave = new float[64];

        audio = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {

        audio.GetSpectrumData(sc0.wave, 0, FFTWindow.Blackman);
        audio.GetSpectrumData(sc1.wave, 0, FFTWindow.Blackman);
        audio.GetSpectrumData(sc2.wave, 0, FFTWindow.Blackman);
        audio.GetSpectrumData(sc3.wave, 0, FFTWindow.Blackman);
        audio.GetSpectrumData(sc4.wave, 0, FFTWindow.Blackman);
        audio.GetSpectrumData(sc5.wave, 0, FFTWindow.Blackman);
        audio.GetSpectrumData(sc6.wave, 0, FFTWindow.Blackman);
        audio.GetSpectrumData(sc7.wave, 0, FFTWindow.Blackman);

        audio.GetSpectrumData(bs0.wave, 0, FFTWindow.Blackman);
        audio.GetSpectrumData(bs1.wave, 0, FFTWindow.Blackman);
        audio.GetSpectrumData(bs2.wave, 0, FFTWindow.Blackman);
        audio.GetSpectrumData(bs3.wave, 0, FFTWindow.Blackman);
        audio.GetSpectrumData(bs4.wave, 0, FFTWindow.Blackman);
        audio.GetSpectrumData(bs5.wave, 0, FFTWindow.Blackman);
        audio.GetSpectrumData(bs6.wave, 0, FFTWindow.Blackman);
        audio.GetSpectrumData(bs7.wave, 0, FFTWindow.Blackman);


    }
}












//Working

//public class AudioScript : MonoBehaviour
//{

//    public GameObject a_GO;
//    ShaderScript sc;

//    // Start is called before the first frame update
//    void Start()
//    {
//        sc = a_GO.GetComponent<ShaderScript>();
//        sc.wave = new float[64];
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        AudioInput.RetrieveWaveform(FilterType.Bypass, sc.wave);
//    }
//}