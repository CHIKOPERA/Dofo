using Core.DTOs;
using Core.Services;
using RestSharp;

namespace Application.Services
{
    public class RephraseService : IRephraseService
    {
        public TextConversionResult RephraseText(string textToRephrase)
        {
            var textConversionResult = new TextConversionResult();
            RestResponse response = GetConvertedText();

            if (response.IsSuccessful)
            {
                textConversionResult.Content = response.Content ?? "";
            }
            else
            {
                textConversionResult.IsSuccessfull = response.IsSuccessful;
                textConversionResult.ErrorMessage = response.ErrorMessage;
            }

            return textConversionResult;
        }

        private static RestResponse GetConvertedText()
        {
            var client = new RestClient("https://api.writesonic.com/v1/business/content/content-rephrase");
            var request = new RestRequest();
            request.AddHeader("accept", "application/json");
            request.AddHeader("content-type", "application/json");
            request.AddHeader("X-API-KEY", "c6463cad-fa7f-4be4-bcd6-8e21ef5d777e");
            request.AddParameter(new Parameter() { Name = "engine", Value = "economy" },);
            var response = client.Execute(request);
            return response;
        }
    }
}
