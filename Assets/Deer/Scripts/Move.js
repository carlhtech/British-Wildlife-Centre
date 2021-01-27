#pragma strict
//var target : Transform;
var speed : int =10;
function Start () {

}

function Update () {
//transform.LookAt(target);
if(Input.GetKey("right")){
transform.Translate(Vector3(0,0,speed)*Time.deltaTime);
}
if(Input.GetKey("left")){
transform.Translate(Vector3(0,0,-speed)*Time.deltaTime);
}
}