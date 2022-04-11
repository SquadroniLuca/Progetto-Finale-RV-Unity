using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

class RecyclableObject : MonoBehaviour
{
    [SerializeField] int recyType = 0;

    [SerializeField]
    private Constants.Enums.TrashType _trashType;
    public Constants.Enums.TrashType TrashType { get { return _trashType; } private set { _trashType = value; } }

    private void Start()
    {
        SetRecyType();
    }

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
        //manca il caso in cui si butti nell'indifferenziata, che non è riciclato ma non è neanche sbagliato
    }

    private void SetRecyType()
    {
        //set type of bin
        switch (recyType)
        {
            case 1:
                print("PAPER");
                TrashType = 0;
                break;
            case 2:
                print("PLASTIC");
                break;
            case 3:
                print("ORGANIC");
                break;
            case 4:
                print("GLASS");
                break;
            case 5:
                print("TIN");
                break;
            case 6:
                print("NONRECYCLABLE");
                break;
            default:
                print("Incorrect intelligence level.");
                break;
        }
    }
}
