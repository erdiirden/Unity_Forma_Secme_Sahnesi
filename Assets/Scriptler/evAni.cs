using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class evAni : MonoBehaviour
{
    public Animator evAnima;
    void Start()
    {
        evAnima = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            evAnimasyon();
            Invoke("stopAnimasyon", 2f);
        }
    }
    private void evAnimasyon()
    {
        evAnima.SetBool("pozVer", true);
    }
    private void stopAnimasyon()
    {
        evAnima.SetBool("pozVer", false);
    }
}
