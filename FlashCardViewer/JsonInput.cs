using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlashCardViewer.Properties;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FlashCardViewer
{
    public static class JsonInput
    {
        public static Questions DeserializeData()
        {

            List<Question> questions; 

            questions = JsonConvert.DeserializeObject<List<Question>>(Properties.Resources.Testing);

            return new Questions(questions.ToArray());
        }

    }
}
