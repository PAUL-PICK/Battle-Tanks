using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//View is respocerbul for visualthings like ui,and ony comunicates with controller
public class TankView : MonoBehaviour
{
    private TankController _tankController;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetTankController(TankController tankController)
    {
        _tankController = tankController;

    }
}
