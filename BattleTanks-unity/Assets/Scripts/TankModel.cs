using UnityEngine;// Model takes care of data and only communicates with controllerpublic class TankModel //do's not need monobehavier as not using unity base class{	private TankController _tankController;	public float movementSpeed;	public float rotationSpeed;	public TankTypes tankTypes;	public Material color;		public TankModel(float Movement,float Rotation,TankTypes Tank,Material Color)	{		movementSpeed = Movement;		rotationSpeed = Rotation;		tankTypes = Tank;		color = Color;	}		public void SetTankController(TankController TankController)	{		_tankController = TankController;			}}