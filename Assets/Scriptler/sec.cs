using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sec : MonoBehaviour
{
    public Material[] evFormalar = new Material[3];
    public Material[] evSortlar = new Material[3];
    public Material[] depFormalar = new Material[3];
    public Material[] depSortlar = new Material[3];
    public Image[] evTik = new Image[3];
    public Image[] depTik = new Image[3];
    public Image secSolFoto, secSagFoto, secEnterFoto;
    public GameObject evForma, evSort, depForma, depSort;
    string takimSec = "evSecildi"; //evSecildi, depSecildi, EnterSecildi
    string evFormaSec = "1"; //0,1,2
    string depFormaSec = "1"; //0,1,2
    public AudioSource Ses;
    public AudioClip dolasMuzik, secMuzik;

    void Start()
    {
        evTik[0].enabled = evTik[2].enabled = depTik[0].enabled = depTik[2].enabled = false;
        evTik[1].enabled = depTik[1].enabled = true;
        secSolFoto.enabled = true;
        secSagFoto.enabled = false;
        secEnterFoto.enabled = false;
        Ses = gameObject.AddComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (takimSec == "enterSecildi")
            {
                secSolFoto.enabled = false;
                secSagFoto.enabled = true;
                takimSec = "depSecildi";
                secEnterFoto.enabled = false;
                Ses.PlayOneShot(dolasMuzik);
            }
            else if (takimSec=="depSecildi")
            {
                secSolFoto.enabled = true;
                secSagFoto.enabled = false;
                takimSec = "evSecildi";
                Ses.PlayOneShot(dolasMuzik);
            }
        }

        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (takimSec=="evSecildi")
            {
                secSolFoto.enabled = false;
                secSagFoto.enabled = true;
                takimSec = "depSecildi";
                Ses.PlayOneShot(dolasMuzik);
            }
            else if (takimSec == "depSecildi")
            {
                secSolFoto.enabled = false;
                secSagFoto.enabled = false;
                secEnterFoto.enabled = true;
                takimSec = "enterSecildi";
                Ses.PlayOneShot(dolasMuzik);
            }
        }

        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (takimSec=="evSecildi")
            {
                if (evTik[0].enabled == false)
                {
                    if (evTik[2].enabled == true)
                    {
                        evTik[1].enabled = true;
                        evTik[2].enabled = false;
                        evFormaSec = "1";
                        Ses.PlayOneShot(dolasMuzik);
                    }
                    else if (evTik[1].enabled == true)
                    {
                        evTik[1].enabled = false;
                        evTik[0].enabled = true;
                        evFormaSec = "0";
                        Ses.PlayOneShot(dolasMuzik);
                    }
                }
            }
            else if (takimSec =="depSecildi")
            {
                if (depTik[0].enabled == false)
                {
                    if (depTik[2].enabled == true)
                    {
                        depTik[1].enabled = true;
                        depTik[2].enabled = false;
                        depFormaSec = "1";
                        Ses.PlayOneShot(dolasMuzik);
                    }
                    else if (depTik[1].enabled == true)
                    {
                        depTik[1].enabled = false;
                        depTik[0].enabled = true;
                        depFormaSec = "0";
                        Ses.PlayOneShot(dolasMuzik);
                    }
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (takimSec =="evSecildi")
            {
                if (evTik[2].enabled == false)
                {
                    if (evTik[0].enabled == true)
                    {
                        evTik[1].enabled = true;
                        evTik[0].enabled = false;
                        evFormaSec = "1";
                        Ses.PlayOneShot(dolasMuzik);
                    }
                    else
                    {
                        evTik[1].enabled = false;
                        evTik[2].enabled = true;
                        evFormaSec = "2";
                        Ses.PlayOneShot(dolasMuzik);
                    }
                }
            }
            else if (takimSec =="depSecildi")
            {
                if (depTik[2].enabled == false)
                {
                    if (depTik[0].enabled == true)
                    {
                        depTik[1].enabled = true;
                        depTik[0].enabled = false;
                        depFormaSec = "1";
                        Ses.PlayOneShot(dolasMuzik);
                    }
                    else
                    {
                        depTik[1].enabled = false;
                        depTik[2].enabled = true;
                        depFormaSec = "2";
                        Ses.PlayOneShot(dolasMuzik);
                    }
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            if (secEnterFoto.enabled == true)
            {
                secButon();
                Ses.PlayOneShot(secMuzik);
            }

        }

    }
    public void secButon()
    {
        Renderer evFormarenderer = evForma.GetComponent<Renderer>();
        Renderer evSortrenderer = evSort.GetComponent<Renderer>();
        Renderer depFormarenderer = depForma.GetComponent<Renderer>();
        Renderer depSortrenderer = depSort.GetComponent<Renderer>();
        switch (evFormaSec)
        {
            case "0":
                evFormarenderer.material = evFormalar[0];
                evSortrenderer.material = evSortlar[0];
                break;
            case "1":
                evFormarenderer.material = evFormalar[1];
                evSortrenderer.material = evSortlar[1];
                break;
            case "2":
                evFormarenderer.material = evFormalar[2];
                evSortrenderer.material = evSortlar[2];
                break;
        }
        switch (depFormaSec)
        {
            case "0":
                depFormarenderer.material = depFormalar[0];
                depSortrenderer.material = depSortlar[0];
                break;
            case "1":
                depFormarenderer.material = depFormalar[1];
                depSortrenderer.material = depSortlar[1];
                break;
            case "2":
                depFormarenderer.material = depFormalar[2];
                depSortrenderer.material = depSortlar[2];
                break;
        }
    }
}
