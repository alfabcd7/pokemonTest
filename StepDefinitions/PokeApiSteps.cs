using NUnit.Framework;
using RestSharp;
using TechTalk.SpecFlow;

namespace PokeApiTests
{
    [Binding]
    public class PokeApiSteps
    {
        private RestClient _client;
        private RestRequest _request;
        private RestResponse _response;

        [Given("I have a valid Pokémon ID")]
        public void GivenIHaveAValidPokemonId()
        {
            _client = new RestClient("https://pokeapi.co/api/v2");
        }

        [Given("I have a valid Ability ID")]
        public void GivenIHaveAValidAbilityId()
        {
            _client = new RestClient("https://pokeapi.co/api/v2");
        }

        [When("I request the Pokémon details")]
        public void WhenIRequestThePokemonDetails()
        {
            _request = new RestRequest("/pokemon/1", Method.Get);
            _response = _client.Execute(_request);
        }

        [When("I request the Ability details")]
        public void WhenIRequestTheAbilityDetails()
        {
            _request = new RestRequest("/ability/1", Method.Get);
            _response = _client.Execute(_request);
        }

        [Then("the response status code should be (.*)")]
        public void ThenTheResponseStatusCodeShouldBe(int statusCode)
        {
            Assert.AreEqual(statusCode, (int)_response.StatusCode);
        }

        [Then("the response should contain the Pokémon name")]
        public void ThenTheResponseShouldContainThePokemonName()
        {
            var responseData = _response.Content;
            Assert.IsTrue(responseData.Contains("\"name\":\"Bulbasaur\""));
        }

        [Then("the response should contain the Ability name")]
        public void ThenTheResponseShouldContainTheAbilityName()
        {
            var responseData = _response.Content;
            
        }
    }
}
