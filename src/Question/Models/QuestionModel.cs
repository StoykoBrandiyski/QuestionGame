using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Question.Models
{
    public class QuestionModel
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("questionText")]
        public string QuestionText { get; set; }

        [JsonPropertyName("answers")]
        public List<Answer> Answers { get; set; }

        [JsonPropertyName("correctOptionNumber")]
        public int CorrectOptionNumber { get; set; }
    }
}
