/* IPrintable.cs  
 * This is an interface for
 * the ReadingMaterial application. It
 * forces all classes implementing the
 * interface to include a method indicating
 * how hoard copies are obtained.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingMaterialApp
{
    public interface IPrintable
    {
        string GetHardCopyPublicationDetails();
    }
}
