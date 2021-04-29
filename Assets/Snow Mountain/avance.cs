using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class avance : MonoBehaviour
{

    //public GameObject cible;
    private Animator anim;
    BoxCollider box;

    // Start is called before the first frame update
    void Start()
    {
        //GetComponent<NavMeshAgent>().SetDestination(cible.transform.position);
        anim = GetComponent<Animator>();
        box = GetComponent<BoxCollider>();

        anim.SetBool("isSkying", true);
    }

    /*void setObjectif(GameObject target)
    {
        cible = target;
    }*/

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("entre");
        if (box.bounds.min.x > other.bounds.min.x && box.bounds.max.x < other.bounds.max.x)
        {
            anim.SetBool("isSkying", false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(anim.GetBool("isSkying"));
    }
}
