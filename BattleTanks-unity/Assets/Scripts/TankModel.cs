
using UnityEngine;
// Model takes care of data and only communicates with controller
public class TankModel //do's not need monobehavier as not using unity base class
{
    private TankController _tankController;

    public TankModel()
    {

    }
    
    public void SetTankController(TankController tankController)
    {
        _tankController = tankController;

    }
}
