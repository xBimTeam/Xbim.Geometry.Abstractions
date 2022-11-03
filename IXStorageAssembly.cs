using System;
using System.Collections.Generic;
using System.Text;

namespace Xbim.Geometry.Abstractions
{
    public interface IXStorageAssembly
    {
        /// <summary>
        /// Creates the first top level shape
        /// </summary>
        /// <param name="name">Name of the top level</param>
        /// <param name="defaultShape">Defalut is a compouns shape when null</param>
        /// <returns></returns>
        IXStorageItem NewTopLevelShape(string name, IXShape defaultShape = null);
        IXStorageItem AddShape(string name, IXShape shape, bool expand = false);
        void UpdateAssemblies();
        
    };
}

