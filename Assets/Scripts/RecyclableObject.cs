using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

class RecyclableObject : MonoBehaviour
{
    [SerializeField]
    private Constants.Enums.TrashType _trashType;
    public Constants.Enums.TrashType TrashType { get { return _trashType; } private set { _trashType = value; } }

    private void OnTriggerEnter(Collider other)
    {
        TrashCan can = other.gameObject.GetComponent<TrashCan>();
        if (can != null && can.TrashType == this.TrashType)
        {
            EventManager.FireCorrectRecycling();
        }
        else
        {
            EventManager.FireWrongRecycling();
        }
    }
}
