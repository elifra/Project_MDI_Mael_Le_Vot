using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class avance : MonoBehaviour
{

    //public GameObject cible;
    //private Animator anim;
    BoxCollider box;
    private int cpt;

    // Start is called before the first frame update
    void Start()
    {
        //GetComponent<NavMeshAgent>().SetDestination(cible.transform.position);
        //anim = GetComponent<Animator>();
        box = GetComponent<BoxCollider>();
        cpt = 0;
    }

    /*void setObjectif(GameObject target)
    {
        cible = target;
    }*/

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("collision");
        /*if (cpt == 0)
        {
            GetComponent<NavMeshAgent>().enabled = false;
            GetComponent<Animator>().SetTrigger("jump");
            cpt++;
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = new Vector3(transform.position.x, transform.position.y, transform.position.z + 0.01f);
        transform.SetPositionAndRotation(newPos, transform.rotation);
    }
}
