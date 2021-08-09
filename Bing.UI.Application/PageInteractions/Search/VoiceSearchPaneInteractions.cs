using Modulus.UI.Application.Bing.PageComponents;
using Modulus.UI.Library.PageElements;
using Modulus.UI.Library.PageElements.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulus.UI.Application.Bing.PageInteractions.Search
{
    public class VoiceSearchPaneInteractions : PageInteraction
    {
        protected override VoiceSearchPane SearchContext => new VoiceSearchPane();
    }
}
