using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question.Services
{
    public class QuestionDb
    {
        public string GetAllQuestionsJson()
        {
            string json = @"
[
  {
    ""id"": 1,
    ""questionText"": ""Кой е авторът на 'Под Игото'?"",
    ""answers"": [
      {
        ""optionNumber"": 1,
        ""answerText"": ""Иван Вазов""
      },
      {
        ""optionNumber"": 2,
        ""answerText"": ""Христо Ботев""
      },
      {
        ""optionNumber"": 3,
        ""answerText"": ""Васил Левски""
      }
    ],
    ""correctOptionNumber"": 1
  },
  {
    ""id"": 2,
    ""questionText"": ""Кой е авторът на 'История Славянобългарска'?"",
    ""answers"": [
      {
        ""optionNumber"": 1,
        ""answerText"": ""св. Софроний Врачански""
      },
      {
        ""optionNumber"": 2,
        ""answerText"": ""Неофит Рилски""
      },
      {
        ""optionNumber"": 3,
        ""answerText"": ""св. Паисий Хилендарски""
      }
    ],
    ""correctOptionNumber"": 3
  },
  {
    ""id"": 3,
    ""questionText"": ""Кое от произведенията е с автор св. Софроний Врачански?"",
    ""answers"": [
      {
        ""optionNumber"": 1,
        ""answerText"": ""Петокнижие""
      },
      {
        ""optionNumber"": 2,
        ""answerText"": ""Неделник""
      },
      {
        ""optionNumber"": 3,
        ""answerText"": ""Рибен буквар""
      }
    ],
    ""correctOptionNumber"": 2
  },
  {
    ""id"": 4,
    ""questionText"": ""Управлението на кой български цар наричаме 'Златен век'?"",
    ""answers"": [
      {
        ""optionNumber"": 1,
        ""answerText"": ""Цар Петър Първи""
      },
      {
        ""optionNumber"": 2,
        ""answerText"": ""Цар Симеон Велики""
      },
      {
        ""optionNumber"": 3,
        ""answerText"": ""Цар Борис Първи""
      }
    ],
    ""correctOptionNumber"": 2
  },
  {
    ""id"": 5,
    ""questionText"": ""През коя година избухва Априлското въстание?"",
    ""answers"": [
      {
        ""optionNumber"": 1,
        ""answerText"": ""1876 г.""
      },
      {
        ""optionNumber"": 2,
        ""answerText"": ""1867 г.""
      },
      {
        ""optionNumber"": 3,
        ""answerText"": ""1768 г.""
      }
    ],
    ""correctOptionNumber"": 1
  },
  {
    ""id"": 6,
    ""questionText"": ""Кой е авторът на 'Шестоднев'?"",
    ""answers"": [
      {
        ""optionNumber"": 1,
        ""answerText"": ""св. Паисий Хилендарски""
      },
      {
        ""optionNumber"": 2,
        ""answerText"": ""Йоан Екзарх""
      },
      {
        ""optionNumber"": 3,
        ""answerText"": ""Цар Иван Александър""
      }
    ],
    ""correctOptionNumber"": 2
  },
  {
    ""id"": 7,
    ""questionText"": ""Кой от изброените е син на цар Симеон Велики?"",
    ""answers"": [
      {
        ""optionNumber"": 1,
        ""answerText"": ""Цар Иван Асен""
      },
      {
        ""optionNumber"": 2,
        ""answerText"": ""Цар Петър Първи""
      },
      {
        ""optionNumber"": 3,
        ""answerText"": ""Владимир Расате""
      }
    ],
    ""correctOptionNumber"": 2
  },
  {
    ""id"": 8,
    ""questionText"": ""Кой от изброените наричаме Патриарх на българската литература?"",
    ""answers"": [
      {
        ""optionNumber"": 1,
        ""answerText"": ""Иван Вазов""
      },
      {
        ""optionNumber"": 2,
        ""answerText"": ""Захарий Стоянов""
      },
      {
        ""optionNumber"": 3,
        ""answerText"": ""Васил Левски""
      }
    ],
    ""correctOptionNumber"": 1
  },
  {
    ""id"": 9,
    ""questionText"": ""Кой от изброените е Патриарха на българските учители?"",
    ""answers"": [
      {
        ""optionNumber"": 1,
        ""answerText"": ""Захарий Зограф""
      },
      {
        ""optionNumber"": 2,
        ""answerText"": ""Неофит Рилски""
      },
      {
        ""optionNumber"": 3,
        ""answerText"": ""Иван Вазов""
      }
    ],
    ""correctOptionNumber"": 2
  },
  {
    ""id"": 10,
    ""questionText"": ""Коя е столицата на България при управлението на цар Самуил?"",
    ""answers"": [
      {
        ""optionNumber"": 1,
        ""answerText"": ""Плиска""
      },
      {
        ""optionNumber"": 2,
        ""answerText"": ""Велики Преслав""
      },
      {
        ""optionNumber"": 3,
        ""answerText"": ""Охрид""
      }
    ],
    ""correctOptionNumber"": 3
  },
  {
    ""id"": 11,
    ""questionText"": ""През коя година се състои битката при Клокотница?"",
    ""answers"": [
      {
        ""optionNumber"": 1,
        ""answerText"": ""1650 г.""
      },
      {
        ""optionNumber"": 2,
        ""answerText"": ""1230 г.""
      },
      {
        ""optionNumber"": 3,
        ""answerText"": ""1427 г.""
      }
    ],
    ""correctOptionNumber"": 2
  },
  {
    ""id"": 12,
    ""questionText"": ""Кой е авторът на 'Под Игото'?"",
    ""answers"": [
      {
        ""optionNumber"": 1,
        ""answerText"": ""Иван Вазов""
      },
      {
        ""optionNumber"": 2,
        ""answerText"": ""Христо Ботев""
      },
      {
        ""optionNumber"": 3,
        ""answerText"": ""Васил Левски""
      }
    ],
    ""correctOptionNumber"": 1
  },
  {
    ""id"": 13,
    ""questionText"": ""През коя година е създадена Българската държава?"",
    ""answers"": [
      {
        ""optionNumber"": 1,
        ""answerText"": ""678 г.""
      },
      {
        ""optionNumber"": 2,
        ""answerText"": ""681 г.""
      },
      {
        ""optionNumber"": 3,
        ""answerText"": ""716 г.""
      }
    ],
    ""correctOptionNumber"": 2
  },
  {
    ""id"": 14,
    ""questionText"": ""През коя година се покръстват българите?"",
    ""answers"": [
      {
        ""optionNumber"": 1,
        ""answerText"": ""876 г.""
      },
      {
        ""optionNumber"": 2,
        ""answerText"": ""885 г.""
      },
      {
        ""optionNumber"": 3,
        ""answerText"": ""864 г.""
      }
    ],
    ""correctOptionNumber"": 3
  },
  {
    ""id"": 15,
    ""questionText"": ""През коя година пристигат при цар Симеон учениците на светите братя Кирил и Методий?"",
    ""answers"": [
      {
        ""optionNumber"": 1,
        ""answerText"": ""868 г.""
      },
      {
        ""optionNumber"": 2,
        ""answerText"": ""885 г.""
      },
      {
        ""optionNumber"": 3,
        ""answerText"": ""876 г.""
      }
    ],
    ""correctOptionNumber"": 2
  },
  {
    ""id"": 16,
    ""questionText"": ""През коя година е създадена глаголицата?"",
    ""answers"": [
      {
        ""optionNumber"": 1,
        ""answerText"": ""885 г.""
      },
      {
        ""optionNumber"": 2,
        ""answerText"": ""855 г.""
      },
      {
        ""optionNumber"": 3,
        ""answerText"": ""865 г.""
      }
    ],
    ""correctOptionNumber"": 2
  },
  {
    ""id"": 17,
    ""questionText"": ""Колко на брой са учениците на светите братя Кирил и Методий?"",
    ""answers"": [
      {
        ""optionNumber"": 1,
        ""answerText"": ""7""
      },
      {
        ""optionNumber"": 2,
        ""answerText"": ""5""
      },
      {
        ""optionNumber"": 3,
        ""answerText"": ""3""
      }
    ],
    ""correctOptionNumber"": 2
  },
  {
    ""id"": 18,
    ""questionText"": ""Кой български хан наричаме строител?"",
    ""answers"": [
      {
        ""optionNumber"": 1,
        ""answerText"": ""Аспарух""
      },
      {
        ""optionNumber"": 2,
        ""answerText"": ""Омуртаг""
      },
      {
        ""optionNumber"": 3,
        ""answerText"": ""Крум""
      }
    ],
    ""correctOptionNumber"": 2
  },
  {
    ""id"": 19,
    ""questionText"": ""Кой хан създава първите български писани закони?"",
    ""answers"": [
      {
        ""optionNumber"": 1,
        ""answerText"": ""Тервел""
      },
      {
        ""optionNumber"": 2,
        ""answerText"": ""Омуртаг""
      },
      {
        ""optionNumber"": 3,
        ""answerText"": ""Крум""
      }
    ],
    ""correctOptionNumber"": 3
  },
  {
    ""id"": 20,
    ""questionText"": ""При кой цар България се простира на три морета?"",
    ""answers"": [
      {
        ""optionNumber"": 1,
        ""answerText"": ""Цар Симеон Велики""
      },
      {
        ""optionNumber"": 2,
        ""answerText"": ""Цар Иван Асен Втори""
      },
      {
        ""optionNumber"": 3,
        ""answerText"": ""Цар Борис Първи""
      }
    ],
    ""correctOptionNumber"": 1
  }
]";
            return json;
        }
    }
}
