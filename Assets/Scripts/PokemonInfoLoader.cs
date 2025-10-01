using System;
using System.Collections;
using System.Net.Http;
using System.Threading.Tasks;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class PokemonInfoLoader : MonoBehaviour
{   
    private readonly HttpClient httpClient = new HttpClient();
    private const string baseUrl = "https://pokeapi.co/api/v2/pokemon/";

    [Header("Canvas Objects")]
    [SerializeField] private Image pokemonImage;
    [SerializeField] private TextMeshProUGUI pokemonName;

    private async void Start()
    {
        Pokemon currentPokemon = await GetPokemonInfo("garchomp");

        if (currentPokemon != null)
        {
            pokemonName.text = currentPokemon.name;

            StartCoroutine(LoadPokemonSprite(currentPokemon.sprites.front_default));
        }
    }

    private async Task<Pokemon> GetPokemonInfo(string name)
    {
        string url = baseUrl + name.ToLower();

        HttpResponseMessage response = await httpClient.GetAsync(url);
        string jsonResponse = await response.Content.ReadAsStringAsync();
        Pokemon pokemon = JsonUtility.FromJson<Pokemon>(jsonResponse);
        return pokemon;
    }

    private IEnumerator LoadPokemonSprite(string spriteUrl)
    {
        using (UnityWebRequest request = UnityWebRequestTexture.GetTexture(spriteUrl))
        {
            yield return request.SendWebRequest();

            if (request.result == UnityWebRequest.Result.Success)
            {
                Texture2D texture = ((DownloadHandlerTexture)request.downloadHandler).texture;
                Sprite sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), Vector2.one * 0.5f);
                pokemonImage.sprite = sprite;
            }
            else Debug.LogError($"Erro ao carregar imagem: {request.error}");
        }
    }
}
