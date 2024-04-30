using System.Security.AccessControl;

var random = new Random();
var dado = new Dice(random);
var juego = new Game(dado);

juego.Play();
