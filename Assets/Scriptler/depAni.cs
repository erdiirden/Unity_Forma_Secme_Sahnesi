using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class depAni : MonoBehaviour
{
    public Animator depAnima;
    void Start()
    {
        depAnima = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            depAnimasyon();
            Invoke("stopAnimasyon", 2f);
        }
    }
    private void depAnimasyon()
    {
        depAnima.SetBool("pozVer", true);
    }
    private void stopAnimasyon()
    {
        depAnima.SetBool("pozVer", false);
    }
}
