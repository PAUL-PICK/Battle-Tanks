
using UnityEngine;
// Controller takes care of  in the M.V.C pattern Controller comunicates with all
public class TankController // dos not need MonoBehavier
{
    private TankModel _tankModel;// ref to the scripts
    private TankView _tankView;
    private Rigidbody _playerRb;

    public TankController(TankModel TankModel, TankView TankView)   
    {// public function inside of class is called a constructer()
        _tankModel = TankModel;
        _tankView = GameObject.Instantiate<TankView>(TankView);
        _playerRb = _tankView.GetRidgidBody();
        _tankView.SetTankController(this);// this refers to this scrip 
        _tankModel.SetTankController(this);
        _tankView.ChangeColor(_tankModel.color);

    }

    public void Move(float Movement, float MovementSpeed)
    {
        _playerRb.velocity = _tankView.transform.forward * Movement * MovementSpeed;

    }

    public void Rotate(float Rotate, float RotateSpeed)
    {
        Vector3 vector = new Vector3(0f, Rotate * RotateSpeed, 0f);
        Quaternion deltaRotation = Quaternion.Euler(vector * Time.deltaTime);
        _playerRb.MoveRotation(_playerRb.rotation * deltaRotation);



    }

    public TankModel GetTankModel()
    {
        return _tankModel;
    }

}
