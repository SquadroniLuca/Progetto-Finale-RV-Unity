using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashCan : MonoBehaviour
{
    [SerializeField] int trashType = 0;

    [SerializeField]
    private Constants.Enums.TrashType _trashType;
    public Constants.Enums.TrashType TrashType { get { return _trashType; } private set { _trashType = value; } }

    // Start is called before the first frame update
    void Start()
    {
        SetBinType();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SetBinType()
    {
        //set type of bin
        switch (trashType)
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
