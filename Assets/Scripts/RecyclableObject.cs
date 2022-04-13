using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

class RecyclableObject : MonoBehaviour
{
    [SerializeField]
    private Enums.TrashType _trashType;
    public Enums.TrashType TrashType { get { return _trashType; } private set { _trashType = value; } }

    private void Start()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        TrashCan can = other.gameObject.GetComponent<TrashCan>();
        if (can != null && can.TrashType == this.TrashType)
        {
            EventManager.FireCorrectRecycling();
            UnityEngine.Debug.Log("correct!");
        }
        else
        {
            EventManager.FireWrongRecycling();
            UnityEngine.Debug.Log("wrooong!");
        }
        //manca il caso in cui si butti nell'indifferenziata, che non è riciclato ma non è neanche sbagliato
    }
}
