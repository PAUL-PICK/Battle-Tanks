
using UnityEngine;
// Controller takes care of  in the M.V.C pattern Controller comunicates with all
public class TankController // dos not need MonoBehavier
{
    private TankModel _tankModel;// ref to the scripts
    private TankView _tankView;
    private Rigidbody _playerRb;

    public TankController(TankModel tankModel, TankView tankView)   
    {// public function inside of class is called a constructer()
        _tankModel = tankModel;
        _tankView = GameObject.Instantiate<TankView>(tankView);
        _playerRb = _tankView.GetRidgidBody();
        _tankView.SetTankController(this);// this refers to this scrip 
        _tankModel.SetTankController(this);   

    }

    public void Move(float movement, float movementSpeed)
    {
        _playerRb.velocity = _tankView.transform.forward * movement * movementSpeed;

    }

    public void Rotate(float rotate, float rotateSpeed)
    {
        Vector3 vector = new Vector3(0f, rotate * rotateSpeed, 0f);
        Quaternion deltaRotation = Quaternion.Euler(vector * Time.deltaTime);
        _playerRb.MoveRotation(_playerRb.rotation * deltaRotation);



    }

    public TankModel GetTankModel()
    {
        return _tankModel;
    }

}
