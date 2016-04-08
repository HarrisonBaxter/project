#pragma strict

function Start () {
    yield WaitForSeconds(20);
    Application.LoadLevel("LincolnAccomodation");
}

function Update () {

}

function Pavillions () {
    Application.LoadLevel("MyRoom");
}
function Courts () {
    Application.LoadLevel("Labs");
}

function Brayford () {
    Application.LoadLevel("Hill");
}

function ExitApplication () {
    Application.Quit();
}