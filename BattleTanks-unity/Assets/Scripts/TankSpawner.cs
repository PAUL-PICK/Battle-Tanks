using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    [System.Serializable]// all fields in Tank Class will be in inspector
    public class Tank
    {
        public float movementSpeed;
        public float rotationSpeed;
        public TankTypes tankTypes;
        public Material color;

    }

    public List<Tank> tankList;

    public TankView _tankView;// this is a ref to TankVeiw script
    // Start is called before the first frame update
    void Start()
    {
        CreateTank();
    }
    // Green Tank By Default
    private void CreateTank()
    {// this is set in the inspector and passed to the TankModel
        TankModel tankModel = new TankModel(tankList[2].movementSpeed, tankList[2].rotationSpeed, tankList[2].tankTypes, tankList[2].color);

        TankController _tankController = new TankController(tankModel, _tankView);
    }

   
}
