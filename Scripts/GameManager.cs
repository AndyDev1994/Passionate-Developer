using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
	public int points;//acumula a pontuação atual do jogador
	public int waterpoints;
	public int grainpoints;
	public int sunpoints;
	public float time_left = 500f;//Tempo para finalizar o jogo
	public bool finished = false;//Informa ao jogo se finalizou ou não
	//Para acessar: GameManager instancia
	public static GameManager instancia;
	// Sigleton: garnte que somente uma instancia do GameManager
	// existira e que sua referencia sera armazenada na variavel "instancia"
	void Awake () {
		if (instancia == null) {
			instancia = this;
			DontDestroyOnLoad (gameObject);
		
		}else{
			// indica que o GameManager sera mantido na memoria
			// mesmo se uma nova cena for carregada
			Destroy(gameObject);
	}
}
	// responsavel por decrementar a variavel time_left e setar a cariavel finalizado
	void Update () {
			time_left -= Time.deltaTime;

			if(time_left <= 0f){
				time_left = 0;
				finished = true; // finalizar o jogo

			}
     }
}
