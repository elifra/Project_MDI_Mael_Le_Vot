﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class navigation : MonoBehaviour
{

    public GameObject cible;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<NavMeshAgent>().SetDestination(cible.transform.position);
    }


    // Update is called once per frame
    void Update()
    {

    }
}
