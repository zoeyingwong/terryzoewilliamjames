#pragma strict

var moveLeft : KeyCode;
var moveRight : KeyCode;

var speed : float = 10;

function Update () 
{
	if (Input.GetKey(moveRight)) 
	{
		GetComponent.<Rigidbody>().velocity.x = speed;
	}
	else if (Input.GetKey(moveLeft))
	{
		GetComponent.<Rigidbody>().velocity.x = - speed;
	}
	else 
	{
		GetComponent.<Rigidbody>().velocity.x = 0;
	}
	
	GetComponent.<Rigidbody>().velocity.y = 0;
}