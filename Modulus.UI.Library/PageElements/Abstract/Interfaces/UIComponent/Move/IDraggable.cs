using Modulus.QA.UI.Library.PageElements.Abstract.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulus.UI.Library.PageElements.Generic.Interfaces
{
    public interface IDraggable
    {
        void DragAndDrop(IDroppableTarget target);
    }
}
