using Core.DTOs;

namespace Core.Services
{
    // API key for WriteSonic c6463cad-fa7f-4be4-bcd6-8e21ef5d777e
    public interface IRephraseService
    {
        public TextConversionResult RephraseText(string textToRephrase);
    }
}
