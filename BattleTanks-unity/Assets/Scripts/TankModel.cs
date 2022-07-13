
using UnityEngine;
// Model takes care of data and only communicates with controller
public class TankModel //do's not need monobehavier as not using unity base class
{
    private TankController _tankController;
    public float _movementSpeed;

    public float _rotationSpeed
        ;

    public TankModel(float movement,float rotation)
    {
        _movementSpeed = movement;
        _rotationSpeed = rotation;
    }
    
    public void SetTankController(TankController tankController)
    {
        _tankController = tankController;
        

    }
}
