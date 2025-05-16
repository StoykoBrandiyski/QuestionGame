using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Question.Models
{
    public class Answer
    {
        [JsonPropertyName("optionNumber")]
        public int OptionNumber { get; set; }

        [JsonPropertyName("answerText")]
        public string AnswerText { get; set; }
    }
}
