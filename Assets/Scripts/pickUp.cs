using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUp : MonoBehaviour
{

    public GameObject handPoint; //Referencia para el handPoint
    private GameObject pickedObject = null; //null porque desde un principio no tiene nada y no pillar 2 objetos





    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //suelta el objeto que tenemos en "hand" y lo devuelve a su estado original
        if (Input.GetKey("f"))
        {
            pickedObject.GetComponent<Rigidbody>().useGravity = true;
            pickedObject.GetComponent<Rigidbody>().isKinematic = false;
            pickedObject.gameObject.transform.SetParent(null);//quita el objeto de la jerarquia
            pickedObject = null;

        }
    }

    private void OnTriggerStay(Collider other)
    {
    if (other.gameObject.CompareTag("MoveElement"))
        {
            if (Input.GetKey("e") && pickedObject==null) //Se puede recoger el objeto si presionamos e y si nuestra "mano" esta vacia
            {
                other.GetComponent<Rigidbody>().useGravity = false;
                other.GetComponent<Rigidbody>().isKinematic = true;
                other.transform.position = handPoint.transform.position;
                other.gameObject.transform.SetParent(handPoint.gameObject.transform);
                pickedObject = other.gameObject; //referencia para el objeto a recoger
            }
        }
    }
}
